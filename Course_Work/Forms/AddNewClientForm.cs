﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class AddNewClientForm : Form
    {
        public Client client = null;
        public AddNewClientForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void OkClick(object sender, EventArgs e)
        {
            client = new Client(1, ClientSurnameTextBox.Text, ClientNameTextBox.Text, ClientFartherNameTextBox.Text, ClientAddressTextBox.Text, ClientPhoneNumberTextBox.Text);
        }

        private void CancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
