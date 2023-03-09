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
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        public Form1(List<Person> personsList)
        {
            InitializeComponent();
            dataBase.persons = personsList;
        }

        private void SignIn(object sender, EventArgs e)
        {

            try
            {
                bool flag = false;

                foreach (Person person in dataBase.persons)
                {
                    if(person.UserName == userNameTxtBox.Text)
                    {
                        if(person.Password == passwordTxtBox.Text)
                        {
                            UserCabinet userCabinet = new UserCabinet(person.UserName, person.Password, dataBase.persons);
                            userCabinet.Show();
                        }
                        else
                        {
                            var test = ErrorMessages.passwordInvalid;
                            throw  new InvalidExpressionException("Password isn't correct");
                        }
                        flag = true;
                    }
                }

                if (!flag)
                {
                    throw new InvalidExpressionException("We can't find user that have this UserName!");
                }
            }
            catch(InvalidExpressionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewAccount(object sender, EventArgs e)
        {
            AddingNewPerson personAdding = new AddingNewPerson(dataBase.persons);
            personAdding.Show();
        }
    }
}
