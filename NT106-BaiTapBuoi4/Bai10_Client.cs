using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NT106_BaiTapBuoi4
{
    public partial class Bai10_Client : Form
    {
        public Bai10_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
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
            TcpClient chatClient = new TcpClient();
            try
            {
                chatClient.ConnectAsync(severIP, port);
                // Send data
                byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                NetworkStream stream = chatClient.GetStream();
                stream.Write(data, 0, data.Length);
                // Receive data
                data = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.UTF8.GetString(data, 0, bytes);
                txtResults.Text += responseData;
                stream.Close();
                chatClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại!\n" + ex.ToString());
                return;
            }

        }
    }
}
