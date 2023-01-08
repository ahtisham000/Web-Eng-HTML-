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
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnSSave_Click(object sender, EventArgs e)
        {
            string SId = txtSId.Text; 
            string SName = txtSName.Text;
            string SCnic = txtSCnic.Text;
            string Sphone = txtSPhone.Text;
            string SCatagory = txtSCategory.Text;



            string q = "if exists ( Select SupplierId From Supplier Where  SupplierId='" + SId + "' ) select SupplierId From Supplier  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (SId == "" || SName == "" || SCnic == "" || SCatagory == "" || Sphone == "" )
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue != "0")
                {
                    MessageBox.Show("Supplier Already Exist!");
                }
                else
                {
                    DB.AddSupplier(new SupplierClass(SId, SName, SCnic, Sphone, SCatagory));
                    MessageBox.Show("Supplier Record Saved!");
                }
            }
            txtSId.Clear();
            txtSName.Clear();
            txtSCnic.Clear();
            txtSPhone.Clear();
            txtSCategory.Clear();
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            string SId = txtSId.Text;
            string q = "if exists ( Select SupplierId From Supplier Where  SupplierId='" + SId + "' ) select SupplierId From Supplier  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {
                MessageBox.Show("Supplier Does Not Exist!");
            }
            else
            {
                string query = "Delete From Supplier Where SupplierId='" + SId + "';";
                DB.AddQuery(query);
                MessageBox.Show("Supplier Record Deleted!");
            }
            txtSId.Clear();
            txtSName.Clear();
            txtSCnic.Clear();
            txtSPhone.Clear();
            txtSCategory.Clear();
        }

        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            string SId = txtSId.Text;
            string SName = txtSName.Text;
            string SCnic = txtSCnic.Text;
            string Sphone = txtSPhone.Text;
            string SCatagory = txtSCategory.Text;

            string q = "if exists ( Select  SupplierId From Supplier Where  SupplierId='" + SId + "' ) select SupplierId From Supplier  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (SId == "" || SName == "" || SCnic == "" || SCatagory == "" || Sphone == "")
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
                    string query = "Update Supplier Set Name='" + SName + "' ,CNIC='" + SCnic + "' ,Phone='" + Sphone + "' ,Category='" + SCatagory + "' WHERE  SupplierId='" + SId + "';";
                    DB.AddQuery(query);
                    MessageBox.Show(" Supplier Record Updated!");
                }
            }
            txtSId.Clear();
            txtSName.Clear();
            txtSCnic.Clear();
            txtSPhone.Clear();
            txtSCategory.Clear();
        }

        private void btnSupplierTable_Click(object sender, EventArgs e)
        {
            string query = "Select * From Supplier;";
            DB.Binding(dgvSupplier, query, "Supplier");
        }

        private void btnItemTable_Click(object sender, EventArgs e)
        {
            string query = "Select * From Item;";
            DB.Binding(dgvSupplier, query, "Item");
        }

        private void txtSSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From Supplier where SupplierId like('" + txtSSearch.Text + "%');";
            DB.Binding(dgvSupplier, query, "Supplier");
        }

        private void txtSSearch_Enter(object sender, EventArgs e)
        {
            txtSSearch.Clear();
        }

        private void textISearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textISearch_Enter(object sender, EventArgs e)
        {
            //textISearch.Clear();
        }

        private void btnISave_Click(object sender, EventArgs e)
        {
            string supplierId = txtIId.Text; 
           string itemname =txtIName.Text;
           string quantity =txtIQuantity.Text;
           int amount = 0;
           if (!string.IsNullOrWhiteSpace(txtIAmount.Text))
           {
               amount = int.Parse(txtIAmount.Text.ToString());
           }
           else
           {
               amount = 0;
           }
           string date = dateIDate.Value.ToString();

           string q = "if exists ( Select SupplierId From Supplier Where  SupplierId='" + supplierId + "' ) select SupplierId From Supplier  else select '0';";
           SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
           cmd.ExecuteScalar();
           string returnValue = cmd.ExecuteScalar().ToString();
           if (supplierId == "" || itemname == "" || quantity == "" || txtIAmount.Text=="")
           {
               MessageBox.Show("Please Enter All the Data Fields!");
           }
           else
           {
               if (returnValue != "0")
               {
                   DB.AddItem(new ItemClass(supplierId, itemname, quantity, amount, date));
                   MessageBox.Show("Item Record Saved!");
                   
               }
               else
               {
                   MessageBox.Show("Supplier does not Exist!");
               }
           }
           txtIId.Clear();
           txtIName.Clear();
           txtIQuantity.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string supplierId =txtIId.Text;
           string itemname =txtIName.Text;
           string quantity =txtIQuantity.Text;
           int amount = int.Parse(txtIAmount.Text);
           string date = dateIDate.Value.ToString();

           string q = "if exists ( Select SupplierId From Item Where  SupplierId='" + supplierId + "' AND date='"+date+"' ) select SupplierId From Item  else select '0';";
           SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
           cmd.ExecuteScalar();
           string returnValue = cmd.ExecuteScalar().ToString();
           if (supplierId == "" || itemname == "" || quantity == "" )
           {
               MessageBox.Show("Please Enter All the Data Fields!");
           }
           else
           {
               if (returnValue != "0")
               {
                   string query = "Update Item Set SupplierId='" + supplierId + "',ItemName='" + itemname + "' ,Quantity='" + quantity + "' ,Amount=" + amount + "  WHERE  Date='" + date + "';";
                   DB.AddQuery(query);
                   MessageBox.Show("Item Record Saved!");
                   
               }
               else
               {
                   MessageBox.Show("Record does not Exist!");
               }
           }
           txtIId.Clear();
           txtIName.Clear();
           txtIQuantity.Clear();
        }

        private void btnIDelete_Click(object sender, EventArgs e)
        {
            string date = dateIDate.Value.ToString();
            string q = "if exists ( Select date From Item Where  date='" + date + "' ) select date From Item  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {
                MessageBox.Show("Date Does Not Exist!");
            }
            else
            {
                string query = "Delete From Item Where date='" + date + "';";
                DB.AddQuery(query);
                MessageBox.Show("Item Record Deleted!");
            }
            //txtIId.Clear(); 
            // txtIName.Clear(); 
            // txtIQuantity.Clear();
        }

        private void dateISearch_ValueChanged(object sender, EventArgs e)
        {
            string query = "Select * From Item where Date='" + dateISearch.Value.ToString() + "';";
            DB.Binding(dgvSupplier, query, "Item");
        }

        private void txtIAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtIAmount.Text = txtIAmount.Text.Remove(txtIAmount.Text.Length - 1);
            }
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            txtSId.Clear();
            txtSName.Clear();
            txtSCnic.Clear();
            txtSPhone.Clear();
            txtSCategory.Clear();
        }

        private void btnIClear_Click(object sender, EventArgs e)
        {
            txtIId.Clear();
            txtIName.Clear();
            txtIQuantity.Clear();
        }
        }
    
}
