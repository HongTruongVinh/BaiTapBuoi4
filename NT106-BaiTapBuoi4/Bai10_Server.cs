using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_BaiTapBuoi4
{
    public partial class Bai10_Server : Form
    {
        public Bai10_Server()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (txtHostPort.Text == "")
            {
                MessageBox.Show("Please enter your Host Port");
                return;
            }

            try
            {
                var server = new SimpleTcpServer().Start(int.Parse(txtHostPort.Text));
                server.Delimiter = 0x13;
                server.DelimiterDataReceived += DelimiterDataReceivedEvent;
                richTextBoxMsg.Text = "Đã lắng nghe thành công port " + txtHostPort.Text;
                btnListen.Text = "Listening ...";
                btnListen.Enabled = false;
                MessageBox.Show("Listening on port: " + txtHostPort.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void DelimiterDataReceivedEvent(object sender, SimpleTCP.Message e)
        {
            richTextBoxMsg.Invoke(new Action(() =>
            {
                richTextBoxMsg.Text = richTextBoxMsg.Text + Environment.NewLine + e.MessageString;
            }));
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtHostPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
