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
    public partial class UICustomer : UserControl
    {
        public UICustomer()
        {
            InitializeComponent();
        }

        ClassCustomer custObj = new ClassCustomer();
        private void CustomerFields()
        {
            custObj.CustomerId = txtCId.Text;
            custObj.Name = txtCName.Text;
            custObj.Address = txtCAddress.Text;
            custObj.City = txtCCity.Text;
            custObj.Phone = txtCPhone.Text;
            custObj.Gender = cmbCGender.Text;
            custObj.DateOfJoin = dateCDateOfJoin.Value.ToString();
        }
        //save customer record
        private void btnCSave_Click(object sender, EventArgs e)
        {
            CustomerFields();

            int BuyUnit=0;
            if (!string.IsNullOrWhiteSpace(txtCUnit.Text) )
            {
                 BuyUnit = int.Parse(txtCUnit.Text.ToString());
            }
            else
            {
                BuyUnit=0;
            }

            string checkCustomerExistQuery = "if exists ( Select CustomerId From Customer Where  CustomerId='" + custObj.CustomerId + "' ) select CustomerId From Customer  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkCustomerExistQuery);
            if (custObj.CustomerId == "" || custObj.Name == "" || custObj.Address == "" || custObj.City == "" || custObj.Phone == "" || custObj.Gender == "")
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
                    ClassDatabase.AddCustomerData(custObj);
                    ClassDatabase.AddAccount(new ClassAccount(custObj.CustomerId, custObj.Name));
                    string updateAccountQuery = "Update Account Set UnitPurchased=UnitPurchased+" + BuyUnit + ";";
                    ClassDatabase.SqlQuery(updateAccountQuery);
                    if (BuyUnit > 0 ) { 
                        string insertSoldUnitQuery = "Insert into SoldUnit(CustomerId,UnitPurchased) VALUES('"+ custObj.CustomerId + "',"+BuyUnit+") ";
                        ClassDatabase.SqlQuery(insertSoldUnitQuery);
                    }
                    MessageBox.Show("Customer Record Saved!");
                }
            }
           
        }


        //update customer record
        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            CustomerFields();

            string checkCustomerExistQuery = "if exists ( Select CustomerId From Customer Where  CustomerId='" + custObj.CustomerId + "' ) select CustomerId From Customer  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkCustomerExistQuery); 

            if (custObj.CustomerId == "" || custObj.Name == "" || custObj.Address == "" || custObj.City == "" || custObj.Phone == "" || custObj.Gender == "")
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue == "0")
                {
                    MessageBox.Show("Customer Does Not Exist!");
                }
                else
                {
                    string UpdateCustomerQuery = "Update Customer Set Name='" + custObj.Name + "',Address='" + custObj.Address + "', City='" + custObj.City + "', Phone='" + custObj.Phone + "', Gender='" + custObj.Gender + "', DateOfJoin='" + custObj.DateOfJoin + "'  WHERE CustomerId='" + custObj.CustomerId + "';";
                    ClassDatabase.SqlQuery(UpdateCustomerQuery);
                    MessageBox.Show("Customer Record Updated!");
                }
            }
        }

        //delete customer record
        private void btnCDelete_Click(object sender, EventArgs e)
        {
            CustomerFields();
            string checkCustomerExistQuery = "if exists ( Select CustomerId From Customer Where  CustomerId='" + custObj.CustomerId + "' ) select CustomerId From Customer  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkCustomerExistQuery);

            if (returnValue == "0")
            {
                MessageBox.Show("Student Does Not Exist!");
            }
            else
            {
                string deleteCustomerQuery = "Delete From Customer Where CustomerId='" + custObj.CustomerId + "';";
                ClassDatabase.SqlQuery(deleteCustomerQuery);
                MessageBox.Show("Customer Record Deleted!");
            }
        }

        //forcing user to enter only number in txtCUnit
        private void txtCUnit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCUnit.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtCUnit.Text = txtCUnit.Text.Remove(txtCUnit.Text.Length - 1);
            }
        }

        //show customer record
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            string showCustomerRecordQuery = "Select * From Customer;";
            ClassDatabase.Binding(dgvCustomer,showCustomerRecordQuery,"Customer");
        }

        //clearing all text fields
        private void btnCClear_Click(object sender, EventArgs e)
        {
            txtCId.Clear();
            txtCName.Clear();
            txtCAddress.Clear();
            txtCCity.Clear();
            txtCPhone.Clear();
            txtCUnit.Clear();

        }

        //search customer record through customer ID
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchCustomerIdQuery = "Select * From Customer where CustomerId like('"+txtSearch.Text+"%');";
            ClassDatabase.Binding(dgvCustomer, searchCustomerIdQuery, "Customer");
        }

        //clearing text field as cursor enters
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }


        // showing record in text field as user click on any row of data grid view of customer record
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

        private void btnSaleRecord_Click(object sender, EventArgs e)
        {
            string showSoldUnitQuery = "Select * From SoldUnit;";
            ClassDatabase.Binding(dgvCustomer, showSoldUnitQuery, "SoldUnit");
        }

        //searching sold unit through customer ID
        private void textSRSearch_TextChanged(object sender, EventArgs e)
        {
            string showSoldUnitOfCustomerId = "Select * From SoldUnit where CustomerId like('" + textSRSearch.Text + "%');";
            ClassDatabase.Binding(dgvCustomer, showSoldUnitOfCustomerId, "SoldUnit");
        }

        //clear field as user enter search field
        private void textSRSearch_Enter(object sender, EventArgs e)
        {
            textSRSearch.Text = "";
        }

        //showing record on basis of date or date and ID
        private void dateSRSearch_ValueChanged(object sender, EventArgs e)
        {
            if (textSRSearch.Text == "" || textSRSearch.Text == "Enter ID")
            {
                string showSaleRecordOfDate = "Select * From SoldUnit where Date='" + dateSRSearch.Value.ToString() + "';";
                ClassDatabase.Binding(dgvCustomer, showSaleRecordOfDate, "SoldUnit");
            }
            else
            {
                string showSaleRecordOfDateID = "Select * From SoldUnit where Date='" + dateSRSearch.Value.ToString() + "' AND CustomerId='" + textSRSearch.Text + "';";
                ClassDatabase.Binding(dgvCustomer, showSaleRecordOfDateID, "SoldUnit");
            }
        }
    }
}
