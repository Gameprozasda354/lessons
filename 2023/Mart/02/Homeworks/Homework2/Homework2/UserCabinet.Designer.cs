namespace Homework2
{
    partial class UserCabinet
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
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.AcceptsReturn = true;
            this.userNameTxtBox.HideSelection = false;
            this.userNameTxtBox.Location = new System.Drawing.Point(402, 161);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.ReadOnly = true;
            this.userNameTxtBox.Size = new System.Drawing.Size(144, 20);
            this.userNameTxtBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(706, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.AcceptsReturn = true;
            this.passwordTxtBox.HideSelection = false;
            this.passwordTxtBox.Location = new System.Drawing.Point(402, 198);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.ReadOnly = true;
            this.passwordTxtBox.Size = new System.Drawing.Size(144, 20);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // UserCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserCabinet";
            this.Text = "UserCabinet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTxtBox;
    }
}