using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class AddingNewPerson : Form
    {
        List<Person> persons = new List<Person>();
        public AddingNewPerson(List<Person> personList)
        {
            InitializeComponent();
            persons.AddRange(personList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in persons)
                {
                    if(item.UserName == userNameTxtBox.Text)
                    {
                        throw new Exception("This UserName exists please enter another UserName.");
                    }
                }
                if(passwordTxtBox.Text.Length <= 8)
                {
                    throw new Exception("Password length need to be greater than 8.");
                }

                if(passwordTxtBox.Text != repeatPasswordTxtBox.Text)
                {
                    throw new Exception("Thoose passwords didn't match.");
                }

                Person person = new Person()
                {
                    UserName = userNameTxtBox.Text,
                    Password = passwordTxtBox.Text
                };
                persons.Add(person);
                UserCabinet userCabinet = new UserCabinet(person.UserName, person.Password, persons);
                userCabinet.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignInPanel(object sender, EventArgs e)
        {
            Form1 form = new Form1(persons);
            form.Show();
        }
    }
}
