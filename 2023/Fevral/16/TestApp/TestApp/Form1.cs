using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:/Omer"))
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(@"C:/Omer");

            }
            string path = Directory.GetCurrentDirectory();
            path = path.Remove(path.Length - 11, 10);
            File.Copy(path + "/Resources/Test.png", @"C:/Omer");
        }
    }
}
