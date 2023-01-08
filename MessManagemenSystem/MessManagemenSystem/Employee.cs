using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MessManagemenSystem
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From Employee where EmployeeId like('" + txtSearch.Text + "%');";
            DB.Binding(dgvEmployee, query, "Employee");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            string EId = txtEId.Text; 
            string EName = txtEName.Text;
            string cnic = txtECnic.Text;
            string phone = txtEPhone.Text;
            string address = txtEAddress.Text;
            string city = txtECity.Text; 
            string gender = cmbEGender.Text;
            string jobType = txtEJobType.Text;
            int salary = 0;
            if (!string.IsNullOrWhiteSpace(txtESalary.Text))
            {
                salary = int.Parse(txtESalary.Text.ToString());
            }
            else
            {
                salary = 0;
            }
            string dateJoin = dateEJoin.Value.ToString();

            string q = "if exists ( Select EmployeeId From Employee Where  EmployeeId='" + EId + "' ) select EmployeeId From Employee  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (EId == "" || EName == "" || cnic == "" || phone == "" || address == "" || city == "" || phone == "" || gender == "" || jobType == "" || txtESalary.Text=="")
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue != "0")
                {
                    MessageBox.Show("Employee Already Exist!");
                }
                else
                {
                    DB.AddEmployeeData(new EmployeeClass(EId, EName,cnic, phone, address, city, gender,jobType,salary ,dateJoin));
                    MessageBox.Show("Employee Record Saved!");
                }
            }
            txtEId.Clear();
            txtEName.Clear();
            txtECnic.Clear();
            txtEPhone.Clear();
            txtEAddress.Clear();
            txtECity.Clear();
            txtEJobType.Clear();
            txtESalary.Clear();
           
        }

        private void txtESalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtESalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtESalary.Text = txtESalary.Text.Remove(txtESalary.Text.Length - 1);
            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            string EId = txtEId.Text;
            string q = "if exists ( Select EmployeeId From Employee Where  EmployeeId='" + EId + "' ) select EmployeeId From Employee  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {
                MessageBox.Show("Student Does Not Exist!");
            }
            else
            {
                string query = "Delete From Employee Where EmployeeId='" + EId + "';";
                DB.AddQuery(query);
                MessageBox.Show("Employee Record Deleted!");
            }
            txtEId.Clear();
            txtEName.Clear();
            txtECnic.Clear();
            txtEPhone.Clear();
            txtEAddress.Clear();
            txtECity.Clear();
            txtEJobType.Clear();
            txtESalary.Clear();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            string query = "Select * From Employee;";
            DB.Binding(dgvEmployee, query, "Employee");
        }

        private void btnEUpdate_Click(object sender, EventArgs e)
        {
            string EId = txtEId.Text;
            string EName = txtEName.Text;
            string cnic = txtECnic.Text;
            string phone = txtEPhone.Text;
            string address = txtEAddress.Text;
            string city = txtECity.Text;
            string gender = cmbEGender.Text;
            string jobType = txtEJobType.Text;
            int salary = 0;
            if (!string.IsNullOrWhiteSpace(txtESalary.Text))
            {
                salary = int.Parse(txtESalary.Text.ToString());
            }
            else
            {
                salary = 0;
            }

            string dateJoin = dateEJoin.Value.ToString();

            string q = "if exists ( Select EmployeeId From Employee Where  EmployeeId='" + EId + "' ) select EmployeeId From Employee  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (EId == "" || EName == "" || cnic=="" || phone == "" || address == "" || city == "" || gender == "" || jobType=="" ||txtESalary.Text=="" )
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue == "0")
                {
                    MessageBox.Show("Employee Do Not Exist!");
                }
                else
                {
                    string query = "Update Employee Set Name='" + EName + "',CNIC='" + cnic + "', Address='" + address + "', City='" + city + "', Phone='" + phone + "', Gender='" + gender + "',JobType='" + jobType + "', DateOfJoin='" + dateJoin + "' WHERE EmployeeId='"+EId+"';";
                    DB.AddQuery(query);
                    MessageBox.Show("Employee Record Updated!");
                }
            }
            txtEId.Clear();
            txtEName.Clear();
            txtECnic.Clear();
            txtEPhone.Clear();
            txtEAddress.Clear();
            txtECity.Clear();
            txtEJobType.Clear();
            txtESalary.Clear();
        }

        private void dgvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEId.Text = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtEName.Text = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtECnic.Text = this.dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtEPhone.Text = this.dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtEAddress.Text = this.dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtECity.Text = this.dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            cmbEGender.Text = this.dgvEmployee.CurrentRow.Cells[6].Value.ToString();
            txtEJobType.Text = this.dgvEmployee.CurrentRow.Cells[7].Value.ToString();
            txtESalary.Text= this.dgvEmployee.CurrentRow.Cells[8].Value.ToString();
            dateEJoin.Value = DateTime.Parse(this.dgvEmployee.CurrentRow.Cells[9].Value.ToString());
        }

        private void btnEClear_Click(object sender, EventArgs e)
        {
            txtEId.Clear();
            txtEName.Clear();
            txtECnic.Clear();
            txtEPhone.Clear();
            txtEAddress.Clear();
            txtECity.Clear();
            txtEJobType.Clear();
            txtESalary.Clear();
        }
    }
}
