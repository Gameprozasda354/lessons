﻿namespace WindowsFormsAppPart3
{
    partial class CustomerApp
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.surnameTxtBx = new System.Windows.Forms.TextBox();
            this.fatherNameTxtBx = new System.Windows.Forms.TextBox();
            this.emailTxtBx = new System.Windows.Forms.TextBox();
            this.phoneNumberTxtBx = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerList = new System.Windows.Forms.ListBox();
            this.winNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addCustomerBtn);
            this.groupBox1.Controls.Add(this.phoneNumberTxtBx);
            this.groupBox1.Controls.Add(this.emailTxtBx);
            this.groupBox1.Controls.Add(this.fatherNameTxtBx);
            this.groupBox1.Controls.Add(this.surnameTxtBx);
            this.groupBox1.Controls.Add(this.nameTxtBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni müştəri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ata adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon nömrəsi";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(122, 32);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(193, 20);
            this.nameTxtBx.TabIndex = 1;
            // 
            // surnameTxtBx
            // 
            this.surnameTxtBx.Location = new System.Drawing.Point(122, 58);
            this.surnameTxtBx.Name = "surnameTxtBx";
            this.surnameTxtBx.Size = new System.Drawing.Size(193, 20);
            this.surnameTxtBx.TabIndex = 2;
            // 
            // fatherNameTxtBx
            // 
            this.fatherNameTxtBx.Location = new System.Drawing.Point(122, 84);
            this.fatherNameTxtBx.Name = "fatherNameTxtBx";
            this.fatherNameTxtBx.Size = new System.Drawing.Size(193, 20);
            this.fatherNameTxtBx.TabIndex = 3;
            // 
            // emailTxtBx
            // 
            this.emailTxtBx.Location = new System.Drawing.Point(122, 110);
            this.emailTxtBx.Name = "emailTxtBx";
            this.emailTxtBx.Size = new System.Drawing.Size(193, 20);
            this.emailTxtBx.TabIndex = 4;
            // 
            // phoneNumberTxtBx
            // 
            this.phoneNumberTxtBx.Location = new System.Drawing.Point(122, 136);
            this.phoneNumberTxtBx.Name = "phoneNumberTxtBx";
            this.phoneNumberTxtBx.Size = new System.Drawing.Size(193, 20);
            this.phoneNumberTxtBx.TabIndex = 5;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(207, 162);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(108, 36);
            this.addCustomerBtn.TabIndex = 6;
            this.addCustomerBtn.Text = "Əlavə et";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerList);
            this.groupBox2.Location = new System.Drawing.Point(403, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 583);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müştəri Siyahısı";
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(6, 19);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(807, 550);
            this.customerList.TabIndex = 0;
            // 
            // winNotification
            // 
            this.winNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.winNotification.Visible = true;
            // 
            // CustomerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri idarə etmə formu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox phoneNumberTxtBx;
        private System.Windows.Forms.TextBox emailTxtBx;
        private System.Windows.Forms.TextBox fatherNameTxtBx;
        private System.Windows.Forms.TextBox surnameTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.NotifyIcon winNotification;
    }
}