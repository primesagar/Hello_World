using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string[] names = new string[10];
        string[] contacts = new string[10];
        string[] citys = new string[10];
        string[] countrys = new string[10];

         int count = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string contact = contactNoTextBox.Text;
            string city = cityComboBox.Text;
            string country = countryComboBox.Text;

            if (name.Length < 3 || name.Length > 20)
            {
                namevlidLable.Text = "User Name must be Atleast 3 to 20 char long!";
                namevlidLable.ForeColor = Color.Red;
                return;
                
            }

            namevlidLable.Text = "";
            names[count] = name;
            count++;

            if (contact.Length==11)
            {
                contactVlidLable.Text = "Contact Number must be 11 char long!";
                contactVlidLable.ForeColor = Color.Red;
                return;

            }

            contactVlidLable.Text = "";
            contacts[count] = name;
            count++;

            if (city != null)
            {
                cityValidLable.Text = "Contact Number must be 11 char long!";
                contactVlidLable.ForeColor = Color.Red;
                return;

            }

            contactVlidLable.Text = "";
            contacts[count] = name;
            count++;

           

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
