using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrifindoToys
{
    public partial class Employees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NiightShade\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False;");
        public Employees()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtEmpID.Clear();
            txtEmpName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpDOB.Value = DateTime.Now;
            txttelno.Clear();
            txtAddress.Clear();
            txtSalary.Clear();
            txtAllowances.Clear();
            txtOTRate.Clear();
            txttaxrate.Clear();
        }

        private string GetGender()
        {
            if (rbMale.Checked)
                return "M         ";
            else if (rbFemale.Checked)
                return "F         ";
            else
                return string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch = "SELECT * FROM Employees WHERE emp_ID='" + txtEmpID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEmpName.Text = dr["emp_Name"].ToString();
                    if (dr["Gender"].Equals("M         "))
                        rbMale.Checked = true;
                    else
                        rbFemale.Checked = true;
                    dtpDOB.Value = Convert.ToDateTime(dr["DOB"]);
                    txtAddress.Text = dr["Address"].ToString();
                    txttelno.Text = dr["telNo"].ToString();
                    txtSalary.Text = dr["Monthly_Salary"].ToString();
                    txtAllowances.Text = dr["Allowances"].ToString();
                    txtOTRate.Text = dr["Overtime_HR"].ToString();
                    txttaxrate.Text = dr["Tax_Rate"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                    ClearFields();
                }
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = GetGender();
                string sqlUpdate = "UPDATE Employees SET emp_Name='" + txtEmpName.Text + "', Gender='" + gender + "'," +
                    " " +"DOB='" + dtpDOB.Value.ToString("yyyy-MM-dd") + "'," +
                    " telNo='" + txttelno.Text + "', Address='" + txtAddress.Text + "'," +
                    " Monthly_Salary='" + txtSalary.Text + "', Allowances='" + txtAllowances.Text + "'," +
                    " Overtime_HR='" + txtOTRate.Text + "',Tax_Rate ='" + txttaxrate.Text + "' WHERE emp_ID='" + txtEmpID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee updated successfully.");
                ClearFields();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            try
            {
                string gender = GetGender();
                string sqlSave = "INSERT INTO Employees " +
                    "(emp_ID, emp_Name, Gender, DOB, telNo, Address, Monthly_Salary, Allowances, Overtime_HR,Tax_Rate   ) " +
                    "VALUES ('" + txtEmpID.Text + "', '" + txtEmpName.Text + "', '" + gender + "'," +
                    " '" + dtpDOB.Value.ToString("yyyy-MM-dd") + "'," +
                    "'" + txttelno.Text + "', '" + txtAddress.Text + "', '" + txtSalary.Text + "', " +
                    "'" + txtAllowances.Text + "', '" + txtOTRate.Text + "','" + txttaxrate + "')";
                SqlCommand cmd = new SqlCommand(sqlSave, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee added successfully.");
                ClearFields();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res;
                res = MessageBox.Show("Are you sure to delete this record(y/n)?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM Employees WHERE emp_ID='" + txtEmpID.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlDelete, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee deleted successfully.");
                }
                ClearFields();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlViewAll = "SELECT * FROM Employees";
                SqlDataAdapter da = new SqlDataAdapter(sqlViewAll, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmployees.DataSource = dt;
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            f2.ShowDialog();
            this.Hide();
        }
        private void txttaxR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttaxrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
