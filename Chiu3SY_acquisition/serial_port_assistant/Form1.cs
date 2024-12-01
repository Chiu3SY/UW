using System;
using System.IO.Ports;
using System.Text;
namespace serial_port_assistant
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] serialports = SerialPort.GetPortNames();
            foreach (string port in serialports)
            {
                comboBoxPort.Items.Add(port);
            }
            comboBoxPort.SelectedItem = serialports.Length > 0 ? serialports[0] : "";
            comboBoxBaudRate.SelectedItem = "9600";
            comboBoxDataBits.SelectedItem = "8";
            comboBoxStopBits.SelectedItem = "1";
            comboBoxParity.SelectedItem = "无";
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonOpenPort.Text == "打开串口")
                {
                    serialPort1 = new SerialPort();
                    serialPort1.PortName = comboBoxPort.SelectedItem.ToString();
                    string stopbits = comboBoxStopBits.SelectedItem.ToString();
                    if (stopbits == "1") { serialPort1.StopBits = StopBits.One; }
                    else if (stopbits == "1.5") { serialPort1.StopBits = StopBits.One; }
                    else if (stopbits == "2") { serialPort1.StopBits = StopBits.Two; }
                    serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.SelectedItem);
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.SelectedItem);
                    string checkingbits = comboBoxParity.SelectedItem.ToString();
                    if (checkingbits == "无") { serialPort1.Parity = Parity.None; }
                    else if (checkingbits == "奇校验") { serialPort1.Parity = Parity.Odd; }
                    else if (checkingbits == "偶校验") { serialPort1.Parity = Parity.Even; }
                    serialPort1.Open();
                    buttonOpenPort.Text = "关闭串口";
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                    //Task.Run(() =>
                    //{
                    //    Read();
                    //});
                }
                else
                {
                    serialPort1.Close();
                    buttonOpenPort.Text = "打开串口";
                }
            }
            catch (Exception ex) { Console.WriteLine("" + ex); }
        }
        //
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int num = serialPort1.BytesToRead;
                if (num > 0)
                {
                    if (checkBoxHexDisplay.Checked)
                    {
                        byte[] buffer = new byte[num];
                        serialPort1.Read(buffer, 0, num);
                        StringBuilder hexDisplay = new StringBuilder();
                        foreach (byte b in buffer)
                        {
                            hexDisplay.Append(b.ToString("X2")); // 转换为两位16进制
                        }
                        textBoxDataFrame.Invoke(new Action(() =>
                        {
                            textBoxDataFrame.AppendText(hexDisplay.ToString());
                        }));
                    }
                    else
                    {
                        byte[] buffer = new byte[num];
                        serialPort1.Read(buffer, 0, num);
                        string str = Encoding.Default.GetString(buffer);
                        textBoxDataFrame.Invoke(new Action(() =>
                        {
                            textBoxDataFrame.AppendText(str);
                        }));
                    }
                }
            }
            catch { }
        }
        private void Read()
        {
            while (true)
            {
                int num = serialPort1.BytesToRead;
                if (num > 0)
                {
                    Console.WriteLine("num:" + num);
                }
                Thread.Sleep(100);
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxHexSend.Checked)
                {
                    //我textBoxSend中输入的是16进制的字符串
                    string str = textBoxSend.Text;
                    //比如说要发A，先把A对应到asc码表，A对应的asc码表是65，65对应的16进制是41
                    // 将16进制字符串转换为字节
                    byte byteValue = Convert.ToByte(str, 16);
                    // 发送字节数组。在发送字节流时，serialPort1.Write 按二进制发送数据。
                    serialPort1.Write(new byte[] { byteValue }, 0, 1);
                    //MessageBox.Show($"发送的字节值: {byteValue} (十进制), 0x{byteValue:X2} (十六进制)");
                }
                else
                {
                    serialPort1.Write(textBoxSend.Text);
                }
            }
            catch { }
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            textBoxDataFrame.Clear();
            textBoxSend.Clear();
        }
    }
}
