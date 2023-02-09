namespace Homework
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLstBox = new System.Windows.Forms.ListBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.surNameTxtBox = new System.Windows.Forms.TextBox();
            this.maleOrFemaleTxtBox = new System.Windows.Forms.TextBox();
            this.countryTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adressTxtBox = new System.Windows.Forms.TextBox();
            this.numberTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // userLstBox
            // 
            this.userLstBox.FormattingEnabled = true;
            this.userLstBox.Location = new System.Drawing.Point(12, 12);
            this.userLstBox.Name = "userLstBox";
            this.userLstBox.Size = new System.Drawing.Size(323, 433);
            this.userLstBox.TabIndex = 3;
            this.userLstBox.SelectedIndexChanged += new System.EventHandler(this.WriteUserInformations);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(432, 41);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(163, 20);
            this.nameTxtBox.TabIndex = 4;
            // 
            // surNameTxtBox
            // 
            this.surNameTxtBox.Location = new System.Drawing.Point(432, 65);
            this.surNameTxtBox.Name = "surNameTxtBox";
            this.surNameTxtBox.Size = new System.Drawing.Size(163, 20);
            this.surNameTxtBox.TabIndex = 5;
            // 
            // maleOrFemaleTxtBox
            // 
            this.maleOrFemaleTxtBox.Location = new System.Drawing.Point(432, 93);
            this.maleOrFemaleTxtBox.Name = "maleOrFemaleTxtBox";
            this.maleOrFemaleTxtBox.Size = new System.Drawing.Size(163, 20);
            this.maleOrFemaleTxtBox.TabIndex = 6;
            // 
            // countryTxtBox
            // 
            this.countryTxtBox.Location = new System.Drawing.Point(432, 119);
            this.countryTxtBox.Name = "countryTxtBox";
            this.countryTxtBox.Size = new System.Drawing.Size(163, 20);
            this.countryTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cinsiyyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Olke:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seher:";
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.Location = new System.Drawing.Point(432, 145);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(163, 20);
            this.cityTxtBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unvan:";
            // 
            // adressTxtBox
            // 
            this.adressTxtBox.Location = new System.Drawing.Point(432, 171);
            this.adressTxtBox.Name = "adressTxtBox";
            this.adressTxtBox.Size = new System.Drawing.Size(163, 20);
            this.adressTxtBox.TabIndex = 13;
            // 
            // numberTxtBox
            // 
            this.numberTxtBox.Location = new System.Drawing.Point(432, 197);
            this.numberTxtBox.Name = "numberTxtBox";
            this.numberTxtBox.Size = new System.Drawing.Size(163, 20);
            this.numberTxtBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefon:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(432, 223);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(163, 20);
            this.emailTxtBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(345, 272);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 55);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Yadda saxla.";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.UpdateElement);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(473, 272);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(122, 55);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete.";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteElement);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(677, 389);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 49);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Əlavə Et";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberTxtBox);
            this.Controls.Add(this.adressTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countryTxtBox);
            this.Controls.Add(this.maleOrFemaleTxtBox);
            this.Controls.Add(this.surNameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.userLstBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userLstBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox surNameTxtBox;
        private System.Windows.Forms.TextBox maleOrFemaleTxtBox;
        private System.Windows.Forms.TextBox countryTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adressTxtBox;
        private System.Windows.Forms.TextBox numberTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addButton;
    }
}

