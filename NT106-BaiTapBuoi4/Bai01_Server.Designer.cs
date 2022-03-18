
namespace NT106_BaiTapBuoi4
{
    partial class Bai01_Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_HostPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_Message = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tb_HostPort
            // 
            this.tb_HostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HostPort.Location = new System.Drawing.Point(37, 59);
            this.tb_HostPort.Name = "tb_HostPort";
            this.tb_HostPort.Size = new System.Drawing.Size(193, 27);
            this.tb_HostPort.TabIndex = 5;
            this.tb_HostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_HostPort_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(387, 59);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(141, 27);
            this.btn_Listen.TabIndex = 6;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(568, 60);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(84, 27);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Received Messages";
            // 
            // lv_Message
            // 
            this.lv_Message.HideSelection = false;
            this.lv_Message.Location = new System.Drawing.Point(37, 147);
            this.lv_Message.Name = "lv_Message";
            this.lv_Message.Size = new System.Drawing.Size(615, 291);
            this.lv_Message.TabIndex = 10;
            this.lv_Message.UseCompatibleStateImageBehavior = false;
            // 
            // Bai01_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.lv_Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.tb_HostPort);
            this.Controls.Add(this.label2);
            this.Name = "Bai01_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai01_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_HostPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_Message;
    }
}