using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnEerstWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLeerlingen.Items.Add("Antal");
            cbLeerlingen.Items.Add("Koen");
            cbLeerlingen.Items.Add("Yura");
            cbLeerlingen.Items.Add("Ken");
            cbLeerlingen.Items.Add("Tomi");
            cbLeerlingen.Items.Add("Gergo");

            foreach (var item in cbLeerlingen.Items)
            {
                lbLeerLingen.Items.Add(item);
            }
        }

        private void lblMijnLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnMijnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Word");
        }

        private void cbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbLeerlingen.SelectedIndex.ToString());
            lblMijnLabel.Text = cbLeerlingen.SelectedItem.ToString();
        }

        private void lbLeerLingen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            lbLeerLingen.Items.Add(txtbox2.Text);
            txtbox2.Enabled = false; // egy nevet lehet csak be irni aztan le tiltja
        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
