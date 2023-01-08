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
    public partial class UIPayment : UserControl
    {
        public UIPayment()
        {
            InitializeComponent();
        }

        ClassItem itemObj=new ClassItem();
        private void itemFields()
        {
            itemObj.supplierId = txtIId.Text;
            itemObj.itemname = txtIName.Text;
            itemObj.quantity = txtIQuantity.Text;
            itemObj.date = dateIDate.Value.ToString();
            itemObj.amount = int.Parse(txtIAmount.Text);

        }

        ClassSupplier supObj = new ClassSupplier();
        private void supplierFields()
        {

            supObj.supplierId = txtSId.Text;
            supObj.name = txtSName.Text;
            supObj.cnic = txtSCnic.Text;
            supObj.phone = txtSPhone.Text;
            supObj.category = txtSCategory.Text;

        }
        // Supplier Record Save
        private void btnSSave_Click(object sender, EventArgs e)
        {
            supplierFields();
            string checkSupplierExist = "if exists ( Select SupplierId From Supplier Where  SupplierId='" + supObj.supplierId + "' ) select SupplierId From Supplier  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkSupplierExist);

            
            if (supObj.supplierId == "" || supObj.name == "" || supObj.cnic == "" || supObj.category == "" || supObj.phone == "" )
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
                    ClassDatabase.AddSupplier(supObj);
                    MessageBox.Show("Supplier Record Saved!");
                }
            }
        }

        // Supplier Record Delete
        private void btnSDelete_Click(object sender, EventArgs e)
        {
            supplierFields();
            string checkSupplierExist = "if exists ( Select SupplierId From Supplier Where  SupplierId='" + supObj.supplierId + "' ) select SupplierId From Supplier  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkSupplierExist);

            if (returnValue == "0")
            {
                MessageBox.Show("Supplier Does Not Exist!");
            }
            else
            {
                string deleteSupplierQuery = "Delete From Supplier Where SupplierId='" + supObj.supplierId + "';";
                ClassDatabase.SqlQuery(deleteSupplierQuery);
                MessageBox.Show("Supplier Record Deleted!");
            }
        }

        // Supplier Record Update
        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            supplierFields();
            string checkSupplierExist = "if exists ( Select  SupplierId From Supplier Where  SupplierId='" + supObj.supplierId + "' ) select SupplierId From Supplier  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkSupplierExist);

            if (supObj.supplierId == "" || supObj.name == "" || supObj.cnic == "" || supObj.category == "" || supObj.phone == "")
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
                    string updateSupplierQuery = "Update Supplier Set Name='" + supObj.name + "' ,CNIC='" + supObj.cnic + "' ,Phone='" + supObj.phone + "' ,Category='" + supObj.category + "' WHERE  SupplierId='" + supObj.supplierId + "';";
                    ClassDatabase.SqlQuery(updateSupplierQuery);
                    MessageBox.Show(" Supplier Record Updated!");
                }
            }
        }

        // Supplier Record Input Fields clearing
        private void btnSClear_Click(object sender, EventArgs e)
        {
            txtSId.Clear();
            txtSName.Clear();
            txtSCnic.Clear();
            txtSPhone.Clear();
            txtSCategory.Clear();
        }

        // Supplier Record showing
        private void btnSupplierTable_Click(object sender, EventArgs e)
        {
            string selectSuppliersQuery = "Select * From Supplier;";
            ClassDatabase.Binding(dgvSupplier, selectSuppliersQuery, "Supplier");
        }

        // supplier Record Search on changing text of txtSSearch
        private void txtSSearch_TextChanged(object sender, EventArgs e)
        {
            string selectSuppliersQuery = "Select * From Supplier where SupplierId like('" + txtSSearch.Text + "%');";
            ClassDatabase.Binding(dgvSupplier, selectSuppliersQuery, "Supplier");
        }

        // clearing txtSSearch field on entering mouse
        private void txtSSearch_Enter(object sender, EventArgs e)
        {
            txtSSearch.Clear();
        }
        // Item Record Save
        private void btnISave_Click(object sender, EventArgs e)
        {
            itemFields();
            itemObj.amount = 0;
           if (!string.IsNullOrWhiteSpace(txtIAmount.Text))
           {
               itemObj.amount = int.Parse(txtIAmount.Text.ToString());
           }
           else
           {
               itemObj.amount = 0;
           }
            
            string checkSupplierExist = "if exists ( Select SupplierId From Supplier Where  SupplierId='" + itemObj.supplierId + "' ) select SupplierId From Supplier  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkSupplierExist);

                       
           if (itemObj.supplierId == "" || itemObj.itemname == "" || itemObj.quantity == "" || txtIAmount.Text=="")
           {
               MessageBox.Show("Please Enter All the Data Fields!");
           }
           else
           {
               if (returnValue != "0")
               {
                   ClassDatabase.AddItem(itemObj);
                   MessageBox.Show("Item Record Saved!");
                   
               }
               else
               {
                   MessageBox.Show("Supplier does not Exist!");
               }
           }
        }

        // forcing input of amount to be integer
        private void txtIAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtIAmount.Text = txtIAmount.Text.Remove(txtIAmount.Text.Length - 1);
            }
        }

        // Item Record Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            itemFields();
            string checkSupplierExist = "if exists ( Select SupplierId From Item Where  SupplierId='" + itemObj.supplierId + "' AND date='"+itemObj.date+"' ) select SupplierId From Item  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkSupplierExist);


            if (itemObj.supplierId == "" || itemObj.itemname == "" || itemObj.quantity == "" )
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
           {
               if (returnValue != "0")
               {
                   string updateItemQuery = "Update Item Set SupplierId='" + itemObj.supplierId + "',ItemName='" + itemObj.itemname + "' ,Quantity='" + itemObj.quantity + "' ,Amount=" + itemObj.amount + "  WHERE  Date='" + itemObj.date + "';";
                   ClassDatabase.SqlQuery(updateItemQuery);
                   MessageBox.Show("Item Record Saved!");
                   
               }
               else
               {
                   MessageBox.Show("Record does not Exist!");
               }
           }
        }

        // Item Record Delete
        private void btnIDelete_Click(object sender, EventArgs e)
        {
            itemFields();
            itemObj.date = dateIDate.Value.ToString();
            string checkDateExist = "if exists ( Select date From Item Where  date='" + itemObj.date + "' ) select date From Item  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkDateExist);

            if (returnValue == "0")
            {
                MessageBox.Show("Date Does Not Exist!");
            }
            else
            {
                string deleteItemQuery = "Delete From Item Where date='" + itemObj.date + "';";
                ClassDatabase.SqlQuery(deleteItemQuery);
                MessageBox.Show("Item Record Deleted!");
            }
        }

        // Item Record Fields clearing
        private void btnIClear_Click(object sender, EventArgs e)
        {
            txtIId.Clear();
            txtIName.Clear();
            txtIQuantity.Clear();
        }


        // Showing record of Items in data grid view
        private void btnItemTable_Click(object sender, EventArgs e)
        {
            string selectAllItems = "Select * From Item;";
            ClassDatabase.Binding(dgvSupplier, selectAllItems, "Item");
        }

        // Item Record Searching through date
        private void dateISearch_ValueChanged(object sender, EventArgs e)
        {
            string selectItemOfDate = "Select * From Item where Date='" + dateISearch.Value.ToString() + "';";
            ClassDatabase.Binding(dgvSupplier, selectItemOfDate, "Item");
        }

    }
    
}
