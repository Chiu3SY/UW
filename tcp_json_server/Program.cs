using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace tcp_json_server
{
    public delegate void ControlLight(bool e, string result);
    class Program
    {
        static void Main(string[] args)
        {
            Serverprovider server = new Serverprovider();
            Console.WriteLine("服务器已启动，正在监听端口1235...");
            // 防止程序退出
            Console.ReadLine();
        }
    }
    //public class mediaclass
    //{
        
    //}
    public class Serverprovider
    {
        Socket socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> socketList = new List<Socket>();
        //mediaclass nmediaclass = new mediaclass();
        public event ControlLight controlLight;

        public Serverprovider()
        {
            IPEndPoint port = new IPEndPoint(IPAddress.Any, 1235);
            socketwatch.Bind(port);
            socketwatch.Listen(1);
            Thread listenthread = new Thread(Listening);
            listenthread.IsBackground = true;
            listenthread.Start();
        }

        private void Listening()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(100);
                    //握手连接
                    Socket socket = socketwatch.Accept();
                    socketList.Add(socket);
                    Console.WriteLine("有客户端连接：" + socket.RemoteEndPoint.ToString());
                    Thread receivthread = new Thread(receiving);
                    receivthread.IsBackground = true;
                    receivthread.Start(socket);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("监听异常：" + ex.Message);
                }
            }
        }

        private void receiving(object obj)
        {
            Socket socket = obj as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int n = socket.Receive(buffer);
                    if (n == 0)
                    {
                        Console.WriteLine("客户端断开连接：" + socket.RemoteEndPoint.ToString());
                        socketList.Remove(socket);
                        socket.Close();
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, n);
                    Console.WriteLine("收到数据：" + str);
                    // 解析json
                    dynamic data = JsonConvert.DeserializeObject(str);
                    bool zone = bool.Parse(data["LivingRoomLighting"].ToString());
                    string result;
                    if (zone)
                    {
                        result = "{\"Result\":true,\"ErrorCode\":0,\"Message\":\"LivingRoomLighting Is Open\"}";
                        //加一个委托，控制灯的开关
                        controlLight?.Invoke(true, "LivingRoomLighting Is Open");
                    }
                    else
                    {
                        result = "{\"Result\":true,\"ErrorCode\":0,\"Message\":\"LivingRoomLighting Is Close\"}";
                        controlLight?.Invoke(false, "LivingRoomLighting Is Close");
                    }
                    byte[] bufferback = Encoding.UTF8.GetBytes(result);
                    socket.Send(bufferback);
                    Console.WriteLine("发送回执：" + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("接收异常：" + ex.Message);
                    socketList.Remove(socket);
                    socket.Close();
                    break;
                }
            }
        }
    }
}
