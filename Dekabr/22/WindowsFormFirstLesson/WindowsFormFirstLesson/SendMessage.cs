﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            string txtMsgValue = txtMessage.Text;
            ShowMessage showMessageForm = new ShowMessage(txtMsgValue);
            showMessageForm.Show();
        }

        private void myEvent(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
        }
    }
}
