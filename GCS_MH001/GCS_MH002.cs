using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.IO.Ports;
using System.IO;
using System.Globalization;
using System.Threading;

 
namespace GCS_MH001
{
    public partial class Form1 : Form
    {
        double lati = 37.523593;
        double lngt = 127.088149;
        int buff_count = 0;

        UC_gMap uc_gmap = new UC_gMap();
        
        public Form1()
        {
            InitializeComponent();
            
            //--------------port목록 불러오는 함수-----------//
            string[] comlist = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string portnum in comlist)
            {
                PortBox.Items.Add(portnum);
            }
            // ---------------------------------------------------//
            serialport.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            

            gmap.Controls.Add(uc_gmap);
            
        }


        //수신데이터 버퍼 리스트
        private List<Byte> _RecvDataList;
        private List<Byte> RecvDataList
        {
            get
            {
                if (_RecvDataList == null)
                    _RecvDataList = new List<byte>();
                return _RecvDataList;
            }
        }


        private void start_btn_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialport.PortName = PortBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void eject_btn_Click(object sender, EventArgs e)
        {
        }

        private void Rout_btn_Click(object sender, EventArgs e)
        {
        }

        private void BaudBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BaudBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialport.BaudRate = int.Parse(BaudBox.Text);    // string형을 int로 변환
        }

        private void selec_btn_Click(object sender, EventArgs e)
        {
            serialport.Open();     // Open Port
            serialport.Parity = System.IO.Ports.Parity.None;
            serialport.DataBits = 8;
            serialport.StopBits = System.IO.Ports.StopBits.One;
        }
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Serial Port StreamBuffer에 있는 데이터길이 만큼 데이터 수신 후 분석 버퍼에 채우기
            for (int i = 0; i < serialport.BytesToRead; i++)
            {
                RecvDataList.Add((Byte)serialport.ReadByte());
            }
            //this.Invoke(new EventHandler(Parse));
        }
        

        private void Parse(object s, EventArgs e)
        {
            int size = serialport.BytesToRead;
            string strbyte;
            int time = 0;
            float lat = 0;
            float lng = 0;
            int alt = 0;
            string HDOP = string.Empty;
            string roll = string.Empty;
            string pitch = string.Empty;
            string yaw = string.Empty;
            string dot_roll = string.Empty;
            string dot_pitch = string.Empty;
            string dot_yaw = string.Empty;
            string vx = string.Empty;
            string vy = string.Empty;
            string vz = string.Empty;
            byte[] packet = new byte[40];
            byte[] buff = new byte[size];


            // 버퍼 저장
            if (size != 0)   // 들어오는 값이 0이 아닐 때
            {
                //byte[] packet = new byte[40];
                //byte[] buff = new byte[size];
                strbyte = "";
                for (int i = 0; i < size; i++)
                {
                    buff[i] = (byte)serialport.ReadByte();

                    if (i > 36 && buff[i - 1] == 0xFD && buff[i] == 0xFD) 
                    {
                        for (int j = 0; j < 38; j++)
                        {
                            packet[j] = buff[i - 37 + j];
                        }
                        //int packet_sum;
                        //checksum
                        //for(int i=3; i < 36; i++)
                        //{
                        //  unsinged int packet_sum =+ packet[i];
                        //}

                        //char checksum = ~packet_sum + 1;

                        //데이터 저장
                        
                        time = System.BitConverter.ToInt32(packet, 3);                                              
                        lat = System.BitConverter.ToSingle(packet, 7);                        
                        lng = System.BitConverter.ToSingle(packet, 11);                       
                        alt = System.BitConverter.ToInt16(packet, 15);
                        lati = Convert.ToDouble(lat);
                        lngt = Convert.ToDouble(lng);
                        //label_time.Text = time.ToString();
                        //label_lat.Text = lat.ToString();
                        //label_long.Text = lng.ToString();
                        //label_alt.Text = alt.ToString();
                        //uc_gmap.updateMarker(lati, lngt);
                        
                        foreach (byte b in packet)
                        {
                            if (b != '\r')
                                strbyte += (b.ToString("X2")) + " ";
                        }
                        //Text_Box1.Text += strbyte;
                        System.Array.Clear(packet,0,40);
                        System.Array.Clear(buff, 0, size);
                        size = 0;

                    }
                }
            }

        }

        
        private void Text_Box1_TextChanged(object sender, EventArgs e)
        {

        }
        //------------------종료시 이벤트-------------------------------------//
        private void Mhhyunw_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dresult = MessageBox.Show("현재 상태를 저장하시겠습니까?", "", MessageBoxButtons.YesNoCancel);
            if (dresult == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
                saveFileDialog.Title = "Save Data";
                saveFileDialog.ShowDialog();
                string fileName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fileName, Text_Box1.Text);

                serialport.Close();
                e.Cancel = false; // 그냥 종료
            }
            else if (dresult == DialogResult.Cancel) // 종료하지 않음
                e.Cancel = true;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}



