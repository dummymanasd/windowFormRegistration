using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name = "";
        private string mail = "";
        private string birthDay = "";
        private string gender = "";
        private string phoneNumber = "";
        private string address = "";
        

        private void Clicked(object sender, MouseEventArgs e)
        {
            name = tbName.Text;
            mail = tbMail.Text;
            birthDay = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            phoneNumber = tbNumber.Text;
            address = tbAddress.Text;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            
            MessageBox.Show("Your Form has been subitted");
            // throw new System.NotImplementedException();
        }
    }
}