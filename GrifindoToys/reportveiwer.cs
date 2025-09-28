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
    public partial class reportveiwer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NiightShade\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False;");

        public reportveiwer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportveiwer_Load(object sender, EventArgs e)
        {
            string sqlViewAll = "SELECT emp_ID, Salary_Month, No_Pay, Base_Pay, Gross_Pay FROM Salary";
            SqlDataAdapter da = new SqlDataAdapter(sqlViewAll, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Salaary f2 = new Salaary();
            f2.ShowDialog();
            this.Hide();
        }
    }
} 

