namespace WindowsFormsAppPart3
{
    partial class MessageBoxExamples
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
            this.standartMessageBoxBtn = new System.Windows.Forms.Button();
            this.questionWithCancelMessageBoxBtn = new System.Windows.Forms.Button();
            this.exitProgramBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standartMessageBoxBtn
            // 
            this.standartMessageBoxBtn.Location = new System.Drawing.Point(12, 12);
            this.standartMessageBoxBtn.Name = "standartMessageBoxBtn";
            this.standartMessageBoxBtn.Size = new System.Drawing.Size(171, 64);
            this.standartMessageBoxBtn.TabIndex = 0;
            this.standartMessageBoxBtn.Text = "Standart MessageBox";
            this.standartMessageBoxBtn.UseVisualStyleBackColor = true;
            this.standartMessageBoxBtn.Click += new System.EventHandler(this.standartMessageBoxBtn_Click);
            // 
            // questionWithCancelMessageBoxBtn
            // 
            this.questionWithCancelMessageBoxBtn.Location = new System.Drawing.Point(189, 12);
            this.questionWithCancelMessageBoxBtn.Name = "questionWithCancelMessageBoxBtn";
            this.questionWithCancelMessageBoxBtn.Size = new System.Drawing.Size(169, 64);
            this.questionWithCancelMessageBoxBtn.TabIndex = 1;
            this.questionWithCancelMessageBoxBtn.Text = "Hə / Yox / İmtina";
            this.questionWithCancelMessageBoxBtn.UseVisualStyleBackColor = true;
            this.questionWithCancelMessageBoxBtn.Click += new System.EventHandler(this.questionWithCancelMessageBoxBtn_Click);
            // 
            // exitProgramBtn
            // 
            this.exitProgramBtn.Location = new System.Drawing.Point(661, 387);
            this.exitProgramBtn.Name = "exitProgramBtn";
            this.exitProgramBtn.Size = new System.Drawing.Size(127, 51);
            this.exitProgramBtn.TabIndex = 2;
            this.exitProgramBtn.Text = "Exit Program";
            this.exitProgramBtn.UseVisualStyleBackColor = true;
            this.exitProgramBtn.Click += new System.EventHandler(this.exitProgramBtn_Click);
            // 
            // MessageBoxExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitProgramBtn);
            this.Controls.Add(this.questionWithCancelMessageBoxBtn);
            this.Controls.Add(this.standartMessageBoxBtn);
            this.Name = "MessageBoxExamples";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button standartMessageBoxBtn;
        private System.Windows.Forms.Button questionWithCancelMessageBoxBtn;
        private System.Windows.Forms.Button exitProgramBtn;
    }
}

