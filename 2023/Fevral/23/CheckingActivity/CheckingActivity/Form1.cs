using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckingActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cursorTime = 0;

            var xPos = Cursor.Position.X;
            var yPos = Cursor.Position.Y;

            if(xPos == Cursor.Position.X && yPos == Cursor.Position.Y)
            {
                cursorTime++;
            }
            else
            {
                cursorTime = 0;
            }

            if (cursorTime > 5)
                MessageBox.Show("Salam");
            
        }
    }
}
