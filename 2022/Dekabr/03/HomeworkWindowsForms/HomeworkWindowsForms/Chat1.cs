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
    public partial class Chat1 : Form
    {
        public Chat1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Writer(text.Text);
        }
    }
}
