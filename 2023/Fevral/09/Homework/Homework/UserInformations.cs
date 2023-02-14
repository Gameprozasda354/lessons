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
    public partial class UserInformations : Form
    {
        public UserInformations()
        {
            InitializeComponent();
        }

        public void WriteUserInformations(int id, string name,string surName,string email, string phone, string country, string city, string address)
        {
            idTxtBox.Text = id.ToString();
            nameTxtBox.Text = name;
            surnameTxtBox.Text = surName;
            fullNameTxtBox.Text = name + " " + surName;
            emailTxtBox.Text = email;
            phoneTxtBox.Text = phone;
            countryTxtBox.Text = country;
            cityTxtBox.Text = city;
            addressTxtBox.Text = address;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
