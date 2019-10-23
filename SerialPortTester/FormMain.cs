using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortTester
{
    public partial class FormMain : Form
    {
        SerialPort sp = null;
        bool isHex = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitSerialPort()
        {
            if (ComboBox_PortName.Text.Trim() == "")
            {
                MessageBox.Show("串口不能为空", "错误");
                return;
            }

            sp = new SerialPort();

            sp.PortName = ComboBox_PortName.Text.Trim();
            sp.BaudRate = Convert.ToInt32(ComboBox_BaudRate.Text.Trim());

            float f = Convert.ToSingle(ComboBox_StopBits.Text.Trim());
            if (f == 0)
            {
                sp.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (f == 1)
            {
                sp.StopBits = StopBits.One;
            }
            else if (f == 2)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }

            sp.DataBits = Convert.ToInt16(ComboBox_DataBits.Text.Trim());

            string s = ComboBox_Parity.Text.Trim();
            if (s.CompareTo("无") == 0)
            {
                sp.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }

            sp.ReadTimeout = 1000;
            sp.WriteTimeout = 500;

            sp.Handshake = Handshake.None;

            sp.DtrEnable = false;
            sp.RtsEnable = false;

            sp.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
            if (RadioButton_Hex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitControls();

            DetectingComPort();
        }

        private void InitControls()
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            for (int i = 0; i < 8; i++)
            {
                ComboBox_PortName.Items.Add("COM" + (i + 1).ToString());
            }
            ComboBox_PortName.SelectedIndex = 0;

            ComboBox_BaudRate.Items.Add("1200");
            ComboBox_BaudRate.Items.Add("2400");
            ComboBox_BaudRate.Items.Add("4800");
            ComboBox_BaudRate.Items.Add("9600");
            ComboBox_BaudRate.Items.Add("19200");
            ComboBox_BaudRate.Items.Add("38400");
            ComboBox_BaudRate.Items.Add("43000");
            ComboBox_BaudRate.Items.Add("56000");
            ComboBox_BaudRate.Items.Add("57600");
            ComboBox_BaudRate.Items.Add("115200");
            ComboBox_BaudRate.SelectedIndex = 9;

            ComboBox_StopBits.Items.Add("0");
            ComboBox_StopBits.Items.Add("1");
            ComboBox_StopBits.Items.Add("1.5");
            ComboBox_StopBits.Items.Add("2");
            ComboBox_StopBits.SelectedIndex = 1;

            ComboBox_DataBits.Items.Add("5");
            ComboBox_DataBits.Items.Add("6");
            ComboBox_DataBits.Items.Add("7");
            ComboBox_DataBits.Items.Add("8");
            ComboBox_DataBits.SelectedIndex = 3;

            ComboBox_Parity.Items.Add("无");
            ComboBox_Parity.Items.Add("奇校验");
            ComboBox_Parity.Items.Add("偶校验");
            ComboBox_Parity.SelectedIndex = 0;

            RadioButton_Char.Checked = true;
        }

        private void DetectingComPort()
        {
            ComboBox_PortName.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    ComboBox_PortName.Items.Add("COM" + (i + 1).ToString());
                }
                catch
                {
                    continue;
                }
            }

            if (ComboBox_PortName.Items.Count > 0)
            {
                ComboBox_PortName.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("没有找到可用串口", "错误");
            }
        }

        private void Button_OpenCOM_Click(object sender, EventArgs e)
        {
            if (sp == null || sp.IsOpen == false)
            {
                InitSerialPort();
            }

            if (ComboBox_PortName.Text.Trim() == ""
                || ComboBox_BaudRate.Text.Trim() == ""
                || ComboBox_DataBits.Text.Trim() == ""
                || ComboBox_Parity.Text.Trim() == ""
                || ComboBox_StopBits.Text.Trim() == "")
            {
                MessageBox.Show("串口未设置", "错误");
                return;
            }

            try
            {
                sp.Open();

                SetControlStatus(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口无效或已被占用:" + ex.Message, "错误");
            }
        }

        private void SetControlStatus(bool openState)
        {
            ComboBox_PortName.Enabled = !openState;
            ComboBox_BaudRate.Enabled = !openState;
            ComboBox_DataBits.Enabled = !openState;
            ComboBox_Parity.Enabled = !openState;
            ComboBox_StopBits.Enabled = !openState;
            RadioButton_Char.Enabled = !openState;
            RadioButton_Hex.Enabled = !openState;
            button_Open.Enabled = !openState;
            button_Close.Enabled = openState;
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.WriteLine(TextBox_SendData.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发送数据时发生错误:" + ex.Message, "错误");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误");
                return;
            }

            if (TextBox_SendData.Text.Trim() == "")
            {
                MessageBox.Show("请输入要发送的数据", "错误");
                return;
            }
        }

        private void Button_CleanData_Click(object sender, EventArgs e)
        {
            TextBox_RecvData.Text = "";
            TextBox_SendData.Text = "";
        }

        private void SerialPortDataReceived(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
            {
                return;
            }

            try
            {
                if (isHex == false)
                {
                    string data = sp.ReadLine();
                    SetText(data);
                }
                else
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    String RecvDataText = "";
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                    }
                    SetText(RecvDataText);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            if (sp.IsOpen)
            {
                sp.DiscardInBuffer();
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (TextBox_RecvData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                TextBox_RecvData.Text += text + "\r\n";
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();

                    SetControlStatus(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("关闭串口时发生错误:" + ex.Message, "错误");
                }
            }
        }

        private void button_ClearReceive_Click(object sender, EventArgs e)
        {
            TextBox_RecvData.Text = "";
        }

    }
}