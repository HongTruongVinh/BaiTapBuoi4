using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace NT106_BaiTapBuoi4
{
    public partial class Bai01_CLient : Form
    {
        public Bai01_CLient()
        {
            InitializeComponent();

            tb_IPRemoteHost.Text = "127.0.0.1";
            tb_Port.Text = "8001";
        }

        private void btn_Sent_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();

                byte[] sendBytes = Encoding.UTF8.GetBytes(rtb_Message.Text);
                udpClient.Send(sendBytes, sendBytes.Length, tb_IPRemoteHost.Text, Int32.Parse(tb_Port.Text));

                udpClient.Close();
                rtb_Message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_IPRemoteHost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
