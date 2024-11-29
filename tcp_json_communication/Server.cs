using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace tcp_json_communication
{
    //创建一个委托来控制form里的控件
    public delegate void delegateCallback(bool e,string result);
    public class Server
    {
        Socket socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> socketList = new List<Socket>();
        public event delegateCallback setText;
        public Server()
        {
            //System.Net.IPAddress ip = System.Net.IPAddress.Parse("
            IPEndPoint port = new IPEndPoint(IPAddress.Any, 1235);
            socketwatch.Bind(port);
            socketwatch.Listen(10);
            Thread listenthread = new Thread(Listening);
            listenthread.IsBackground = true;
            listenthread.Start(socketwatch);
        }

        private void Listening(object obj)
        {
            Socket socket = obj as Socket;
            while (true)
            {
                try
                {
                    socket= socketwatch.Accept();
                    socketList.Add(socket);
                    Thread receivthread = new Thread(receiving);
                    receivthread.IsBackground = true;
                    receivthread.Start(socket);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }


        private void receiving(object obj)
        {
            Socket socket = obj as Socket;
            while (true)
            {
                //接受json,{“LivingRoomLighting”:true},设置lablelight背景颜色，显示json到textbox1，执行完指令后回复客户端完成状态{
                //“Result”:true,
                //“ErrorCode”:0,
                //“Message”:”LivingRoomLighting Is Open”
                //}，显示回执到textbox2
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int n = socket.Receive(buffer);
                    string str = Encoding.UTF8.GetString(buffer, 0, n);
                    //解析json
                    dynamic data = JsonConvert.DeserializeObject(str);
                    bool zone = data["LivingRoomLighting"];
                    if (zone)
                    {
                        //回复客户端
                        string result = "{\"Result\":true,\"ErrorCode\":0,\"Message\":\"LivingRoomLighting Is Open\"}";
                        byte[] bufferback = Encoding.UTF8.GetBytes(result);
                        socket.Send(bufferback);
                        setText?.Invoke(zone, result);
                    }
                    else { 
                        //回复客户端
                        string result = "{\"Result\":true,\"ErrorCode\":0,\"Message\":\"LivingRoomLighting Is Close\"}";
                        byte[] bufferback = Encoding.UTF8.GetBytes(result);
                        socket.Send(bufferback);
                        setText?.Invoke(!zone, result);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
