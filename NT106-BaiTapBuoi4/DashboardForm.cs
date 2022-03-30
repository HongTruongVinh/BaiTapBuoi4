using System;
using System.Windows.Forms;

namespace NT106_BaiTapBuoi4
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
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

        private void btn_OpenServer2_Click(object sender, EventArgs e)
        {
            Bai10_Sever sever = new Bai10_Sever();
            sever.Show();

            (sender as Button).Enabled = false;
        }

        private void danhSáchThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danh Sách Thành Viên\r\n\r\n" +
                "1 Bùi Hải Đăng\t\t20521156\r\n" +
                "2 Trần Kiến Quốc\t\t20520293\r\n" +
                "3 Hồng Trường Vinh\t20522157\r\n" +
                "4 Lý Quốc Kiệt\t\t20521496\r\n" +
                "5 Vũ Thành Đạt\t\t20521181\r\n");
        }
    }
}
