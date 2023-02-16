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

            var imgPath = GlobalSettings.IMAGE_PATH + employee.Name + " " + employee.Surname + " " + employee.DateOfBirth.ToString("dd.MM.yyyy") + " Photo.jpg";
            var cvPath = GlobalSettings.CV_PATH + employee.Name + " " + employee.Surname + " " + employee.DateOfBirth.ToString("dd.MM.yyyy") + " Cv.pdf";

            if (!Directory.Exists(GlobalSettings.IMAGE_PATH))
                Directory.CreateDirectory(GlobalSettings.IMAGE_PATH);

            if (!Directory.Exists(GlobalSettings.CV_PATH))
                Directory.CreateDirectory(GlobalSettings.CV_PATH);

            File.Move(LastUploadImage, imgPath);
            File.Move(LastUploadCv, cvPath);

            LastUploadImage = string.Empty;
            LastUploadCv = string.Empty;

            uploadImageBtn.Enabled = true;
            uploadCvBtn.Enabled = true;
            employeeName.Text = string.Empty;
            employeeSurname.Text = string.Empty;
            employeeJobDetails.Text = string.Empty;

            employee.ImagePath = imgPath;
            employee.CvPath = cvPath;
            Log(employee, true);
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            var selectedEmployeeIndex = employeesDataGridView.SelectedRows[0].Index;
            var employee = VirtualDatabase.Employees[selectedEmployeeIndex];

            Log(employee, false);

            File.Delete(employee.ImagePath);
            File.Delete(employee.CvPath);

            VirtualDatabase.Employees.Remove(employee);
        }

        #region Task in Lesson 1
        /*
            1. Əlavə olunan və silinən işçinin məlumatları aşağıdakı kimi log faylına yazılacaq:

            ------------- Added at 2023-02-16 16:40:10.155 -------------
            Id: 1
            Name: Orkhan
            Surname: Farajov
            Date of Birth: 24.12.1995
            Gender: Male
            JobDetails: ...
            Created By User: Some User
            ------------- END -------------

            ------------- Removed at 2023-02-16 16:40:10.155 -------------
            Id: 1
            Name: Orkhan
            Surname: Farajov
            Date of Birth: 24.12.1995
            Gender: Male
            JobDetails: ...
            Created By User: Some User
            ------------- END -------------

            2. Hər günün öz fayl adı belə olacaq: 2023-02-16_LOG.txt

            3. Fayllar C:/Logs folder'ində olacaq.

            Nümunə: C:/Logs/2023-02-16_LOG.txt
         */
        #endregion

        private void Log(Employee emp, bool isAdded)
        {
            FileStream fileStream = null;
            var filename = DateTime.Now.ToString("yyyy-MM-dd") + "_LOG.txt";

            if (!Directory.Exists(GlobalSettings.LOGS_PATH))
                Directory.CreateDirectory(GlobalSettings.LOGS_PATH);

            if (!File.Exists(GlobalSettings.LOGS_PATH + filename))
                fileStream = File.Create(GlobalSettings.LOGS_PATH + filename);

            if (fileStream != null)
                fileStream.Close();

            List<string> logDetails = new List<string>
            {
                $"------------------------------------- {(isAdded ? "Added" : "Removed")} at {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ms")}",
                $"Name: {emp.Name}",
                $"Surname: {emp.Surname}",
                $"Date of Birth: {emp.DateOfBirth}",
                $"Gender: {emp.Gender.ToString()}",
                $"JobDetails: {emp.JobDetails}",
                "Created By User: Some User",
                "------------------------------------- END",
                ""
            };

            File.AppendAllLines(GlobalSettings.LOGS_PATH + filename, logDetails);
        }
        //Əlavə etmə: Log(employee, true);
        //Silmə: Log(employee, false);

        private void uploadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg"; //hansi fayl tiplerine icaze verilsin?
            dialog.Multiselect = false; //birden cox fayl secmek true/false

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string safeFileName = dialog.SafeFileName;

                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    if((reader.BaseStream.Length/1024) > 500) //kb deyerini almaq ucun 1024'e boluruk
                        MessageBox.Show("Max image size limit is 500 KB!", "Image size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        var newFileName = GlobalSettings.WAITING_UPLOAD_PATH + DateTime.Now.Ticks + ".jpg";
                        LastUploadImage = newFileName;
                        reader.Close();
                        File.Copy(path, newFileName);
                        uploadImageBtn.Enabled = false;
                    }
                }
            }
        }

        private void uploadCvBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF files | *.pdf"; //hansi fayl tiplerine icaze verilsin?
            dialog.Multiselect = false; //birden cox fayl secmek true/false

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string safeFileName = dialog.SafeFileName;

                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    if ((reader.BaseStream.Length / 1024) > 2000) //kb deyerini almaq ucun 1024'e boluruk
                        MessageBox.Show("Max PDF file size limit is 2 MB!", "PDF file size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        var newFileName = GlobalSettings.WAITING_UPLOAD_PATH + DateTime.Now.Ticks + ".pdf";
                        LastUploadCv = newFileName;
                        reader.Close();
                        File.Copy(path, newFileName);
                        uploadCvBtn.Enabled = false;
                    }
                }
            }
        }
    }
}
