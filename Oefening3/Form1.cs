using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> NameList = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            NameList.Add("Antal");
            NameList.Add("Koen");
            NameList.Add("Sergio");
            NameList.Add("Latha");
            NameList.Add("Adam");
            NameList.Add("Patricia");
            NameList.Add("Ingrid");

            foreach (var item in NameList)
            {
                listBox.Items.Add(item);
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (var item in NameList)
            {
                if (item.ToLower().Contains(textBox.Text))
                {
                    listBox.Items.Add(item);
                }
            }
        }
    }
}
