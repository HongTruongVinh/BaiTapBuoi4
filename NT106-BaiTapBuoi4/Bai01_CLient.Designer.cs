
namespace NT106_BaiTapBuoi4
{
    partial class Bai01_CLient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_IPRemoteHost = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.btn_Sent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote Host";
            // 
            // tb_IPRemoteHost
            // 
            this.tb_IPRemoteHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IPRemoteHost.Location = new System.Drawing.Point(31, 70);
            this.tb_IPRemoteHost.Name = "tb_IPRemoteHost";
            this.tb_IPRemoteHost.Size = new System.Drawing.Size(193, 27);
            this.tb_IPRemoteHost.TabIndex = 1;
            this.tb_IPRemoteHost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IPRemoteHost_KeyPress);
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Port.Location = new System.Drawing.Point(453, 70);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(193, 27);
            this.tb_Port.TabIndex = 3;
            this.tb_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // rtb_Message
            // 
            this.rtb_Message.Location = new System.Drawing.Point(31, 164);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(615, 241);
            this.rtb_Message.TabIndex = 4;
            this.rtb_Message.Text = "";
            // 
            // btn_Sent
            // 
            this.btn_Sent.Location = new System.Drawing.Point(31, 422);
            this.btn_Sent.Name = "btn_Sent";
            this.btn_Sent.Size = new System.Drawing.Size(84, 27);
            this.btn_Sent.TabIndex = 5;
            this.btn_Sent.Text = "Send";
            this.btn_Sent.UseVisualStyleBackColor = true;
            this.btn_Sent.Click += new System.EventHandler(this.btn_Sent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // Bai01_CLient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sent);
            this.Controls.Add(this.rtb_Message);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_IPRemoteHost);
            this.Controls.Add(this.label1);
            this.Name = "Bai01_CLient";
            this.Text = "Bai01_CLient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IPRemoteHost;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.Button btn_Sent;
        private System.Windows.Forms.Label label3;
    }
}