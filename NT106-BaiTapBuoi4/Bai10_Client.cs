using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NT106_BaiTapBuoi4
{
    public partial class Bai10_Client : Form
    {
        public Bai10_Client()
        {
            InitializeComponent();
        }

        private TcpClient chatClient = new TcpClient();
        private NetworkStream stream;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress severIP;
            if (!IPAddress.TryParse(txtSeverIP.Text, out severIP))
            {
                MessageBox.Show("Địa chỉ IP không hợp lệ!");
                return;
            }
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Cổng không hợp lệ!");
                return;
            }
            try
            {
                chatClient.ConnectAsync(severIP, port);
                recordMessage("Đã kết nối với Sever!");
                Thread thdClient = new Thread(new ThreadStart(clientThread));
                thdClient.IsBackground = true;
                thdClient.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại!\n" + ex.ToString());
                return;
            }
        }

        private void clientThread()
        {
            while (true)
            {
                stream = chatClient.GetStream();
                byte[] data = new Byte[256];
                Int32 bytes = stream.Read(data, 0, data.Length);
                String responseData = Encoding.UTF8.GetString(data, 0, bytes);
                responseData = responseData.ToUpper();
                recordMessage(responseData);
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            stream = chatClient.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
            stream.Write(data, 0, data.Length);
        }
    }
}
