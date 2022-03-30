
namespace NT106_BaiTapBuoi4
{
    partial class Bai10_Server
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
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxMsg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtHostPort
            // 
            this.txtHostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostPort.Location = new System.Drawing.Point(53, 9);
            this.txtHostPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(146, 23);
            this.txtHostPort.TabIndex = 5;
            this.txtHostPort.Text = "8888";
            this.txtHostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHostPort_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // btn_Listen
            // 
            this.btnListen.Location = new System.Drawing.Point(290, 9);
            this.btnListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnListen.Name = "btn_Listen";
            this.btnListen.Size = new System.Drawing.Size(106, 22);
            this.btnListen.TabIndex = 6;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(402, 9);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(106, 22);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Received Messages";
            // 
            // richTextBoxMsg
            // 
            this.richTextBoxMsg.Location = new System.Drawing.Point(14, 67);
            this.richTextBoxMsg.Name = "richTextBoxMsg";
            this.richTextBoxMsg.Size = new System.Drawing.Size(494, 287);
            this.richTextBoxMsg.TabIndex = 10;
            this.richTextBoxMsg.Text = "";
            // 
            // Bai01_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 366);
            this.Controls.Add(this.richTextBoxMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtHostPort);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai01_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai01_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHostPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxMsg;
    }
}