using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
using tcp_json_server;
namespace tcp_json_communication
{
    public partial class Form1 : Form
    {
        Socket socket;
        static IPEndPoint port;
        Thread receiptbackthread;
        Server server;
        //Serverprovider serverer;
        //������Ҫ����Serverprovider�е�controlLight ί�У������ҵ�Serverprovider�����ж˿�ռ�ã�����ظ�ʵ����Serverprovider�ᵼ�¶˿ڳ�ͻ��
        public Form1()
        {
            InitializeComponent();
            server = new Server();
            server.setText += controllight;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            port = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1235);
            socket.Connect(port);
            receiptbackthread = new Thread(receiptback);
            receiptbackthread.IsBackground = true;
            receiptbackthread.Start(socket);
        }
        private void controllight(bool e, string result)
        {
            if (textBox1.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    if (e)
                    {
                        lablelight.BackColor = Color.Yellow;
                        textBox1.AppendText("{\"LivingRoomLighting\":controltrue}");
                    }
                    else
                    {
                        lablelight.BackColor = SystemColors.Control;
                        textBox1.AppendText("{\"LivingRoomLighting\":controlfalse}");
                    }
                }));
            }
            else
            {
                textBox2.AppendText(result);
                if (e)
                {
                    lablelight.BackColor = Color.Yellow;
                }
                else
                {
                    lablelight.BackColor = SystemColors.Control;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "��")
                {
                    button1.Text = "��";
                    string order = "{\"LivingRoomLighting\":false}";
                    byte[] buffer = Encoding.UTF8.GetBytes(order);
                    //���ö�����ӣ�
                    //socket.Connect(port);
                    socket.Send(buffer);
                }
                else
                {
                    button1.Text = "��";
                    string order = "{\"LivingRoomLighting\":true}";
                    byte[] buffer = Encoding.UTF8.GetBytes(order);
                    //socket.Connect(port);
                    socket.Send(buffer);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        private void receiptback(object obj)
        {
            socket = obj as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int n = socket.Receive(buffer);
                    string str = Encoding.UTF8.GetString(buffer, 0, n);
                    if (!string.IsNullOrEmpty(str))
                    {
                        dynamic data = JsonConvert.DeserializeObject(str);
                        bool result = data["Result"];
                        string message = data["Message"];
                        // ��UI�߳��и��¿ؼ�
                        this.Invoke(new Action(() =>
                            {
                                textBox2.AppendText(str + Environment.NewLine);
                                if (message.Contains("Open"))
                                {
                                    lablelight.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    lablelight.BackColor = SystemColors.Control;
                                }
                            }));
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
