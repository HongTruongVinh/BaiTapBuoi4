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

namespace NT106_BaiTapBuoi4
{
    public partial class Bai01_Server : Form
    {
        Thread udpServer;
        bool _exit;
        private delegate void SafeCallDelegate(string text);

        public Bai01_Server()
        {
            InitializeComponent();

            _exit = false;

            lv_Message.View = View.Details;

            lv_Message.Columns.Add("Content");

            tb_HostPort.Text = "1800";
        }

        public void serverThread()
        {
            int hostPort = 0;

            Int32.TryParse(tb_HostPort.Text, out hostPort);

            UdpClient udpClient = new UdpClient(hostPort);

            while (!_exit)
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);

                byte[] receiveByte = udpClient.Receive(ref remoteIPEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveByte);
                string message = remoteIPEndPoint.Address.ToString() + ": " + returnData.ToString();

                UpdateReceiveMessage(message);
            }
        }

        public void UpdateReceiveMessage(string data)
        {
            try
            {
                if (lv_Message.InvokeRequired)
                {
                    var delgate = new SafeCallDelegate(UpdateReceiveMessage);
                    lv_Message.Invoke(delgate, new object[] { data });
                }
                else
                {
                    ListViewItem item = new ListViewItem(data);
                    lv_Message.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if(tb_HostPort.Text == "")
            {
                MessageBox.Show("Please enter your Host Port");
                return;
            }

            try
            {
                int checkServerPort = Int32.Parse(tb_HostPort.Text);

                if (checkServerPort < 1024 || checkServerPort > 49151)
                {
                    MessageBox.Show("The port cannot be less than 1024 or greater than 49151");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            udpServer = new Thread(new ThreadStart(serverThread));
            udpServer.Start();
            MessageBox.Show("Listening on port: " + tb_HostPort.Text.ToString());

            btn_Listen.Text = "Listening ...";
            btn_Listen.Enabled = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _exit = true;
            udpServer = null;
            Environment.Exit(0);
        }

        private void tb_HostPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
