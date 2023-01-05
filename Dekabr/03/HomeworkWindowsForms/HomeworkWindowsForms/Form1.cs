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
    public partial class Form1 : Form
    {
        public void Start()
        {
            Chat1 chat = new Chat1();
            Chat2 chat2 = new Chat2();
            chat.Show();
            chat2.Show();
        }
        public Form1()
        {
            
        }
        public void Writer(string a)
        {
                Label label = new Label();
                label.Text = a;
        }
        
    }
}
