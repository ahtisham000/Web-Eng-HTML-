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
using System.Windows.Forms.DataVisualization.Charting;
//using System.Web.UI.DataVisualization.Charting;
namespace MessManagemenSystem
{
    public partial class Statistics : UserControl
    {
        
        public Statistics()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            chartProfitLoss.Series["Sale"].Points.Clear();
            chartProfitLoss.Series["Purchase"].Points.Clear();
            chartPie.Series["Sale"].Points.Clear();
            chartProfitLoss.Titles.Clear();
            chartPie.Titles.Clear();
            btnSale.Text = "0";
            btnPurchase.Text = "0";
            btnSell.Text = "0";
            btnUnitCon.Text = "0";

            DateTime ds = DateTime.Parse(dateStart.Value.ToString());
            DateTime de = DateTime.Parse(dateEnd.Value.ToString());
            if (dateEnd.Value.Date < dateStart.Value.Date)
            {
                MessageBox.Show("DateEnd can't be lower than DateStart");
            }
            int Unit = 0;
            if (!string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                Unit = int.Parse(txtUnitPrice.Text.ToString());
            }
            if (Unit == 0 || txtUnitPrice.Text=="")
            {
                MessageBox.Show("Enter Unit Price!");
            }
            else
            {
                string query = "Select Sum(TotalUnits) From Attendance Where Date Between '" + ds + "' AND '" + de + "'";
                SqlCommand cmd = new SqlCommand(query, DB.GetConnection());
                cmd.ExecuteScalar();
                string returnValue = cmd.ExecuteScalar().ToString();
                
                if (returnValue == "")
                {
                    returnValue = "0";
                }
                else
                {
                    btnUnitCon.Text = returnValue;
                }
               

                string query1 = "Select Sum(TotalUnits)*" +Unit+ " From Attendance Where Date Between '" + ds + "' AND '" + de + "'";
                SqlCommand cmd1 = new SqlCommand(query1, DB.GetConnection());
                cmd1.ExecuteScalar();
                string returnValue1 = cmd1.ExecuteScalar().ToString();
                if (returnValue1 == "")
                {
                    returnValue1 = "0";
                }
                else{
                    btnSale.Text = returnValue1;
                }




                string query2 = "Select Sum(Amount) From Item Where Date Between '" + ds + "' AND '" + de + "'";
                SqlCommand cmd2 = new SqlCommand(query2, DB.GetConnection());
                cmd2.ExecuteScalar();
                string returnValue2 = cmd2.ExecuteScalar().ToString();
                
                if (returnValue2 == "")
                {
                    returnValue2 = "0";
                }
                else
                {
                    btnPurchase.Text = returnValue2;
                }


                string query3 = "Select Sum(UnitPurchased) From SoldUnit Where Date Between '" + ds + "' AND '" + de + "'";
                SqlCommand cmd3 = new SqlCommand(query3, DB.GetConnection());
                cmd3.ExecuteScalar();
                string returnValue3 = cmd3.ExecuteScalar().ToString();
                
                if (returnValue3 == "")
                {
                    returnValue3 = "0";
                }
                else
                {
                    btnSell.Text = returnValue3;
                }
               

               

               int sale=0 ;
               int purchase=0;
               int consumed=0;
               int sold=0;
               if (!string.IsNullOrWhiteSpace(returnValue) || !string.IsNullOrWhiteSpace(returnValue1) || !string.IsNullOrWhiteSpace(returnValue2) || !string.IsNullOrWhiteSpace(returnValue3))
               {
                   sale = int.Parse(returnValue1);
                   purchase = int.Parse(returnValue2);

                   consumed = int.Parse(returnValue);
                   sold = int.Parse(returnValue3);
               }
               
                
                 
                   chartProfitLoss.Series["Sale"].Points.AddXY("", sale);
                   chartProfitLoss.Series["Purchase"].Points.AddXY("", purchase);
                   chartProfitLoss.Titles.Add("Profit Loss Chart");

                   chartPie.Series["Sale"].Points.AddXY("Sold", sold);
                   chartPie.Series["Sale"].Points.AddXY("Consumed", consumed);
                   chartPie.Titles.Add("Units Record Chart");
                    

                
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUnitPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtUnitPrice.Text = txtUnitPrice.Text.Remove(txtUnitPrice.Text.Length - 1);
            }
        }
    }
}
