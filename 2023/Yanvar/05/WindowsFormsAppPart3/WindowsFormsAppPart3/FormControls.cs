using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
        }

        private void ShowCustomers(object sender, EventArgs e)
        {
            View view = new View();
            view.ShowDialog();
        }

        private void AddCustomerBtn(object sender, EventArgs e)
        {
            Customer2 customer = new Customer2(){
                Id = Guid.NewGuid(),
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Email = emailTextBox.Text,
                FatherName = fatherNameTextBox.Text,
                PhoneNumber = phoneTextBox.Text,
                City = cityDropDwn.SelectedItem.ToString()
            };
            int count = AddCustomer(customer);

            if(count > 0)
            {
                MessageBox.Show("Yeni müştəri əlavə edildi", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearInputs();
            } 

            else
                MessageBox.Show("Yeni müştəri əlavə edilmədi!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private int AddCustomer(Customer2 customer)
        {
            VirtualDatabase2.Customers.Add(customer);
            return 1;
        }
        private void ClearInputs()
        {
            nameTextBox.Text = string.Empty;
            surnameTextBox.Text = string.Empty;
            fatherNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            cityDropDwn.SelectedIndex = 0;
        }

        private void FormControls_Load(object sender, EventArgs e)
        {
            string[] cities =
            {
                "Sumqayıt",
                "Bakı",
                "Gəncə",
                "Xaçmaz",
                "Ağdam",
                "Suşa",
            };
            cityDropDwn.Items.AddRange(cities);
        }
    }
}
