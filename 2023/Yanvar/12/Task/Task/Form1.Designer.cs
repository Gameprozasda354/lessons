namespace Task
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
            this.panel = new System.Windows.Forms.GroupBox();
            this.listOfItems = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.scaleName = new System.Windows.Forms.GroupBox();
            this.elements = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            this.scaleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.add);
            this.panel.Controls.Add(this.itemName);
            this.panel.Controls.Add(this.delete);
            this.panel.Controls.Add(this.listOfItems);
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(321, 229);
            this.panel.TabIndex = 5;
            this.panel.TabStop = false;
            this.panel.Text = "Panel";
            // 
            // listOfItems
            // 
            this.listOfItems.Location = new System.Drawing.Point(6, 162);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.Size = new System.Drawing.Size(194, 21);
            this.listOfItems.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(226, 159);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.DeleteElement);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(9, 43);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(191, 20);
            this.itemName.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(226, 39);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // scaleName
            // 
            this.scaleName.Controls.Add(this.elements);
            this.scaleName.Location = new System.Drawing.Point(340, 13);
            this.scaleName.Name = "scaleName";
            this.scaleName.Size = new System.Drawing.Size(1054, 606);
            this.scaleName.TabIndex = 6;
            this.scaleName.TabStop = false;
            this.scaleName.Text = "Elements";
            // 
            // elements
            // 
            this.elements.Location = new System.Drawing.Point(6, 19);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(1041, 577);
            this.elements.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 621);
            this.Controls.Add(this.scaleName);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.scaleName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox listOfItems;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.GroupBox scaleName;
        private System.Windows.Forms.FlowLayoutPanel elements;
    }
}

