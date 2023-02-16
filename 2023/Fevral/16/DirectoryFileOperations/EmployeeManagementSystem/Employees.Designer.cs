namespace EmployeeManagementSystem
{
    partial class Employees
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeSurname = new System.Windows.Forms.TextBox();
            this.employeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.female = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.uploadImageBtn = new System.Windows.Forms.Button();
            this.uploadCvBtn = new System.Windows.Forms.Button();
            this.employeeJobDetails = new System.Windows.Forms.RichTextBox();
            this.addNewEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(6, 12);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(780, 380);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeJobDetails);
            this.groupBox1.Controls.Add(this.uploadCvBtn);
            this.groupBox1.Controls.Add(this.uploadImageBtn);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.employeeBirthDate);
            this.groupBox1.Controls.Add(this.employeeSurname);
            this.groupBox1.Controls.Add(this.employeeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(792, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Job Dtls";
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(94, 33);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(200, 20);
            this.employeeName.TabIndex = 3;
            // 
            // employeeSurname
            // 
            this.employeeSurname.Location = new System.Drawing.Point(94, 57);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(200, 20);
            this.employeeSurname.TabIndex = 3;
            // 
            // employeeBirthDate
            // 
            this.employeeBirthDate.Location = new System.Drawing.Point(94, 83);
            this.employeeBirthDate.Name = "employeeBirthDate";
            this.employeeBirthDate.Size = new System.Drawing.Size(200, 20);
            this.employeeBirthDate.TabIndex = 4;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(149, 109);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(60, 17);
            this.female.TabIndex = 5;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(94, 109);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 17);
            this.male.TabIndex = 5;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // uploadImageBtn
            // 
            this.uploadImageBtn.Location = new System.Drawing.Point(94, 133);
            this.uploadImageBtn.Name = "uploadImageBtn";
            this.uploadImageBtn.Size = new System.Drawing.Size(200, 29);
            this.uploadImageBtn.TabIndex = 6;
            this.uploadImageBtn.Text = "Upload Image";
            this.uploadImageBtn.UseVisualStyleBackColor = true;
            this.uploadImageBtn.Click += new System.EventHandler(this.uploadImageBtn_Click);
            // 
            // uploadCvBtn
            // 
            this.uploadCvBtn.Location = new System.Drawing.Point(94, 168);
            this.uploadCvBtn.Name = "uploadCvBtn";
            this.uploadCvBtn.Size = new System.Drawing.Size(200, 29);
            this.uploadCvBtn.TabIndex = 6;
            this.uploadCvBtn.Text = "Upload CV";
            this.uploadCvBtn.UseVisualStyleBackColor = true;
            this.uploadCvBtn.Click += new System.EventHandler(this.uploadCvBtn_Click);
            // 
            // employeeJobDetails
            // 
            this.employeeJobDetails.Location = new System.Drawing.Point(94, 203);
            this.employeeJobDetails.Name = "employeeJobDetails";
            this.employeeJobDetails.Size = new System.Drawing.Size(200, 131);
            this.employeeJobDetails.TabIndex = 7;
            this.employeeJobDetails.Text = "";
            // 
            // addNewEmployeeBtn
            // 
            this.addNewEmployeeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addNewEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewEmployeeBtn.Location = new System.Drawing.Point(792, 358);
            this.addNewEmployeeBtn.Name = "addNewEmployeeBtn";
            this.addNewEmployeeBtn.Size = new System.Drawing.Size(300, 34);
            this.addNewEmployeeBtn.TabIndex = 2;
            this.addNewEmployeeBtn.Text = "Add";
            this.addNewEmployeeBtn.UseVisualStyleBackColor = false;
            this.addNewEmployeeBtn.Click += new System.EventHandler(this.addNewEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.BackColor = System.Drawing.Color.Red;
            this.removeEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(12, 398);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(300, 34);
            this.removeEmployeeBtn.TabIndex = 3;
            this.removeEmployeeBtn.Text = "Delete Selected Employee";
            this.removeEmployeeBtn.UseVisualStyleBackColor = false;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 461);
            this.Controls.Add(this.removeEmployeeBtn);
            this.Controls.Add(this.addNewEmployeeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "Employees";
            this.Text = "Employee Control Panel";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.DateTimePicker employeeBirthDate;
        private System.Windows.Forms.TextBox employeeSurname;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox employeeJobDetails;
        private System.Windows.Forms.Button uploadCvBtn;
        private System.Windows.Forms.Button uploadImageBtn;
        private System.Windows.Forms.Button addNewEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
    }
}

