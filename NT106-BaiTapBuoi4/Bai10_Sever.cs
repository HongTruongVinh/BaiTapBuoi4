using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace NT106_BaiTapBuoi4
{
    public partial class Bai10_Sever : Form
    {
        public Bai10_Sever()
        {
            InitializeComponent();
        }

        private TcpListener chatSever;
        private TcpClient chatClient;
        private Thread thdListener;
        private NetworkStream stream;

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Cổng không hợp lệ!");
                return;
            }
            try
            {
                chatSever = new TcpListener(localAddr, port);
                chatSever.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                recordMessage("Sever đã khởi động!\n");
                thdListener = new Thread(new ThreadStart(listenerThread));
                thdListener.IsBackground = true;
                thdListener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khởi động Sever thất bại!\n" + ex.ToString());
                return;
            }
        }

        private void listenerThread()
        {
            while (true)
            {
                chatClient = chatSever.AcceptTcpClient();
                recordMessage("Đã kết nối với Client!");
                stream = chatClient.GetStream();
                byte[] data = new Byte[256];
                int i;
                while ((i = stream.Read(data, 0, data.Length)) != 0)
                {
                    String responseData = Encoding.UTF8.GetString(data, 0, i);
                    responseData = responseData.ToUpper();
                    byte[] msg = Encoding.UTF8.GetBytes(responseData);
                    recordMessage(responseData);
                    stream.Write(msg, 0, msg.Length);
                }
                chatClient.Close();
            }
        }

        private void recordMessage(String responseData)
        {
            if (txtResults.InvokeRequired)
            {
                Action safeFill = delegate { recordMessage(responseData); };
                txtResults.Invoke(safeFill);
            }
            else
            {
                txtResults.Text += "[" + DateTime.Now.ToString("HH:mm:ss tt") + "] " + responseData + "\r\n";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thdListener.Abort();
            chatSever.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            recordMessage("Sever đã ngắt!");
        }
    }
}
