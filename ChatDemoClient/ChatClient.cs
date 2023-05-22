using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChatDemoClient
{
    public partial class ChatClient : Form
    {
        Socket clientScoket;
        bool conn;
        public ChatClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                // 1 创建Socket对象
            clientScoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            

            // 2 链接服务端
            try {
                clientScoket.Connect(new IPEndPoint(IPAddress.Parse(ipText.Text), int.Parse(portText.Text)));
              
            }
            catch 
            {
                MessageBox.Show("链接服务器失败了，服务端正确开启了吗？IP和端口号正确吗？");
            }
                
               
           
          

            if (clientScoket.Connected)
            {
                conn = true;
                AppendTxttoTxtLog("已经连接至服务端");
                button1.Visible=false;
            }
            else
            {
                AppendTxttoTxtLog("连接失败！！");
            }


            // 不停的接收客户端发送来的消息
            ThreadPool.QueueUserWorkItem(new WaitCallback(ReceiveData), clientScoket);


        }

        private void ReceiveData(object state)
        {
            // 定义buffer接收数据
            byte[] data = new byte[1024 * 1024];
            while (conn)
            {

                int len = 0;
                try
                {
                    // 接收数据
                    len = clientScoket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception ex)
                {
                    // 异常退出
                    AppendTxttoTxtLog(string.Format("连接失败"));

                    clientScoket.Close();
                    return;

                }
                // 接收到数据后
                // Encoding 的编码格式 发送端和接收端 要一致，否则乱码
                string str_recive = Encoding.UTF8.GetString(data, 0, len);
                if (len <= 0)
                {
                    //客户端结束
                    AppendTxttoTxtLog("服务端异常结束");
                    clientScoket.Close();
                    return;// 让方法结束，线程也就结束


                }
                // 把接收到的数据放到文本框
                AppendTxttoTxtLog(string.Format("接收到服务器信息：{0}", str_recive));

            }
            return;

        }

        private void AppendTxttoTxtLog(string text)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(s =>
                {
                    this.txtLog.Text = string.Format("{0}\r\n{1}", txtLog.Text, s);
                }), text);

            }
            else
            {
                this.txtLog.Text = string.Format("{1}\r\n{0}", text, txtLog.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (txtMessage.Text.Length !=0 && clientScoket.Connected)
            {
                //向客户端发送信息的转换
                byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                clientScoket.Send(data, 0, data.Length, SocketFlags.None);

                //点击发送按钮后，清空框内内容
                AppendTxttoTxtLog(string.Format("向服务端发送了消息：{0}", txtMessage.Text));
                txtMessage.Text = string.Empty;
            }
          

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                button2_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn) {
                conn = false;
                clientScoket.Close();
                button1.Visible = true;
                MessageBox.Show("主动断开了链接");
            }
            else
            {
                MessageBox.Show("没有链接！");
            }

        }
    }
}

