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
    public partial class UIAttendance : UserControl
    {
        public UIAttendance()
        {
            InitializeComponent();
        }

     
        // creating new on the today date
        private void btnNewSheet_Click(object sender, EventArgs e)
        {
            

            string checkDateExistQuery = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' ) select Date From Attendance  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkDateExistQuery); 

            if (returnValue != "0")
            {
                MessageBox.Show("Sheet Already Exist!");
            }
            else
            {
                string saveAttendanceQuery = "Insert into Attendance(CustomerId) SELECT CustomerId FROM Customer;";
                ClassDatabase.SqlQuery(saveAttendanceQuery);
                string selectAttendRecordQuery = "Select * From Attendance;";
                ClassDatabase.Binding(dgvAttendance, selectAttendRecordQuery, "Attendance");
                MessageBox.Show("Sheet Created for Date '" + dateBDate.Value.ToString() + "'");
            }
        }

        // prohibiting user to create another sheet on same date
        private void dateBDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today.Date;
            if (dateBDate.Value < today || dateBDate.Value > today)
            {
                MessageBox.Show("You are not allowed to select day other than today!" + System.Environment.NewLine + "Note: New Sheet can only be created single time on your system date when you click the button");
                dateBDate.Value = DateTime.Today.Date;
            }
        }

      
        // marking attendance of breakfast
        private void btnBreakFast_Click(object sender, EventArgs e)
        {
            string customerId = txtAId.Text;
            string checkCustBalance = "if exists ( Select UnitPurchased From Account Where  UnitPurchased < 1 AND CustomerId='" + customerId + "'  ) select UnitPurchased From Account  else select '-1';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkCustBalance);

            if (returnValue == "-1")
            {

                string checkCustExistOnDate = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' AND CustomerId='" + customerId + "') select Date From Attendance  else select '0';";
                string returnValue1 = ClassDatabase.RetrieveSingleData(checkCustExistOnDate);

                if (returnValue1 == "0")
                {
                    MessageBox.Show("Invalid!");
                }
                else
                {
                    string updateBreakfast = "Update Attendance  SET BreakFast=BreakFast+" + 1 + ",TotalUnits=TotalUnits+"+1+" Where CustomerId='" + customerId + "'AND Date='" + dateBDate.Value.ToString() + "' ;";
                    ClassDatabase.SqlQuery(updateBreakfast);
                    string updateUnitPurchase = "Update Account SET UnitPurchased=UnitPurchased-" + 1 + "Where CustomerId='" + customerId + "';";
                    ClassDatabase.SqlQuery(updateUnitPurchase);
                    string updateUnitConsume = "Update Account SET UnitConsumed=UnitConsumed+" + 1 + "Where CustomerId='" + customerId + "';";
                    ClassDatabase.SqlQuery(updateUnitConsume);
                    string selectAttendRecord = "Select * From Attendance;";
                    ClassDatabase.Binding(dgvAttendance, selectAttendRecord, "Attendance");
                    lblAcn.Text = "Attendance Marked!";
                }
            }
            else
            {
                MessageBox.Show("NO Balance");
            }
            txtAId.Clear();
        }

        // marking attendance of Lunch
        private void btnLunch_Click(object sender, EventArgs e)
        {
            string customerId = txtAId.Text;
            string checkCustExistOnDate = "if exists ( Select UnitPurchased From Account Where  UnitPurchased < 1 AND CustomerId='" + customerId + "'  ) select UnitPurchased From Account  else select '-1';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkCustExistOnDate);

            if (returnValue == "-1")
            {

                string q1 = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' AND CustomerId='" + customerId + "') select Date From Attendance  else select '0';";
                SqlCommand cmd1 = new SqlCommand(q1, ClassDatabase.GetConnection());
                cmd1.ExecuteScalar();
                string returnValue1 = cmd1.ExecuteScalar().ToString();

                if (returnValue1 == "0")
                {
                    MessageBox.Show("Invalid!");
                }
                else
                {
                    string updateLunch = "Update Attendance  SET Lunch=Lunch+" + 1 + ",TotalUnits=TotalUnits+" + 1 + " Where CustomerId='" + customerId + "'AND Date='" + dateBDate.Value.ToString() + "' ;";
                    ClassDatabase.SqlQuery(updateLunch);
                    string updateUnitPurchase = "Update Account SET UnitPurchased=UnitPurchased-" + 1 + "Where CustomerId='" + customerId + "';";
                    ClassDatabase.SqlQuery(updateUnitPurchase);
                    string updateUnitConsume = "Update Account SET UnitConsumed=UnitConsumed+" + 1 + "Where CustomerId='" + customerId + "';";
                    ClassDatabase.SqlQuery(updateUnitConsume);
                    string selectAttendRecord = "Select * From Attendance;";
                    ClassDatabase.Binding(dgvAttendance, selectAttendRecord, "Attendance");
                    lblAcn.Text = "Attendance Marked!";
                }
            }
            else
            {
                MessageBox.Show("NO Balance");
            }
            txtAId.Clear();
        }

        // marking attendance of Dinner
        private void btnDinner_Click(object sender, EventArgs e)
        {
            string customerId = txtAId.Text;
            string checkCustExistOnDate = "if exists ( Select UnitPurchased From Account Where  UnitPurchased < 1 AND CustomerId='" + customerId + "'  ) select UnitPurchased From Account  else select '-1';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkCustExistOnDate);

            if (returnValue == "-1")
            {

                string q1 = "if exists ( Select Date From Attendance Where  Date='" + dateBDate.Value.ToString() + "' AND CustomerId='" + customerId + "') select Date From Attendance  else select '0';";
                SqlCommand cmd1 = new SqlCommand(q1, ClassDatabase.GetConnection());
                cmd1.ExecuteScalar();
                string returnValue1 = cmd1.ExecuteScalar().ToString();

                if (returnValue1 == "0")
                {
                    MessageBox.Show("Invalid!");
                }
                else
                {
                    string updateDinner = "Update Attendance  SET Dinner=Dinner+" + 1 + ",TotalUnits=TotalUnits+" + 1 + " Where CustomerId='" + customerId + "'AND Date='" + dateBDate.Value.ToString() + "' ;";
                    ClassDatabase.SqlQuery(updateDinner);
                    string updateUnitPurchase = "Update Account SET UnitPurchased=UnitPurchased-" + 1 + "Where CustomerId='" + customerId + "';";
                    ClassDatabase.SqlQuery(updateUnitPurchase);
                    string updateUnitConsume = "Update Account SET UnitConsumed=UnitConsumed+" + 1 + "Where CustomerId='" + customerId + "';";
                    ClassDatabase.SqlQuery(updateUnitConsume);
                    string selectAttendRecord = "Select * From Attendance;";
                    ClassDatabase.Binding(dgvAttendance, selectAttendRecord, "Attendance");
                    lblAcn.Text = "Attendance Marked!";
                }
            }
            else
            {
                MessageBox.Show("NO Balance");
            }
            txtAId.Clear();
        }

        // showing all attendance record on click button
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            string selectAttendRecordQuery = "Select * From Attendance;";
            ClassDatabase.Binding(dgvAttendance, selectAttendRecordQuery, "Attendance");
            string selectRecordInOrder = "Select * From Attendance ORDER BY Date DESC;";
            ClassDatabase.Binding(dgvAttendance, selectRecordInOrder, "Attendance");
        }

        // searching attendace record on basic of Customer ID
        private void txtAtSearch_TextChanged(object sender, EventArgs e)
        {
            string selectAttendOfCustomer = "Select * From Attendance where CustomerId like('" + txtAtSearch.Text + "%');";
            ClassDatabase.Binding(dgvAttendance, selectAttendOfCustomer, "Attendance");
        }

        // Showing attendance record on basic of date and ID
        private void txtAId_TextChanged(object sender, EventArgs e)
        {
            if (txtAId.Text != "")
            {
                lblAcn.Text = " ";
            }

            string querySearch = "Select * From Attendance where CustomerId like('" + txtAId.Text + "%') AND Date='" + dateBDate.Value.ToString() + "';";
            ClassDatabase.Binding(dgvAttendance, querySearch, "Attendance");
        }

        // showing attendance record on basis of date or ID
        private void dateCSearch_ValueChanged(object sender, EventArgs e)
        {
            if (txtAtSearch.Text == "" || txtAtSearch.Text == "Enter ID")
            {
                string query = "Select * From Attendance where Date='" + dateCSearch.Value.ToString() + "';";
                ClassDatabase.Binding(dgvAttendance, query, "Attendance");
            }
            else
            {
                string query = "Select * From Attendance where Date='" + dateCSearch.Value.ToString() + "' AND CustomerId='" + txtAtSearch.Text + "';";
                ClassDatabase.Binding(dgvAttendance, query, "Attendance");
            }

        }

        // clearing attendace search field on mouse enter
        private void txtAtSearch_Enter(object sender, EventArgs e)
        {
            txtAtSearch.Clear();
        }


        //  Bought unit saving
        private void btnBuyUnitsSave_Click(object sender, EventArgs e)
        {
 
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
                string customerId = txtBId.Text;
                string checkCustomerExist = "if exists ( Select CustomerId From Customer Where  CustomerId='" + customerId + "' ) select CustomerId From Customer  else select '0';";
                    string returnValue = ClassDatabase.RetrieveSingleData(checkCustomerExist);
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
                            string updatePurchaseOfAct = "Update Account Set UnitPurchased=UnitPurchased+" + BuyUnit + ";";
                            ClassDatabase.SqlQuery(updatePurchaseOfAct);
                            string buyingUnit = "Insert into SoldUnit(CustomerId,UnitPurchased) VALUES('" + customerId + "'," + BuyUnit + ") ";
                            ClassDatabase.SqlQuery(buyingUnit);
                            MessageBox.Show("Units Purchased!");
                            string selectRcdSoldUnit = "Select * From SoldUnit;";
                            ClassDatabase.Binding(dgvAttendance, selectRcdSoldUnit, "SoldUnit");
                        }
                    }
            }
            txtBId.Clear();
            txtPurchasedUnit.Clear();
        }

        //clear field on mouse enter
        private void txtPurchasedUnit_Enter(object sender, EventArgs e)
        {
            txtPurchasedUnit.Clear();
        }

        // force inpuut field to accpet only intergers
        private void txtPurchasedUnit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPurchasedUnit.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPurchasedUnit.Text = txtPurchasedUnit.Text.Remove(txtPurchasedUnit.Text.Length - 1);
            }
        }

        // showing all customer account record on clicking button
        private void btnAccount_Click(object sender, EventArgs e)
        {
            string selectActRecord = "Select * From Account;";
            ClassDatabase.Binding(dgvAttendance, selectActRecord, "Account");
        }

        // searching customer account record on basis of Customer_ID
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string selectCustomerAct = "Select * From Account where CustomerId like('" + txtSearch.Text + "%');";
            ClassDatabase.Binding(dgvAttendance, selectCustomerAct, "Account");
        }

        // clearing account field on mouse enter in text field
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        // fill text field with "Enter ID" text on leaving mouse this field
        private void txtSearch_Leave(object sender, EventArgs e)
        {

            txtSearch.Text = "Enter ID";
        }

    }
}
