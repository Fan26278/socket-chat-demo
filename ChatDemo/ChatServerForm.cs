using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChatDemo
{
    public partial class ChatServerForm : Form
    {
        bool conn;
        
        Socket socket;
     
        Thread accpectClientThread;
        List<Socket> ClientProxySocketList = new List<Socket>();
        public ChatServerForm()
        {
            InitializeComponent();
       

        }


        //此方法用于开启监听服务
        private void btnStart_Click(object sender, EventArgs e)
        {

            conn = true;
            // 1 创建Socket对象
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
             ProtocolType.Tcp);
            // 2 绑定端口ip
            socket.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text),int.Parse(txtPort.Text)));

            // 3 开启监听
            socket.Listen(10);
            AppendTxttoTxtLog("服务已经启动，正在监听");


            // 4 开始接受客户端的链接,不写多线程会阻塞当前线程
           ThreadPool.QueueUserWorkItem(new WaitCallback(AcceptClientConnect), socket);
            //accpectClientThread = new Thread(AcceptClientConnect);
            //accpectClientThread.Start();

        }
        public void AcceptClientConnect(object state) { 
            
            var serverSocket = socket;
            while(conn)
            {
          
                AppendTxttoTxtLog("开始接收客户端链接");
             
                try
                {
                    var proxSocket = serverSocket.Accept();
                    ClientProxySocketList.Add(proxSocket);
                    AppendTxttoTxtLog(string.Format("客户端{0}加入", proxSocket.RemoteEndPoint.ToString()));


                    // 不停的接收客户端发送来的消息
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ReceiveData), proxSocket);
                }
                catch
                {
                    socket.Close();
                    return;
                }

            }
            return;

        }
        // 接收客户端消息
        public void ReceiveData(object socket)
        {
            var proxySocket = socket as Socket;
            byte[] data = new byte[1024*1024];
            while (conn)
            {
                int len = 0;
                try
                {
                    // 接收数据
                 len = proxySocket.Receive(data, 0, data.Length, SocketFlags.None);
                }catch (Exception ex)
                {
                    // 异常退出
                   AppendTxttoTxtLog(string.Format("{0}号客户端异常退出",
                   proxySocket.RemoteEndPoint.ToString()));
                    ClientProxySocketList.Remove(proxySocket);
                    return;
                }
                // 接收到数据后
                 
                string str = Encoding.UTF8.GetString(data,0,len);
                if (len <= 0)
                {
                    // 客户端正确退出
                    AppendTxttoTxtLog(string.Format("{0}号客户端退出",
                     proxySocket.RemoteEndPoint.ToString()));

                    ClientProxySocketList.Remove(proxySocket);
                    return;// 让方法结束，线程也就结束
                }


                AppendTxttoTxtLog(string.Format("接收到客户端：{0}的消息是：{1}",
                    proxySocket.RemoteEndPoint.ToString(),str));
               // 把接收到的数据放到文本框
            }
            return;
        }
        
        public void AppendTxttoTxtLog(string text)
        {
            if (txtLog.InvokeRequired)
            {
               txtLog.Invoke(new Action<string>(s =>
                {
                    this.txtLog.Text = string.Format("{0}\r\n{1}", txtLog.Text, s);
                }),text);

            }
            else
            {
                this.txtLog.Text = string.Format("{1}\r\n{0}", text, txtLog.Text);
            }


           
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            foreach(var proxySocket in ClientProxySocketList) {
            
                if (txtMessage.Text.Length != 0 && proxySocket.Connected )
                {
                    byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                    proxySocket.Send(data,0,data.Length,SocketFlags.None);


                    // 点击发送按钮后，清空框内内容
                    AppendTxttoTxtLog(string.Format("向客户端发送了消息：{0}", txtMessage.Text));
                    txtMessage.Text = string.Empty;

                }

            }
        



        }

        private void ClearTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtLog.Text = string.Empty;
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnSendMessage_Click(sender,e);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
                conn = false;
                socket.Close();
                ClientProxySocketList.Clear();
                MessageBox.Show("关闭端口了！！！");
        }
    }
}
