using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            

        }

        private void add_Click(object sender, EventArgs e)
        {
            AddNewElement(typeTxtBox.Text);
        }

        private void AddNewElement(string Name)
        {
            switch (Name)
            {
                case "Button":
                    CustomElement<Button> simpleElement = new CustomElement<Button>();
                    simpleElement.AdddingMethod();
                    break;

                case "Label":

                    break;

                case "CheckBox":

                    break;

                case "CheckedListBox":

                    break;

                case "ComboBox":

                    break;

                case "DataGridView":

                    break;

                case "DataTimePicker":

                    break;
                case "DomainUpDown":

                    break;

                default:
                    break;
            }
        }
    }
}
