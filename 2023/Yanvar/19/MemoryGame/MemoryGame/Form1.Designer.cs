namespace MemoryGame
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
            this.recordLbl = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.labelRekord = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rekord:";
            // 
            // recordLbl
            // 
            this.recordLbl.AutoSize = true;
            this.recordLbl.Location = new System.Drawing.Point(51, 18);
            this.recordLbl.Name = "recordLbl";
            this.recordLbl.Size = new System.Drawing.Size(0, 13);
            this.recordLbl.TabIndex = 2;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(591, 55);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(132, 55);
            this.restart.TabIndex = 3;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // labelRekord
            // 
            this.labelRekord.AutoSize = true;
            this.labelRekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRekord.Location = new System.Drawing.Point(654, 13);
            this.labelRekord.Name = "labelRekord";
            this.labelRekord.Size = new System.Drawing.Size(15, 20);
            this.labelRekord.TabIndex = 4;
            this.labelRekord.Text = "-";
            // 
            // buttons
            // 
            this.buttons.Location = new System.Drawing.Point(12, 9);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(569, 429);
            this.buttons.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.labelRekord);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.recordLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recordLbl;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label labelRekord;
        private System.Windows.Forms.FlowLayoutPanel buttons;
    }
}

