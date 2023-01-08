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
namespace MessManagemenSystem
{
    public partial class UIStatistics : UserControl
    {
        
        public UIStatistics()
        {
            InitializeComponent();
        }

        // Clear Old values of chart 
        private void clearOldValueChart()
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
        }

        // Add New values of chart 
        private void addNewValueChart(string sale, string purchase, string consumed, string sold)
        {
            int chartSale = 0;
            int chartPurchase = 0;
            int chartConsumed = 0;
            int chartSold = 0;
            if (!string.IsNullOrWhiteSpace(consumed) || !string.IsNullOrWhiteSpace(sale) || !string.IsNullOrWhiteSpace(purchase) || !string.IsNullOrWhiteSpace(sold))
            {
                chartSale = int.Parse(sale);
                chartPurchase = int.Parse(purchase);

                chartConsumed = int.Parse(consumed);
                chartSold = int.Parse(sold);
            }

            chartProfitLoss.Series["Sale"].Points.AddXY("", chartSale);
            chartProfitLoss.Series["Purchase"].Points.AddXY("", chartPurchase);
            chartProfitLoss.Titles.Add("Profit Loss Chart");

            chartPie.Series["Sale"].Points.AddXY("Sold", chartSold);
            chartPie.Series["Sale"].Points.AddXY("Consumed", chartConsumed);
            chartPie.Titles.Add("Units Record Chart");


        }

        // showing Record of statistics
        private void btnShow_Click(object sender, EventArgs e)
        {
            // removing old values of chart
            clearOldValueChart();

            DateTime startDate = DateTime.Parse(dateStart.Value.ToString());
            DateTime endDate = DateTime.Parse(dateEnd.Value.ToString());
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
                string checkConsumedUnitQuery = "Select Sum(TotalUnits) From Attendance Where Date Between '" + startDate + "' AND '" + endDate + "'";
                string consumedUnits = ClassDatabase.RetrieveSingleData(checkConsumedUnitQuery);
                
                if (consumedUnits == "")
                {
                    consumedUnits = "0";
                }
                else
                {
                    btnUnitCon.Text = consumedUnits;
                }


                string checkSoldUnitQuery = "Select Sum(UnitPurchased) From SoldUnit Where Date Between '" + startDate + "' AND '" + endDate + "'";
                string soldUnits = ClassDatabase.RetrieveSingleData(checkSoldUnitQuery);

                if (soldUnits == "")
                {
                    soldUnits = "0";
                }
                else
                {
                    btnSell.Text = soldUnits;
                }

                string checkSaleAmountQuery = "Select Sum(TotalUnits)*" +Unit+ " From Attendance Where Date Between '" + startDate + "' AND '" + endDate + "'";
                string sale = ClassDatabase.RetrieveSingleData(checkSaleAmountQuery);
                if (sale == "")
                {
                    sale = "0";
                }
                else{
                    btnSale.Text = sale;
                }




                string checkPurchAmountQuery = "Select Sum(Amount) From Item Where Date Between '" + startDate + "' AND '" + endDate + "'";
                string purchase = ClassDatabase.RetrieveSingleData(checkPurchAmountQuery);

                if (purchase == "")
                {
                    purchase = "0";
                }
                else
                {
                    btnPurchase.Text = purchase;
                }

                //adding new values to the chart
               addNewValueChart(sale,purchase,consumedUnits,soldUnits);
                
            }
        }


       //forcing user to enter only integer in the input field for unit price
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
