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
    public partial class UIEmployee : UserControl
    {
        public UIEmployee()
        {
            InitializeComponent();
        }

        ClassEmployee empObj = new ClassEmployee();

        private void empFields()
        {
            empObj.employeeId = txtEId.Text;
            empObj.name = txtEName.Text;
            empObj.cnic = txtECnic.Text;
            empObj.phone = txtEPhone.Text;
            empObj.address = txtEAddress.Text;
            empObj.city = txtECity.Text;
            empObj.gender = cmbEGender.Text;
            empObj.jobtype = txtEJobType.Text;
            empObj.dateOfJoin = dateEJoin.Value.ToString();
        }


        //save employee record
        private void btnESave_Click(object sender, EventArgs e)
        {
            empFields();
            int salary = 0;
            if (!string.IsNullOrWhiteSpace(txtESalary.Text))
            {
                salary = int.Parse(txtESalary.Text.ToString());
            }
            else
            {
                salary = 0;
            }
           
            string checkEmployeeExistQuery = "if exists ( Select EmployeeId From Employee Where  EmployeeId='" + empObj.employeeId + "' ) select EmployeeId From Employee  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkEmployeeExistQuery);

            
            if (empObj.employeeId == "" || empObj.name == "" || empObj.cnic == "" || empObj.phone == "" || empObj.address == "" || empObj.city == "" || empObj.phone == "" || empObj.gender == "" || empObj.jobtype == "" || txtESalary.Text=="")
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
                    ClassDatabase.AddEmployeeData(empObj);
                    MessageBox.Show("Employee Record Saved!");
                }
            }           
        }

        //force salary to be in integers
        private void txtESalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtESalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtESalary.Text = txtESalary.Text.Remove(txtESalary.Text.Length - 1);
            }
        }

        //Update Employee Record
        private void btnEUpdate_Click(object sender, EventArgs e)
        {
            empFields();
            int salary = 0;
            if (!string.IsNullOrWhiteSpace(txtESalary.Text))
            {
                salary = int.Parse(txtESalary.Text.ToString());
            }
            else
            {
                salary = 0;
            }
            string checkEmployeeExistQuery = "if exists ( Select EmployeeId From Employee Where  EmployeeId='" + empObj.employeeId + "' ) select EmployeeId From Employee  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkEmployeeExistQuery);
            if (empObj.employeeId == "" || empObj.name == "" || empObj.cnic == "" || empObj.phone == "" || empObj.address == "" || empObj.city == "" || empObj.phone == "" || empObj.gender == "" || empObj.jobtype == "" || txtESalary.Text == "")
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
                    string updateEmployee = "Update Employee Set Name='" + empObj.name + "',CNIC='" + empObj.cnic + "', Address='" + empObj.address + "', City='" + empObj.city + "', Phone='" + empObj.phone + "', Gender='" + empObj.gender + "',JobType='" + empObj.jobtype + "', DateOfJoin='" + empObj.dateOfJoin + "' WHERE EmployeeId='" + empObj.employeeId + "';";
                    ClassDatabase.SqlQuery(updateEmployee);
                    MessageBox.Show("Employee Record Updated!");
                }
            }
        }

        //delete Employee Record
        private void btnEDelete_Click(object sender, EventArgs e)
        {
            empFields();
            string checkEmployeeExistQuery = "if exists ( Select EmployeeId From Employee Where  EmployeeId='" + empObj.employeeId + "' ) select EmployeeId From Employee  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkEmployeeExistQuery);

            if (returnValue == "0")
            {
                MessageBox.Show("Student Does Not Exist!");
            }
            else
            {
                string query = "Delete From Employee Where EmployeeId='" + empObj.employeeId + "';";
                ClassDatabase.SqlQuery(query);
                MessageBox.Show("Employee Record Deleted!");
            }
        }

        //clear all text fields on clicking button
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

        //Search Record through Employee ID
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchERecordQuery = "Select * From Employee where EmployeeId like('" + txtSearch.Text + "%');";
            ClassDatabase.Binding(dgvEmployee, searchERecordQuery, "Employee");
        }

        //when mouse enter in search field then it will be cleared
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        //show record when click on button
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            string showERecordQuery = "Select * From Employee;";
            ClassDatabase.Binding(dgvEmployee, showERecordQuery, "Employee");
        }

        
        // show Record in text fields when Employee click on record row in data grid view
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

       
    }
}
