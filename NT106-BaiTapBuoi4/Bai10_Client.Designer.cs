namespace NT106_BaiTapBuoi4
{
    partial class Bai10_Client
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
            this.txtSeverIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblSeverIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lb_Messages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeverIP
            // 
            this.txtSeverIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeverIP.Location = new System.Drawing.Point(133, 42);
            this.txtSeverIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSeverIP.Name = "txtSeverIP";
            this.txtSeverIP.Size = new System.Drawing.Size(162, 27);
            this.txtSeverIP.TabIndex = 0;
            this.txtSeverIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(392, 43);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(162, 27);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8888";
            // 
            // lblSeverIP
            // 
            this.lblSeverIP.AutoSize = true;
            this.lblSeverIP.Location = new System.Drawing.Point(64, 45);
            this.lblSeverIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeverIP.Name = "lblSeverIP";
            this.lblSeverIP.Size = new System.Drawing.Size(61, 20);
            this.lblSeverIP.TabIndex = 2;
            this.lblSeverIP.Text = "Sever IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(349, 45);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 20);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // txtResults
            // 
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResults.Location = new System.Drawing.Point(68, 155);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(567, 243);
            this.txtResults.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(68, 87);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(486, 27);
            this.txtMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(562, 87);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 27);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(562, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 27);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lb_Messages
            // 
            this.lb_Messages.AutoSize = true;
            this.lb_Messages.Location = new System.Drawing.Point(64, 132);
            this.lb_Messages.Name = "lb_Messages";
            this.lb_Messages.Size = new System.Drawing.Size(118, 20);
            this.lb_Messages.TabIndex = 8;
            this.lb_Messages.Text = "Lịch sử giao tiếp";
            // 
            // Bai10_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 439);
            this.Controls.Add(this.lb_Messages);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblSeverIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtSeverIP);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai10_Client";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeverIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblSeverIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lb_Messages;
    }
}