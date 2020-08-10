using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<User> gebruikers = new BindingList<User>();
            cmbBox.DisplayMember = "Voornaam";
            cmbBox.ValueMember = "Achternaam";
            gebruikers.Add(new User("Ken", "Field"));
            gebruikers.Add(new User("Jan", "Janssens"));
            gebruikers.Add(new User("Geert", "Hoste"));
            cmbBox.DataSource = gebruikers;

        }
        public class User
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public User(string vn, string an)
            {
                Voornaam = vn;
                Achternaam = an;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbBox.SelectedValue.ToString());
        }
    }
}
