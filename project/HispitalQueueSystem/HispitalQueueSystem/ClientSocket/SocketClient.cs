﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using CableTestManager.ClientSocket.AppBase;

namespace CableTestManager.ClientSocket
{
    public class SocketClient
    {
        public Socket socketClient { get; set; }

        public string ServerIP { get; set; }

        public int ServerPort { get; set; }

        public void StartSocket()
        {
            //创建实例
            socketClient = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint point = new IPEndPoint(ip, 10002);
            //进行连接
            socketClient.Connect(point);

            Task task = new Task(ReciveMsg);
            task.Start();
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="o"></param>
        private void ReciveMsg()
        {
            while (true)
            {
                int bufferSize = socketClient.ReceiveBufferSize;
                byte[] buffer = new byte[bufferSize];
                var effective = socketClient.Receive(buffer);
                if (effective == 0)
                {
                    break;
                }
                ProcessMsg(buffer);
            }
        }

        private void ProcessMsg(byte[] revMsg)
        {
            //从服务获取所有设备信息

        }

        public void SendAsciiMsg(string msg)
        {
            var buffter = Encoding.ASCII.GetBytes(msg);
            socketClient.Send(buffter);
        }

        public void SendByteMsg(byte[] msg)
        {
            socketClient.Send(msg);
        }
    }
   
}
