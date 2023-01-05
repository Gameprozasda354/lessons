namespace HomeworkWindowsForms
{
    partial class Chat2
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
            this.send2 = new System.Windows.Forms.Button();
            this.chat2Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send2
            // 
            this.send2.Location = new System.Drawing.Point(394, 135);
            this.send2.Name = "send2";
            this.send2.Size = new System.Drawing.Size(115, 46);
            this.send2.TabIndex = 0;
            this.send2.Text = "Send";
            this.send2.UseVisualStyleBackColor = true;
            this.send2.Click += new System.EventHandler(this.send2_Click);
            // 
            // chat2Message
            // 
            this.chat2Message.Location = new System.Drawing.Point(12, 12);
            this.chat2Message.MaxLength = 123;
            this.chat2Message.Multiline = true;
            this.chat2Message.Name = "chat2Message";
            this.chat2Message.Size = new System.Drawing.Size(497, 117);
            this.chat2Message.TabIndex = 1;
            // 
            // Chat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 193);
            this.Controls.Add(this.chat2Message);
            this.Controls.Add(this.send2);
            this.Name = "Chat2";
            this.Text = "Chat2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send2;
        private System.Windows.Forms.TextBox chat2Message;
    }
}