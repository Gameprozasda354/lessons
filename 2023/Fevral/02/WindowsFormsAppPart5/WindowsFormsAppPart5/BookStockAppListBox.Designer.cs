﻿namespace WindowsFormsAppPart5
{
    partial class BookStockAppListBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookDescription = new System.Windows.Forms.RichTextBox();
            this.bookAuthorText = new System.Windows.Forms.TextBox();
            this.bookCountText = new System.Windows.Forms.TextBox();
            this.bookCategoryText = new System.Windows.Forms.TextBox();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookDescription);
            this.groupBox1.Controls.Add(this.bookAuthorText);
            this.groupBox1.Controls.Add(this.bookCountText);
            this.groupBox1.Controls.Add(this.bookCategoryText);
            this.groupBox1.Controls.Add(this.bookNameText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bookPicture);
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 422);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilən kitab haqqında məlumat";
            // 
            // bookDescription
            // 
            this.bookDescription.Location = new System.Drawing.Point(6, 225);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(692, 191);
            this.bookDescription.TabIndex = 3;
            this.bookDescription.Text = "";
            // 
            // bookAuthorText
            // 
            this.bookAuthorText.Location = new System.Drawing.Point(253, 144);
            this.bookAuthorText.Name = "bookAuthorText";
            this.bookAuthorText.Size = new System.Drawing.Size(223, 20);
            this.bookAuthorText.TabIndex = 2;
            // 
            // bookCountText
            // 
            this.bookCountText.Location = new System.Drawing.Point(253, 118);
            this.bookCountText.Name = "bookCountText";
            this.bookCountText.Size = new System.Drawing.Size(223, 20);
            this.bookCountText.TabIndex = 2;
            // 
            // bookCategoryText
            // 
            this.bookCategoryText.Location = new System.Drawing.Point(254, 92);
            this.bookCategoryText.Name = "bookCategoryText";
            this.bookCategoryText.Size = new System.Drawing.Size(222, 20);
            this.bookCategoryText.TabIndex = 2;
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(254, 66);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(222, 20);
            this.bookNameText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müəllif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok ədəd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kateqoriya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitab adı";
            // 
            // bookPicture
            // 
            this.bookPicture.Location = new System.Drawing.Point(6, 19);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(162, 200);
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(12, 12);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBooks.Size = new System.Drawing.Size(324, 511);
            this.lstBooks.TabIndex = 4;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // BookStockAppListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 539);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookStockAppListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitab Stok Proqramı";
            this.Load += new System.EventHandler(this.BookStockAppListBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox bookDescription;
        private System.Windows.Forms.TextBox bookAuthorText;
        private System.Windows.Forms.TextBox bookCountText;
        private System.Windows.Forms.TextBox bookCategoryText;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.ListBox lstBooks;
    }
}