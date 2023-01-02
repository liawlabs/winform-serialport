using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort
{
    public partial class SerialConn : Form
    {
        Timer watchDog;
        System.IO.Ports.SerialPort sp;

        public SerialConn()
        {
            InitializeComponent();
        }

        private void SerialConn_Load(object sender, EventArgs e)
        {
            // Logic
            sp = serialPort1;
            cb_com_port.Items.Clear();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            cb_com_port.Items.AddRange(ports);
            if (cb_com_port.Items.Count != 0)
                cb_com_port.SelectedIndex = 0;

            //Timer WatchDog for Serial Port
            watchDog = new Timer();
            watchDog.Tick += WatchDog_Tick;
            watchDog.Interval = 5000;
        }

        private async void WatchDog_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
            {
                watchDog.Stop();
                cb_com_port.Items.Clear();

                cb_com_port.Text = "";
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                cb_com_port.Items.AddRange(ports);
                if (cb_com_port.Items.Count != 0)
                    cb_com_port.SelectedIndex = 0;
                lbl_connction_status.BackColor = Color.Empty;

                MessageBox.Show("Please Check COM Port", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbl_connction_status.BackColor = Color.Empty;
                await Task.Delay(200);
                lbl_connction_status.BackColor = Color.Green;
                await Task.Delay(200);
                lbl_connction_status.BackColor = Color.Empty;
                await Task.Delay(100);
                lbl_connction_status.BackColor = Color.Green;
                await Task.Delay(100);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = cb_com_port.Text;
                sp.BaudRate = 115200;
                sp.Open();
                watchDog.Start();
                lbl_connction_status.BackColor = Color.Green;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                watchDog.Stop();
                cb_com_port.Items.Clear();
                cb_com_port.Text = "";
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                cb_com_port.Items.AddRange(ports);
                if (cb_com_port.Items.Count != 0)
                    cb_com_port.SelectedIndex = 0;
                lbl_connction_status.BackColor = Color.Empty;
            }
        }

        private void cb_com_port_DropDown(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                cb_com_port.Items.Clear();
                cb_com_port.Text = "";
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                cb_com_port.Items.AddRange(ports);
                if (cb_com_port.Items.Count != 0)
                    cb_com_port.SelectedIndex = 0;
                lbl_connction_status.BackColor = Color.Empty;
            }
        }
    }
}
