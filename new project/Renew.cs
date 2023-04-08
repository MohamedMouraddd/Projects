using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project
{
    public partial class Renew : Form
    {
        public Renew()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                label7.Visible = true;
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
                label7.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            int flag = 0;
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            { label5.Visible = true; flag = 1; }


            // Error for no reason ask fawzy
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.TextLength < 14)
            { label4.Visible = true; flag = 1; }
            if (flag == 0)
            {
                MessageBox.Show("Transaction Successful\n" +
                "Liscence Renewed");
            }
        }
    }
}
