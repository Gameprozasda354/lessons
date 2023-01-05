namespace HomeworkWindowsForms
{
    partial class Chat1
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
            this.chat1Message = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chat1Message
            // 
            this.chat1Message.Location = new System.Drawing.Point(12, 12);
            this.chat1Message.MaxLength = 123;
            this.chat1Message.Multiline = true;
            this.chat1Message.Name = "chat1Message";
            this.chat1Message.Size = new System.Drawing.Size(497, 117);
            this.chat1Message.TabIndex = 0;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(386, 135);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(123, 47);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Chat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 193);
            this.Controls.Add(this.send);
            this.Controls.Add(this.chat1Message);
            this.Name = "Chat1";
            this.Text = "Chat1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chat1Message;
        private System.Windows.Forms.Button send;
    }
}