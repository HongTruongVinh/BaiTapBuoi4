using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_BaiTapBuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_OpenCLient1.Enabled = false;
            btn_OpenServer1.Enabled = false;

            btn_OpenCLient2.Enabled = false;
            btn_OpenServer2.Enabled = false;
        }

        private void rdBtn_Bai1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                btn_OpenCLient1.Enabled = true;
                btn_OpenServer1.Enabled = true;
            }
            else
            {
                btn_OpenCLient1.Enabled = false;
                btn_OpenServer1.Enabled = false;
            }
        }

        private void rdBtn_Bai10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                btn_OpenCLient2.Enabled = true;
                btn_OpenServer2.Enabled = true;
            }
            else
            {
                btn_OpenCLient2.Enabled = false;
                btn_OpenServer2.Enabled = false;
            }
        }

        private void btn_OpenCLient1_Click(object sender, EventArgs e)
        {
            Bai01_CLient client = new Bai01_CLient();
            client.Show();

            (sender as Button).Enabled = false;
        }

        private void btn_OpenServer1_Click(object sender, EventArgs e)
        {
            Bai01_Server server = new Bai01_Server();
            server.Show();

            (sender as Button).Enabled = false;
        }

        private void btn_OpenCLient2_Click(object sender, EventArgs e)
        {
            Bai10_Client client = new Bai10_Client();
            client.Show();

            (sender as Button).Enabled = false;
        }
    }
}
