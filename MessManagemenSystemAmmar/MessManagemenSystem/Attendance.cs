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
using System.Timers;
using System.Windows.Threading;

namespace MessManagemenSystem
{
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void btnNewSheet_Click(object sender, EventArgs e)
        {
            

            string q = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' ) select Date From Attendance  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue != "0")
            {
                MessageBox.Show("Sheet Already Exist!");
            }
            else
            {
                string query = "Insert into Attendance(CustomerId) SELECT CustomerId FROM Customer;";
                DB.AddQuery(query);
                string query2 = "Select * From Attendance;";
                DB.Binding(dgvAttendance, query2, "Attendance");
                MessageBox.Show("Sheet Created for Date '" + dateBDate.Value.ToString() + "'");
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            string query2 = "Select * From Attendance;";
            DB.Binding(dgvAttendance, query2, "Attendance");
            string queryOrder = "Select * From Attendance ORDER BY Date DESC;";
            DB.Binding(dgvAttendance, queryOrder, "Attendance");

            
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            string query2 = "Select * From Account;";
            DB.Binding(dgvAttendance, query2, "Account");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From Account where CustomerId like('" + txtSearch.Text + "%');";
            DB.Binding(dgvAttendance, query, "Account");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnBreakFast_Click(object sender, EventArgs e)
        {
            string customerId = txtAId.Text;
            string q = "if exists ( Select UnitPurchased From Account Where  UnitPurchased < 1 AND CustomerId='" + customerId + "'  ) select UnitPurchased From Account  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {

                string q1 = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' AND CustomerId='" + customerId + "') select Date From Attendance  else select '0';";
                SqlCommand cmd1 = new SqlCommand(q1, DB.GetConnection());
                cmd1.ExecuteScalar();
                string returnValue1 = cmd1.ExecuteScalar().ToString();

                if (returnValue1 == "0")
                {
                    MessageBox.Show("Invalid!");
                }
                else
                {
                    string query = "Update Attendance  SET BreakFast=BreakFast+" + 1 + ",TotalUnits=TotalUnits+"+1+" Where CustomerId='" + customerId + "'AND Date='" + dateBDate.Value.ToString() + "' ;";
                    DB.AddQuery(query);
                    string query1 = "Update Account SET UnitPurchased=UnitPurchased-" + 1 + "Where CustomerId='" + customerId + "';";
                    DB.AddQuery(query1);
                    string query3 = "Update Account SET UnitConsumed=UnitConsumed+" + 1 + "Where CustomerId='" + customerId + "';";
                    DB.AddQuery(query3);
                    string query2 = "Select * From Attendance;";
                    DB.Binding(dgvAttendance, query2, "Attendance");
                    lblAcn.Text = "Attendance Marked!";
                }
            }
            else
            {
                MessageBox.Show("NO Balance");
            }
            txtAId.Clear();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            string customerId = txtAId.Text;
            string q = "if exists ( Select UnitPurchased From Account Where  UnitPurchased < 1 AND CustomerId='" + customerId + "'  ) select UnitPurchased From Account  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {

                string q1 = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' AND CustomerId='" + customerId + "') select Date From Attendance  else select '0';";
                SqlCommand cmd1 = new SqlCommand(q1, DB.GetConnection());
                cmd1.ExecuteScalar();
                string returnValue1 = cmd1.ExecuteScalar().ToString();

                if (returnValue1 == "0")
                {
                    MessageBox.Show("Invalid!");
                }
                else
                {
                    string query = "Update Attendance  SET Lunch=Lunch+" + 1 + ",TotalUnits=TotalUnits+" + 1 + " Where CustomerId='" + customerId + "'AND Date='" + dateBDate.Value.ToString() + "' ;";
                    DB.AddQuery(query);
                    string query1 = "Update Account SET UnitPurchased=UnitPurchased-" + 1 + "Where CustomerId='" + customerId + "';";
                    DB.AddQuery(query1);
                    string query3 = "Update Account SET UnitConsumed=UnitConsumed+" + 1 + "Where CustomerId='" + customerId + "';";
                    DB.AddQuery(query3);
                    string query2 = "Select * From Attendance;";
                    DB.Binding(dgvAttendance, query2, "Attendance");
                    lblAcn.Text = "Attendance Marked!";
                }
            }
            else
            {
                MessageBox.Show("NO Balance");
            }
            txtAId.Clear();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            string customerId = txtAId.Text;
            string q = "if exists ( Select UnitPurchased From Account Where  UnitPurchased < 1 AND CustomerId='" + customerId + "'  ) select UnitPurchased From Account  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {

                string q1 = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' AND CustomerId='" + customerId + "') select Date From Attendance  else select '0';";
                SqlCommand cmd1 = new SqlCommand(q1, DB.GetConnection());
                cmd1.ExecuteScalar();
                string returnValue1 = cmd1.ExecuteScalar().ToString();

                if (returnValue1 == "0")
                {
                    MessageBox.Show("Invalid!");
                }
                else
                {
                    string query = "Update Attendance  SET Dinner=Dinner+" + 1 + ",TotalUnits=TotalUnits+" + 1 + " Where CustomerId='" + customerId + "'AND Date='" + dateBDate.Value.ToString() + "' ;";
                    DB.AddQuery(query);
                    string query1 = "Update Account SET UnitPurchased=UnitPurchased-" + 1 + "Where CustomerId='" + customerId + "';";
                    DB.AddQuery(query1);
                    string query3 = "Update Account SET UnitConsumed=UnitConsumed+" + 1 + "Where CustomerId='" + customerId + "';";
                    DB.AddQuery(query3);
                    string query2 = "Select * From Attendance;";
                    DB.Binding(dgvAttendance, query2, "Attendance");
                    lblAcn.Text = "Attendance Marked!";
                }
            }
            else
            {
                MessageBox.Show("NO Balance");
            }
            txtAId.Clear();
        }

        private void txtAtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From Attendance where CustomerId like('" + txtAtSearch.Text + "%');";
            DB.Binding(dgvAttendance, query, "Attendance");
        }

        private void txtAtSearch_Enter(object sender, EventArgs e)
        {
            txtAtSearch.Clear();
        }

        private void btnBuyUnitsSave_Click(object sender, EventArgs e)
        {
            string customerId = txtBId.Text;
            int BuyUnit = 0;
            if (!string.IsNullOrWhiteSpace(txtPurchasedUnit.Text))
            {
                BuyUnit = int.Parse(txtPurchasedUnit.Text.ToString());
            }
            if (txtPurchasedUnit.Text == "" || BuyUnit==0)
            {
                MessageBox.Show("Please Enter value for Buy Units!");
            }
            else {   
                    string q = "if exists ( Select CustomerId From Customer Where  CustomerId='" + customerId + "' ) select CustomerId From Customer  else select '0';";
                    SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
                    cmd.ExecuteScalar();
                    string returnValue = cmd.ExecuteScalar().ToString();
                    if (customerId == "")
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
                            string query1 = "Update Account Set UnitPurchased=UnitPurchased+" + BuyUnit + ";";
                            DB.AddQuery(query1);
                            string query2 = "Insert into SoldUnit(CustomerId,UnitPurchased) VALUES('" + customerId + "'," + BuyUnit + ") ";
                            DB.AddQuery(query2);
                            MessageBox.Show("Units Purchased!");
                            string query = "Select * From SoldUnit;";
                            DB.Binding(dgvAttendance, query, "SoldUnit");
                        }
                    }
            }
            txtBId.Clear();
            txtPurchasedUnit.Clear();
        }

        private void txtPurchasedUnit_Enter(object sender, EventArgs e)
        {
            txtPurchasedUnit.Clear();
        }

        private void txtPurchasedUnit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPurchasedUnit.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPurchasedUnit.Text = txtPurchasedUnit.Text.Remove(txtPurchasedUnit.Text.Length - 1);
            }
        }

        private void txtAId_TextChanged(object sender, EventArgs e)
        {
            if (txtAId.Text != "")
            {
                lblAcn.Text = " ";
            }
            
            string querySearch = "Select * From Attendance where CustomerId like('" + txtAId.Text + "%') AND Date='" + dateBDate.Value.ToString() + "';";
            DB.Binding(dgvAttendance, querySearch, "Attendance");
        }

        private void dateCSearch_ValueChanged(object sender, EventArgs e)
        {
            if (txtAtSearch.Text == "" || txtAtSearch.Text=="Enter ID")
            {
                string query = "Select * From Attendance where Date='" + dateCSearch.Value.ToString() + "';";
                DB.Binding(dgvAttendance, query, "Attendance");
            }
            else
            {
                string query = "Select * From Attendance where Date='" + dateCSearch.Value.ToString() + "' AND CustomerId='" + txtAtSearch.Text + "';";
                DB.Binding(dgvAttendance, query, "Attendance");
            }
            
        }

        private void txtAtSearch_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtAtSearch_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            
            txtSearch.Text = "Enter ID";
        }

        private void dateBDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today.Date;
            if (dateBDate.Value < today || dateBDate.Value > today)
            {
                MessageBox.Show("You are not allowed to select day other than today!" + System.Environment.NewLine + "Note: New Sheet can only be created single time on your system date when you click the button");
                dateBDate.Value = DateTime.Today.Date;
            }
        }
    }
}
