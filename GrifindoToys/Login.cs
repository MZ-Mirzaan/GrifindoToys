using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToys
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NiightShade\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False;");
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=NiightShade\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False";
            string query = "SELECT COUNT(1) FROM Login WHERE Username= @Username AND Password=@Password";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtuser.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (count == 1)
                {
                    MessageBox.Show("Login successful!");
                    Menu f1 = new Menu();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
