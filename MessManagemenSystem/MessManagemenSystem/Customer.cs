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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnCSave_Click(object sender, EventArgs e)
        {
            string customerId = txtCId.Text;
            string customerName = txtCName.Text;
            string address = txtCAddress.Text;
            string city = txtCCity.Text;
            string phone = txtCPhone.Text;
            string gender = cmbCGender.Text;
            string dateJoin = dateCDateOfJoin.Value.ToString();
            int BuyUnit=0;
            if (!string.IsNullOrWhiteSpace(txtCUnit.Text) )
            {
                 BuyUnit = int.Parse(txtCUnit.Text.ToString());
            }
            else
            {
                BuyUnit=0;
            }
            

            string q = "if exists ( Select CustomerId From Customer Where  CustomerId='" + customerId + "' ) select CustomerId From Customer  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (customerId == "" || customerName == "" || address == "" || city == "" || phone == "" || gender == "")
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else { 
                if (returnValue != "0")
                {
                    MessageBox.Show("Student Already Exist!");
                }
                else
                {
                    
                    DB.AddCustomerData(new CustomerClass(customerId, customerName, address, city, phone, gender, dateJoin));
                    DB.AddAccount(new AccountClass(customerId, customerName));
                    string query1 = "Update Account Set UnitPurchased=UnitPurchased+" + BuyUnit + ";";
                    DB.AddQuery(query1);
                    if (BuyUnit > 0 ) { 
                        string query2 = "Insert into SoldUnit(CustomerId,UnitPurchased) VALUES('"+customerId+"',"+BuyUnit+") ";
                        DB.AddQuery(query2);
                    }
                    MessageBox.Show("Customer Record Saved!");
                }
            }
            txtCId.Clear();
            txtCName.Clear();
            txtCAddress.Clear();
            txtCCity.Clear();
            txtCPhone.Clear();
            txtCUnit.Clear();
           
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCId.Text;
            string q = "if exists ( Select CustomerId From Customer Where  CustomerId='" + customerId + "' ) select CustomerId From Customer  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {
                MessageBox.Show("Student Does Not Exist!");
            }
            else
            {
                string query = "Delete From Customer Where CustomerId='" + customerId + "';";
                DB.AddQuery(query);
                MessageBox.Show("Customer Record Deleted!");
            }
            txtCId.Clear();
            txtCName.Clear();
            txtCAddress.Clear();
            txtCCity.Clear();
            txtCPhone.Clear();
            txtCUnit.Clear();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            string query = "Select * From Customer;";
            DB.Binding(dgvCustomer,query,"Customer");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From Customer where CustomerId like('"+txtSearch.Text+"%');";
            DB.Binding(dgvCustomer, query, "Customer");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            string customerId = txtCId.Text;
            string customerName = txtCName.Text;
            string address = txtCAddress.Text;
            string city = txtCCity.Text;
            string phone = txtCPhone.Text;
            string gender = cmbCGender.Text;
            string dateJoin = dateCDateOfJoin.Value.ToString();
            
            string q = "if exists ( Select CustomerId From Customer Where  CustomerId='" + customerId + "' ) select CustomerId From Customer  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (customerId == "" || customerName == "" || address == "" || city == "" || phone == "" || gender == "")
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue == "0")
                {
                    MessageBox.Show("Student Do Not Exist!");
                }
                else
                {
                    string query = "Update Customer Set Name='" + customerName + "',Address='" + address + "', City='" + city + "', Phone='" + phone + "', Gender='" + gender + "', DateOfJoin='" + dateJoin + "'  WHERE CustomerId='" + customerId + "';";
                    DB.AddQuery(query);
                    MessageBox.Show("Customer Record Updated!");
                }
            }
            txtCId.Clear();
            txtCName.Clear();
            txtCAddress.Clear();
            txtCCity.Clear();
            txtCPhone.Clear();
            txtCUnit.Clear();
        }

        private void txtCUnit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCUnit.Text, "[^0-9]") )
            {
                MessageBox.Show("Please enter only numbers.");
                txtCUnit.Text = txtCUnit.Text.Remove(txtCUnit.Text.Length - 1);
            }
        }

        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCId.Text= this.dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtCName.Text= this.dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtCAddress.Text= this.dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtCCity.Text= this.dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtCPhone.Text= this.dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            cmbCGender.Text= this.dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            dateCDateOfJoin.Value = DateTime.Parse(this.dgvCustomer.CurrentRow.Cells[6].Value.ToString());
        }

        private void btnCClear_Click(object sender, EventArgs e)
        {
            txtCId.Clear();
            txtCName.Clear();
            txtCAddress.Clear();
            txtCCity.Clear();
            txtCPhone.Clear();
            txtCUnit.Clear();

        }

        private void btnTSoldUnit_Click(object sender, EventArgs e)
        {
            string query = "Select * From SoldUnit;";
            DB.Binding(dgvCustomer, query, "SoldUnit");
        }

        private void textSUSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From SoldUnit where CustomerId like('" + textSUSearch.Text + "%');";
            DB.Binding(dgvCustomer, query, "SoldUnit");
        }

        private void textSUSearch_Enter(object sender, EventArgs e)
        {
            textSUSearch.Text = "";
        }

        private void dateSUSearch_ValueChanged(object sender, EventArgs e)
        {
            if (textSUSearch.Text == "" || textSUSearch.Text == "Enter ID")
            {
                string query = "Select * From SoldUnit where Date='" + dateSUSearch.Value.ToString() + "';";
                DB.Binding(dgvCustomer, query, "SoldUnit");
            }
            else
            {
                string query = "Select * From SoldUnit where Date='" + dateSUSearch.Value.ToString() + "' AND CustomerId='" + textSUSearch.Text + "';";
                DB.Binding(dgvCustomer, query, "SoldUnit");
            }
        }
    }
}
