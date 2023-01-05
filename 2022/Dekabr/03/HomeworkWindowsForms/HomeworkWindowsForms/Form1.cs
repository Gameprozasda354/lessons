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
        public Form1()
        {
            Chat1 chat = new Chat1();
            Chat2 chat2 = new Chat2();
            chat.Show();
            chat2.Show();
            InitializeComponent();
        }
    }
}
