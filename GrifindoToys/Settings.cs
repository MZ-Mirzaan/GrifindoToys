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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrifindoToys
{
    public partial class Settings : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NiightShade\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False;");
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlupdate;
            sqlupdate = "UPDATE Settings set Start_Date =" + dtpSD.Text + "', End_Date = '" + dtpED.Value + "', " +
                "NoOf_Leaves = '" + txtNOL.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlupdate, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
            con.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch;
                sqlSearch = "SELECT * FROM Settings";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtpSD.Text = dr["Start_date"].ToString();
                    dtpED.Text = dr["End_Date"].ToString();
                    txtDR.Text = dr["Date_Range"].ToString();
                    txtNOL.Text = dr["NoOf_Leaves"].ToString();
                }
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void txtsetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            f2.ShowDialog();
            this.Hide();
        }
    }
}
