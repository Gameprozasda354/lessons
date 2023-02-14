using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            List<Customer> users = dataBase.GetCustomer(100);

            customersDataGridView.DataSource = users;

            customersDataGridView.Columns[0].Width = 30;
            customersDataGridView.Columns["Fullname"].Visible = false;
        }

        private void OpeningInformationPanel(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = customersDataGridView.CurrentCell.RowIndex;
            int id = (int)customersDataGridView[0, rowIndex].Value;
            string name = (string)customersDataGridView[1, rowIndex].Value;
            string surName = (string)customersDataGridView[2, rowIndex].Value;
            string email = (string)customersDataGridView[3, rowIndex].Value;
            string phone = (string)customersDataGridView[4, rowIndex].Value;
            string country = (string)customersDataGridView[5, rowIndex].Value;
            string city = (string)customersDataGridView[6, rowIndex].Value;
            string address = (string)customersDataGridView[7, rowIndex].Value;

            UserInformations userInformations = new UserInformations();
            userInformations.WriteUserInformations(id, name, surName, email, phone, country, city, address);
            userInformations.Show();
        }
    }
}
