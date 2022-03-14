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
using GMap.NET.WindowsForms.ToolTips;
using System.Drawing.Drawing2D;

 
namespace GCS_MH001
{
    public partial class Form1 : Form
    {

        UC_gMap uc_gmap = new UC_gMap();


        public Form1()
        {
            InitializeComponent();

            gmap.Controls.Add(uc_gmap);

            //--------------port목록 불러오는 함수-----------//
            string[] comlist = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string portnum in comlist)
            {
                PortBox.Items.Add(portnum);
            }
            // ---------------------------------------------------//

            serialport.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

            // serialport.DataReceived += sp_DataReceived;


            // route
            //points.Add(new PointLatLng(37.514593, 127.098149));
            //points.Add(new PointLatLng(37.55593, 127.108149));
            //주작용 데이터
            textBox_lat.Text = "37.547696";
            textBox_lng.Text = "127.118529";

            textBox_hdop.Text = "3.6";
            textBox_roll.Text = "63.2341";
            textBox_pitch.Text = "8.8879";
            textBox_yaw.Text = "271.1867";







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
        //저장용 패킷 리스트
        private List<Byte> _DataList;
        private List<Byte> DataList
        {
            get
            {
                if (_DataList == null)
                    _DataList = new List<Byte>();
                return _DataList;
            }
        }
        // 사출 불리언
        bool eject = false;


        //좌표 지점 설정
        //List<PointLatLng> points = new List<PointLatLng>();




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
            //Port.Open();
        }

        // Parsing 함수
        void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //this.Invoke(new EventHandler(Parse));
            int size = serialport.BytesToRead;

            byte[] packet = new byte[30];
            byte[] buff = new byte[size];
            float lat = 0;
            float lng = 0;
            float hdop = 0;
            float roll = 0;
            float pitch = 0;
            float yaw = 0;

            StreamWriter sw = new StreamWriter(@"C:\Users\임현우\Desktop\GCS_MH\GCS_MH001\GCS_MH001\bin\Debug\Flight_DATA.txt", true);
            for (int i = 0; i < size; i++)
            {

                RecvDataList.Add((Byte)serialport.ReadByte());

                if (i > 12 && RecvDataList[i] == 0xDD && RecvDataList[i - 1] == 0xDD && RecvDataList[i - 2] == 0xDF && RecvDataList[i - 3] == 0xDF && RecvDataList[i - 12] == 0xDD && RecvDataList[i - 13] == 0xDD)
                {
                    eject = true;
                    for (int j = 0; j < 10; j++)
                    {
                        packet[j] = RecvDataList[i - 13 + j];  // 사출후 패킷 
                    }
                }

                else if (i > 29 && RecvDataList[i] == 0xFF && RecvDataList[i - 1] == 0xFF && RecvDataList[i - 2] == 0xFE && RecvDataList[i - 3] == 0xFE && RecvDataList[i - 28] == 0xFF && RecvDataList[i - 29] == 0xFF)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        packet[j] = RecvDataList[i - 29 + j];  // 사출 전 패킷
                        DataList.Add(packet[j]); // 저장용 패킷 리스트
                        
                        sw.Write(packet[j].ToString("X2"));
                        
                    }
                }
            }
            

            sw.Close();
            // CheckSum
            /*
            UInt32 packet_sum = 0;
            for (int i = 3; i < 36; i++)
            {
                packet_sum += packet[i];
            }

            uint checksum = ~packet_sum + 1; //char?
            */

            // Data 지정
            lat = System.BitConverter.ToSingle(packet, 2);
            lng = System.BitConverter.ToSingle(packet, 6);
            hdop = System.BitConverter.ToSingle(packet, 10);
            roll = System.BitConverter.ToSingle(packet, 14);
            pitch = System.BitConverter.ToSingle(packet, 18);
            yaw = System.BitConverter.ToSingle(packet, 22);



            // Data 가공
            //lat = roll; //지울거임
            //lng = yaw;  //지울거임
            double latitude = Convert.ToDouble(lat);
            double longitude = Convert.ToDouble(lng);


            if (latitude != 0 && longitude != 0)
            {
              
                //uc_gmap.updateMarker(latitude, longitude); // 점을 이용해서 그림
                uc_gmap.updateRoute(latitude, longitude, eject); // 직선을 이용해서 그림


                // 자표 리스트에 저장
                //points.Add(new PointLatLng(latitude, longitude));

                //uc_gmap.updateRoute(points);
                // Label 

                this.Invoke(new Action(delegate ()
                {
                    textBox_lat.Text = latitude.ToString();
                    textBox_lng.Text = longitude.ToString();

                    textBox_hdop.Text = hdop.ToString();
                    textBox_roll.Text = roll.ToString();
                    textBox_pitch.Text = pitch.ToString();
                    textBox_yaw.Text = yaw.ToString();

                }));

            }



            RecvDataList.RemoveRange(0, RecvDataList.Count);
            //points.RemoveRange(0, 1);
            Thread.Sleep(100);
        }





        //------------------종료시 이벤트-------------------------------------//
        private void Mhhyunw_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dresult = MessageBox.Show("종료하시겠습니까?", "", MessageBoxButtons.YesNoCancel);
            if (dresult == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
                saveFileDialog.Title = "Save Data";
                saveFileDialog.ShowDialog();
                string fileName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(fileName, DataList.ToString());

                serialport.Close();
                e.Cancel = false; // 그냥 종료
            }
            else if (dresult == DialogResult.Cancel) // 종료하지 않음
                e.Cancel = true;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            uc_gmap.Zooming(vScrollBar1.Value);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            uc_gmap.ClearMarker();
        }

        private void button_eject_Click(object sender, EventArgs e)
        {
            if (eject == true)
            {
                eject = false;
                this.BackColor = DefaultBackColor;
            }
            else
            {
                eject = true;
                this.BackColor = Color.Red;
            }
        }

        private void button_distance_Click(object sender, EventArgs e)
        {

        }

        private void button_focus_Click(object sender, EventArgs e)
        {
           // uc_gmap.Focus(latitude, longitude); // 중심 맞추기
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (eject == true)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.Red;
            }
            else if (eject == false)
            {
                checkBox1.Checked = false;
                this.BackColor = DefaultBackColor;
            }
 
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            serialport.Close();
        }
    }
}



