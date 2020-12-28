using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class OrderReady : Form
    {
        public OrderReady()
        {
            InitializeComponent();
        }

        private void goodbye_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderAgain_button_Click(object sender, EventArgs e)
        {
            resetAll();
            HomePage openForm = new HomePage();
            openForm.Show();
            this.Hide();
        }
        public void resetAll()
        {
            for (int i = 0; i < DB.len; i++)
                DB.drinkList[i].isSelected = false;
        }

        private void OrderReady_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
