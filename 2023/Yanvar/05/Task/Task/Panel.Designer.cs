namespace Task
{
    partial class Panel
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
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.datasComboBox = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(12, 12);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(238, 20);
            this.typeTxtBox.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(256, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // datasComboBox
            // 
            this.datasComboBox.FormattingEnabled = true;
            this.datasComboBox.Location = new System.Drawing.Point(13, 61);
            this.datasComboBox.Name = "datasComboBox";
            this.datasComboBox.Size = new System.Drawing.Size(237, 21);
            this.datasComboBox.TabIndex = 2;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(256, 59);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.datasComboBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.typeTxtBox);
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox datasComboBox;
        private System.Windows.Forms.Button delete;
    }
}

