using EmployeeManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Employees : Form
    {
        public string LastUploadCv { get; set; }
        public string LastUploadImage { get; set; }

        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            employeesDataGridView.DataSource = VirtualDatabase.Employees;

            if (!Directory.Exists(GlobalSettings.WAITING_UPLOAD_PATH))
                Directory.CreateDirectory(GlobalSettings.WAITING_UPLOAD_PATH);
        }

        private void addNewEmployeeBtn_Click(object sender, EventArgs e)
        {
            Gender gender = Gender.Male; //Default olaraq Kişi seçilsin

            if (male.Checked)
                gender = Gender.Male;
            else if (female.Checked)
                gender = Gender.Female;

            Employee employee = new Employee(employeeName.Text, employeeSurname.Text, employeeBirthDate.Value, employeeJobDetails.Text, gender);
            VirtualDatabase.Employees.Add(employee);
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            var selectedEmployeeIndex = employeesDataGridView.SelectedRows[0].Index;
            var employee = VirtualDatabase.Employees[selectedEmployeeIndex];

            VirtualDatabase.Employees.Remove(employee);
        }
    }
}
