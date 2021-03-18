using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SerialPortTool
{
    public partial class SerialPortTool : Form
    {
        List<string> SerialPortMsg = new List<string>();
        string Msg_TXText = "";

        public SerialPortTool()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void comboBox_portName_DropDown(object sender, EventArgs e)
        {
            try
            {
                comboBox_portName.Items.Clear(); // 清除串口
                string[] gCOM = System.IO.Ports.SerialPort.GetPortNames(); // 获取设备的所有可用串口
                foreach (string com in gCOM)
                {
                    comboBox_portName.Items.Add(com); // 依次添加到下拉框中
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_baudRate_DropDown(object sender, EventArgs e)
        {
            try
            {
                comboBox_baudRate.Items.Clear(); // 清除波特率
                string[] baudrateList = new string[] { "115200" };
                foreach (string rate in baudrateList)
                {
                    comboBox_baudRate.Items.Add(rate); // 依次添加到下拉框中
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_SW_Click(object sender, EventArgs e)
        {
            try
            {
                if (Button_SW.ImageIndex == 0)
                {
                    serialPort.PortName = comboBox_portName.Text;
                    if ("" == comboBox_baudRate.Text)
                    {
                        comboBox_baudRate.Items.Add("115200");
                        comboBox_baudRate.Text = "115200";
                    }
                    serialPort.BaudRate = int.Parse(comboBox_baudRate.Text);
                    serialPort.Open();
                    comboBox_portName.Enabled = false;
                    comboBox_baudRate.Enabled = false;
                    Button_SW.ImageIndex = 1;
                    LED.ImageIndex = 1;
                    RichTextBox_RX_WrText("端口“" + serialPort.PortName + "”已打开，波特率为" + serialPort.BaudRate + "。\n");
                }
                else
                {
                    serialPort.Close();
                    Timer_TXMsg.Enabled = false;
                    RichTextBox_TX.Enabled = true;
                    CheckBox_CycleTX.Enabled = true;
                    TextBox_CycleTime.Enabled = true;
                    comboBox_portName.Enabled = true;
                    comboBox_baudRate.Enabled = true;
                    Button_SW.ImageIndex = 0;
                    LED.ImageIndex = 0;
                    RichTextBox_RX_WrText("\n端口“" + serialPort.PortName + "”已关闭。\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Button_TX_Click(object sender, EventArgs e)
        {
            try
            { 
                if ( (false == Timer_TXMsg.Enabled) &&
                     (true  == serialPort.IsOpen)
                   )
                {
                    if (false == RichTextBox_TX.Text.Equals(""))
                    {
                        Msg_TXText = RichTextBox_TX.Text;

                        if (false != CheckBox_CycleTX.Checked)
                        {
                            Timer_TXMsg.Enabled = true;
                            CheckBox_CycleTX.Enabled = false;
                            TextBox_CycleTime.Enabled = false;
                            RichTextBox_TX.Enabled = false;

                            Timer_TXMsg.Interval = int.Parse(TextBox_CycleTime.Text);
                        }
                        else
                        {
                            Timer_TXMsg.Enabled = false;
                            CheckBox_CycleTX.Enabled = true;
                            TextBox_CycleTime.Enabled = true;
                            RichTextBox_TX.Enabled = true;

                            serialPort_TX(Msg_TXText);
                        }
                    }
                }
                else
                {
                    Timer_TXMsg.Enabled = false;
                    RichTextBox_TX.Enabled = true;
                    CheckBox_CycleTX.Enabled = true;
                    TextBox_CycleTime.Enabled = true;
                    RichTextBox_TX.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                RichTextBox_RX_WrText(ex.Message);
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] ReDatas = new byte[serialPort.BytesToRead]; //开辟接收缓冲区
                serialPort.Read(ReDatas, 0, ReDatas.Length); //从串口读取数据
                SerialPortMsg.Add(serialPort_DataAnalysis(ReDatas));//实现数据的解码与显示
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer_TX_Tick(object sender, EventArgs e)
        {
            try
            {
                serialPort_TX(Msg_TXText);
            }
            catch (Exception ex)
            {
                RichTextBox_RX_WrText("[" + DateTime.Now.TimeOfDay.ToString() + "] " + "TX_Tick ERR: " + ex.Message);
            }
        }

        public string serialPort_DataAnalysis(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("["+ DateTime.Now.TimeOfDay.ToString()+"] "+"RX: ");
            foreach (int d in data)
            {
                sb.AppendFormat("{0:x2}" + " ", d);
            }
            return sb.ToString().ToUpper();
        }
        
        public string Convert_HexArrToString(string strHex) //16进制数组转ASCII字符串
        {
            StringBuilder sb = new StringBuilder();
            string[] strArrHex = strHex.Split(' ');
            foreach (string item in strArrHex)
            {
                //将十六进制转换成10进制
                int ten = Convert.ToInt32(item, 16);
                char cc = (char)ten;
                sb.Append(cc);
            }
            string s = sb.ToString();
            return s;
        }

        private void serialPort_TX(string str)
        {
            try
            {
                serialPort.Write(Convert_HexArrToString(str));
                SerialPortMsg.Add("[" + DateTime.Now.TimeOfDay.ToString() + "] " + "TX: " + str);
            }
            catch (Exception ex)
            {
                RichTextBox_RX_WrText("[" + DateTime.Now.TimeOfDay.ToString() + "] " + "TX ERR: " + ex.Message);
            }
        }

        private void RichTextBox_RX_WrText(string str)
        {
            bool WrFlg = false;
            try
            {
                if (false == WrFlg)
                {
                    WrFlg = true;
                    if (true == RichTextBox_RX.Modified)
                    {
                        RichTextBox_RX.AppendText("\n");
                    }
                    RichTextBox_RX.AppendText(str);
                    RichTextBox_RX.ScrollToCaret();
                    LED.ImageIndex = (1 == LED.ImageIndex) ? 2 : 1;
                    WrFlg = false;
                }
            }
            catch (Exception ex)
            {
                RichTextBox_RX_WrText("[" + DateTime.Now.TimeOfDay.ToString() + "] " + "RX_WrText ERR: " + ex.Message);
            }
        }

        private void Timer_SerialPortMsg_Tick(object sender, EventArgs e)
        {
            if (0 != SerialPortMsg.Count)
            {
                RichTextBox_RX_WrText(SerialPortMsg[0]);
                SerialPortMsg.Remove(SerialPortMsg[0]);
            }
        }

        private void RichTextBox_TX_KeyUp(object sender, KeyEventArgs e)
        {
            char[] hexChar = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f' };
            string Data = "";

            for (int i = 0; i < RichTextBox_TX.Text.Length; i++)
            {
                foreach (char c in hexChar)
                {
                    if (c.Equals(RichTextBox_TX.Text[i]))
                    {
                        Data += c.ToString();
                    }
                }
            }

            RichTextBox_TX.Clear();

            for (int i = 0; i < Data.Length; i++)
            {
                if ((0 < i) && (0 == (i % 2)))
                {
                    RichTextBox_TX.AppendText(" ");
                }
                RichTextBox_TX.AppendText(Data[i].ToString());
            }
        }

        private void InfBox_RX_Text全选_Click(object sender, EventArgs e)
        {
            RichTextBox_RX.Focus();
            RichTextBox_RX.SelectAll();
        }

        private void InfBox_RX_Text清除_Click(object sender, EventArgs e)
        {
            RichTextBox_RX.Focus();
            RichTextBox_RX.Clear();
        }

        private void InfBox_TX_Text全选_Click(object sender, EventArgs e)
        {
            RichTextBox_TX.Focus();
            RichTextBox_TX.SelectAll();
        }

        private void InfBox_TX_Text清除_Click(object sender, EventArgs e)
        {
            RichTextBox_TX.Focus();
            RichTextBox_TX.Clear();
        }

        private void 关于_Click(object sender, EventArgs e)
        {
            try
            {
                Form 关于 = new 关于SerialPortTool();
                关于.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 保存_Click(object sender, EventArgs e)
        {

        }

        private void Tool_TXD_Click(object sender, EventArgs e)
        {
            try
            {
                Form TXD = new Tool_TXD();
                TXD.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
