﻿
namespace NT106_BaiTapBuoi4
{
    partial class Form1
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
            this.btn_OpenCLient1 = new System.Windows.Forms.Button();
            this.btn_OpenServer1 = new System.Windows.Forms.Button();
            this.btn_OpenServer2 = new System.Windows.Forms.Button();
            this.btn_OpenCLient2 = new System.Windows.Forms.Button();
            this.rdBtn_Bai1 = new System.Windows.Forms.RadioButton();
            this.rdBtn_Bai10 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_OpenCLient1
            // 
            this.btn_OpenCLient1.Location = new System.Drawing.Point(198, 68);
            this.btn_OpenCLient1.Name = "btn_OpenCLient1";
            this.btn_OpenCLient1.Size = new System.Drawing.Size(101, 41);
            this.btn_OpenCLient1.TabIndex = 0;
            this.btn_OpenCLient1.Text = "Client";
            this.btn_OpenCLient1.UseVisualStyleBackColor = true;
            this.btn_OpenCLient1.Click += new System.EventHandler(this.btn_OpenCLient1_Click);
            // 
            // btn_OpenServer1
            // 
            this.btn_OpenServer1.Location = new System.Drawing.Point(413, 68);
            this.btn_OpenServer1.Name = "btn_OpenServer1";
            this.btn_OpenServer1.Size = new System.Drawing.Size(101, 41);
            this.btn_OpenServer1.TabIndex = 1;
            this.btn_OpenServer1.Text = "Server";
            this.btn_OpenServer1.UseVisualStyleBackColor = true;
            this.btn_OpenServer1.Click += new System.EventHandler(this.btn_OpenServer1_Click);
            // 
            // btn_OpenServer2
            // 
            this.btn_OpenServer2.Location = new System.Drawing.Point(413, 246);
            this.btn_OpenServer2.Name = "btn_OpenServer2";
            this.btn_OpenServer2.Size = new System.Drawing.Size(101, 41);
            this.btn_OpenServer2.TabIndex = 4;
            this.btn_OpenServer2.Text = "Server";
            this.btn_OpenServer2.UseVisualStyleBackColor = true;
            this.btn_OpenServer2.Click += new System.EventHandler(this.btn_OpenServer2_Click);
            // 
            // btn_OpenCLient2
            // 
            this.btn_OpenCLient2.Location = new System.Drawing.Point(198, 246);
            this.btn_OpenCLient2.Name = "btn_OpenCLient2";
            this.btn_OpenCLient2.Size = new System.Drawing.Size(101, 41);
            this.btn_OpenCLient2.TabIndex = 3;
            this.btn_OpenCLient2.Text = "Client";
            this.btn_OpenCLient2.UseVisualStyleBackColor = true;
            this.btn_OpenCLient2.Click += new System.EventHandler(this.btn_OpenCLient2_Click);
            // 
            // rdBtn_Bai1
            // 
            this.rdBtn_Bai1.AutoSize = true;
            this.rdBtn_Bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Bai1.Location = new System.Drawing.Point(80, 78);
            this.rdBtn_Bai1.Name = "rdBtn_Bai1";
            this.rdBtn_Bai1.Size = new System.Drawing.Size(78, 24);
            this.rdBtn_Bai1.TabIndex = 6;
            this.rdBtn_Bai1.TabStop = true;
            this.rdBtn_Bai1.Text = "Bai 01";
            this.rdBtn_Bai1.UseVisualStyleBackColor = true;
            this.rdBtn_Bai1.CheckedChanged += new System.EventHandler(this.rdBtn_Bai1_CheckedChanged);
            // 
            // rdBtn_Bai10
            // 
            this.rdBtn_Bai10.AutoSize = true;
            this.rdBtn_Bai10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Bai10.Location = new System.Drawing.Point(80, 253);
            this.rdBtn_Bai10.Name = "rdBtn_Bai10";
            this.rdBtn_Bai10.Size = new System.Drawing.Size(78, 24);
            this.rdBtn_Bai10.TabIndex = 7;
            this.rdBtn_Bai10.TabStop = true;
            this.rdBtn_Bai10.Text = "Bai 10";
            this.rdBtn_Bai10.UseVisualStyleBackColor = true;
            this.rdBtn_Bai10.CheckedChanged += new System.EventHandler(this.rdBtn_Bai10_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 362);
            this.Controls.Add(this.rdBtn_Bai10);
            this.Controls.Add(this.rdBtn_Bai1);
            this.Controls.Add(this.btn_OpenServer2);
            this.Controls.Add(this.btn_OpenCLient2);
            this.Controls.Add(this.btn_OpenServer1);
            this.Controls.Add(this.btn_OpenCLient1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenCLient1;
        private System.Windows.Forms.Button btn_OpenServer1;
        private System.Windows.Forms.Button btn_OpenServer2;
        private System.Windows.Forms.Button btn_OpenCLient2;
        private System.Windows.Forms.RadioButton rdBtn_Bai1;
        private System.Windows.Forms.RadioButton rdBtn_Bai10;
    }
}

