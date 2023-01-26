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
            this.label2 = new System.Windows.Forms.Label();
            this.clickRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(587, 9);
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
            this.restart.Location = new System.Drawing.Point(591, 90);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(213, 55);
            this.restart.TabIndex = 3;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // labelRekord
            // 
            this.labelRekord.AutoSize = true;
            this.labelRekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRekord.Location = new System.Drawing.Point(665, 9);
            this.labelRekord.Name = "labelRekord";
            this.labelRekord.Size = new System.Drawing.Size(0, 20);
            this.labelRekord.TabIndex = 4;
            // 
            // buttons
            // 
            this.buttons.Location = new System.Drawing.Point(12, 9);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(569, 429);
            this.buttons.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(587, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clicked:";
            // 
            // clickRecord
            // 
            this.clickRecord.AutoSize = true;
            this.clickRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickRecord.ForeColor = System.Drawing.Color.ForestGreen;
            this.clickRecord.Location = new System.Drawing.Point(665, 33);
            this.clickRecord.Name = "clickRecord";
            this.clickRecord.Size = new System.Drawing.Size(15, 20);
            this.clickRecord.TabIndex = 6;
            this.clickRecord.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(587, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time:";
            // 
            // timeRecord
            // 
            this.timeRecord.AutoSize = true;
            this.timeRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRecord.ForeColor = System.Drawing.Color.ForestGreen;
            this.timeRecord.Location = new System.Drawing.Point(665, 57);
            this.timeRecord.Name = "timeRecord";
            this.timeRecord.Size = new System.Drawing.Size(15, 20);
            this.timeRecord.TabIndex = 8;
            this.timeRecord.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(591, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Game Info:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(591, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Click:";
            // 
            // click
            // 
            this.click.AutoSize = true;
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click.ForeColor = System.Drawing.SystemColors.Highlight;
            this.click.Location = new System.Drawing.Point(644, 172);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(19, 20);
            this.click.TabIndex = 11;
            this.click.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(591, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Time:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.Highlight;
            this.time.Location = new System.Drawing.Point(644, 192);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(54, 20);
            this.time.TabIndex = 13;
            this.time.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 453);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.click);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clickRecord);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clickRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label click;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label time;
    }
}

