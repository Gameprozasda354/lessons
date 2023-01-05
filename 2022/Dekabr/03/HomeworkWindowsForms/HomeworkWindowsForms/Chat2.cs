using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkWindowsForms
{
    public partial class Chat2 : Form
    {
        public Form MainChatScreen = null;
        public Chat2()
        {
            InitializeComponent();
        }

        private void send2_Click(object sender, EventArgs e)
        {
            if(MainChatScreen == null)
            {
                var openForms = Application.OpenForms;

                foreach (var item in openForms)
                {
                    if (item.GetType() == typeof(Form1))
                    {
                        MainChatScreen = (Form1)item;
                    }
                }
            }

            var message = chat2Message.Text;
            chat2Message.Text = string.Empty;

            Label label = new Label();
            string time = DateTime.Now.ToString("HH:mm:s");
            label.Text = $"Chat2 ({time}): {message}";
            label.ClientSize = new Size(1250, 20);
            label.Font = new Font(new FontFamily("Microsoft Sans Serif"), 13);
            label.ForeColor = Color.Red;
            label.Location = new Point(0, TextLocation.TopPosition);
            MainChatScreen.Controls.Add(label);
        }
    }
}
