using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrifindoToys
{
    public partial class Salaary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NiightShade\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False;");

        public Salaary()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtempID.Clear();
            txtEmpName.Clear();
            txtSalary.Clear();
            txtAllowances.Clear();
            txtOTRate.Clear();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txttaxR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salaary_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch = "SELECT * FROM Employees WHERE emp_ID='" + txtempID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEmpName.Text = dr["emp_Name"].ToString();
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

        private void Calculate_Click(object sender, EventArgs e)
        {
            float overtime, nopay, monthlysal, overallattendance, cycledaterange, absentdays, basepay, allowance, otrate, othrs, grosspay, taxrate;
            try
            {
                overallattendance = float.Parse(txtLT.Text);
                cycledaterange = float.Parse(txtDR.Text);
                absentdays = float.Parse(txtabsentD.Text);
                monthlysal = float.Parse(txtSalary.Text);

                // NOPAY CALCULATION
                if (overallattendance < cycledaterange)
                {
                    nopay = (monthlysal / cycledaterange) * absentdays;
                    txtNopay.Text = nopay.ToString();
                }

                // BASE PAY CALCULATION
                allowance = float.Parse(txtAllowances.Text);
                otrate = float.Parse(txtOTRate.Text);
                othrs = float.Parse(txtOT.Text);
                overtime = othrs * otrate;
                basepay = monthlysal + allowance + overtime;
                txtBasep.Text = basepay.ToString();
                txtOvertime.Text = overtime.ToString();

                // GROSS PAY CALCULATION
                taxrate = float.Parse(txttaxrate.Text);
                nopay = float.Parse(txtNopay.Text);
                float tax = basepay * taxrate / 100;
                grosspay = basepay - (nopay + tax);
                txtGrossP.Text = grosspay.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }
        private void Validate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Start, End;
                Start = DateTime.Parse(dtpSD.Text);
                End = DateTime.Parse(dtpED.Text);

                string sqlLoad = "SELECT * FROM Settings";
                SqlCommand cmd = new SqlCommand(sqlLoad, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DateTime dbStartDate = DateTime.Parse(dr["Start_date"].ToString());
                    DateTime dbEndDate = DateTime.Parse(dr["End_Date"].ToString());

                    if (dbStartDate == Start && dbEndDate == End)
                    {
                        txtDR.Text = dr["Date_Range"].ToString();
                        txtNOL.Text = dr["NoOf_Leaves"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Date");
                        con.Close();
                    }
                }


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }
        private void Settings_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Salaary_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            f2.ShowDialog();
            this.Hide();
        }

        private void txttaxrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            try
            {

                DialogResult res;
                res = MessageBox.Show("Are you sure to Insert this record?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DateTime selectedDate = dtpSD.Value;
                int selectedMonth = selectedDate.Month;
                if (res == DialogResult.Yes)
                {
                    string sqlInsert;
                    sqlInsert = "INSERT INTO Salary (emp_ID , Salary_Month,No_Pay , Base_Pay , Gross_Pay ," +
                        " No_Leaves,No_Absentdays,No_Holidays,No_Overtime_H, Overall_At) VALUES " +
                        "('" + txtempID.Text + "','" + selectedMonth + "', '" + txtNopay.Text + "', '" + txtBasep.Text + "'," +
                        " '" + txtGrossP.Text + "', '" + txtLT.Text + "','" + txtabsentD.Text + "', '" + txtHoldiays.Text + "','" + txtOT.Text + "'," +
                        "'" + txtOA.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sqlInsert, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted!");
                    ClearFields();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void viewreport_Click(object sender, EventArgs e)
        {
            reportveiwer f3 = new reportveiwer();
            f3.ShowDialog();
            this.Hide();
        }
    }
}


