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

        VirtualDatabase virtualDatabase = new VirtualDatabase();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = "Əli",
                SurName = "Novruzlu",
                MaleOrFemale = "Male",
                Country = "Azerbaijan",
                City = "Sumgayit",
                Number = 0555985897,
                Adress = "11-ci mikr",
                Email = "NvrzlEli234@gmail.com"
            };
            User user2 = new User()
            {
                Name = "Xaliq",
                SurName = "Isgandarov",
                MaleOrFemale = "Male",
                Country = "Azerbaijan",
                City = "Sumgayit",
                Number = 0708897000,
                Adress = "Kotec 22 meh ev 28/11a",
                Email = "xaliqisgndrov86@gmail.com"
            };
            User user3 = new User()
            {
                Name = "Omer",
                SurName = "Isgenderli",
                MaleOrFemale = "Male",
                Country = "Azerbaijan",
                City = "Sumgayit",
                Number = 0555557575,
                Adress = "Kotec 22 meh ev 28/11a",
                Email = "omerisgzoom@gmail.com"
            };
            User user4 = new User()
            {
                Name = "Məhəmməd",
                SurName = "Məmmədli",
                MaleOrFemale = "Male",
                Country = "Azerbaijan",
                City = "Bakı",
                Number = 0706217000,
                Adress = "Nizami rayonu",
                Email = "mehemmed_mmd@gmail.com"
            };
            User user5 = new User()
            {
                Name = "Ehmed",
                SurName = "Settarli",
                MaleOrFemale = "Male",
                Country = "Azerbaijan",
                City = "Gence",
                Number = 0776650000,
                Adress = "Nizami kuc",
                Email = "ehmdstr546@gmail.com"
            };

            virtualDatabase.AddUser(user);
            virtualDatabase.AddUser(user2);
            virtualDatabase.AddUser(user3);
            virtualDatabase.AddUser(user4);
            virtualDatabase.AddUser(user5);

            FillListBox();
        }
        public void FillListBox()
        {
            foreach (User item in VirtualDatabase.users)
            {
                userLstBox.Items.Add(item);
            }
        }
        private void WriteUserInformations(object sender, EventArgs e)
        {
            User user = (User)userLstBox.SelectedItem;

            nameTxtBox.Text = user.Name;
            surNameTxtBox.Text = user.SurName;
            maleOrFemaleTxtBox.Text = user.MaleOrFemale;
            countryTxtBox.Text = user.Country;
            cityTxtBox.Text = user.City;
            adressTxtBox.Text = user.Adress;
            numberTxtBox.Text = user.Number.ToString();
            emailTxtBox.Text = user.Email;
        }

        private void UpdateElement(object sender, EventArgs e)
        {
            User user = (User)userLstBox.SelectedItem;
            user.Name = nameTxtBox.Text;
            user.SurName = surNameTxtBox.Text;
            user.MaleOrFemale = maleOrFemaleTxtBox.Text;
            user.Country = countryTxtBox.Text;
            user.City = cityTxtBox.Text;
            user.Adress = adressTxtBox.Text;
            user.Number = Convert.ToInt32(numberTxtBox.Text);
            user.Email = emailTxtBox.Text;

        }

        private void DeleteElement(object sender, EventArgs e)
        {
            User user = (User)userLstBox.SelectedItem;
            virtualDatabase.RemoveUser(user.Name, user.SurName);
            userLstBox.Items.Remove(user);
            ClearTextBoxes();
        }
        public void ClearTextBoxes()
        {
            foreach (Control item in this.Controls)
            {
                
            }
        }
    }
}
