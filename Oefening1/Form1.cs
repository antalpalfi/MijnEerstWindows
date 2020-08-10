using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Oefening1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtToevoegen_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btToevoegen_Click(object sender, EventArgs e)
        {


            ListBox.Items.Add(txtToevoegen.Text);
            txtToevoegen.Text = "";
            txtToevoegen.Focus();
           
        }
        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonTest_Click(this, new EventArgs());
            }
        }



    }
}
