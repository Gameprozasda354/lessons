namespace HomeworkWindowsForms
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
            this.user1 = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Location = new System.Drawing.Point(98, 50);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(0, 13);
            this.user1.TabIndex = 0;
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Location = new System.Drawing.Point(542, 62);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(0, 13);
            this.user2.TabIndex = 1;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(30, 26);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 13);
            this.user.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.user1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.Label user;
    }
}

