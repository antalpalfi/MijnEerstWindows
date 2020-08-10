using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox.Text = cmbBox.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBox.Items.Add("Antal");
            cmbBox.Items.Add("Bela");
            cmbBox.Items.Add("Jani");
            cmbBox.Items.Add("Akos");
            cmbBox.Items.Add("Kriszti");
            cmbBox.Items.Add("Piri");
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            cmbBox.Items.Remove(txtBox.Text);
        }
    }
}
