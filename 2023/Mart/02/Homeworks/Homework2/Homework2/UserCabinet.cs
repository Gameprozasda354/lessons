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
    public partial class UserCabinet : Form
    {
        List<Person> persons = new List<Person>();
        public UserCabinet(string userName, string password, List<Person> personList)
        {
            InitializeComponent();
            userNameTxtBox.Text = userName;
            passwordTxtBox.Text = password;
            persons = personList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(persons);
            form.Show();
        }
    }
}
