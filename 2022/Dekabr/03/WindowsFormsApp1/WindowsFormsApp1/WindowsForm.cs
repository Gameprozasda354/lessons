using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WindowsForm : Form
    {
        public WindowsForm(string _sendedText)
        {
            InitializeComponent();
            sendedText.Text = _sendedText;
        }
    }
}
