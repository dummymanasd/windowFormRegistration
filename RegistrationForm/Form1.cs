using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        // Connection string
        string connectionString = "Data Source=LAPTOP-KJLEI0QR\\SQLEXPRESS;Initial Catalog=intern; Integrated Security=True";

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
            
            MessageBox.Show("Your Form has been subitted. here are your data"+ "---  " +"Name:-"+ name +"--- "+ "Email:-"+ 
                            mail +"--- "+ "Gender:-"+ gender +"--- "+ "Phone Number:-"+ phoneNumber +"--- "+ "Address:-"+ address);
            
        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                  
                    Console.WriteLine("Database connection established successfully!");
                    
                    string query = "INSERT INTO Register_Form (Name, Email, Birthday, Gender, PhoneNumber, Address) VALUES (@Name, @Email, @Birthday, @Gender, @PhoneNumber, @Address)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", mail);
                        command.Parameters.AddWithValue("@Birthday", birthDay);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);

                        command.ExecuteNonQuery();
                    }
                    
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the process
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
