using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial_exp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] comlist = System.IO.Ports.SerialPort.GetPortNames();

            if (comlist.Length > 0)
            {
                comboBox1.Items.AddRange(comlist);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

        }
    }
}
