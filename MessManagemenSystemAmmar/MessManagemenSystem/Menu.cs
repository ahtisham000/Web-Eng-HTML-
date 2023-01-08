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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMSave_Click(object sender, EventArgs e)
        {
            string day = txtDay.Text;
            string breakFast = txtMBreakFast.Text;
            string lunch = txtMLunch.Text;
            string dinner = txtMDinner.Text;

            string q = "if exists ( Select Day From Menu Where  Day='" + day + "' ) select Day From Menu  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (day == "" || breakFast == "" || lunch == "" || dinner == "" )
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue != "0")
                {
                    MessageBox.Show("Day Exist!");
                }
                else
                {
                    DB.AddMenu(new MenuClass(day,breakFast,lunch,dinner));
                    MessageBox.Show("Menu Saved!");
                }
            }
        }

        private void btnmDelete_Click(object sender, EventArgs e)
        {
            string day = txtDay.Text;
            string q = "if exists ( Select Day From Menu Where  Day='" + day + "' ) select Day From Menu  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {
                MessageBox.Show("Day Does Not Exist!");
            }
            else
            {
                string query = "Delete From Menu Where day='" + day+ "';";
                DB.AddQuery(query);
                MessageBox.Show("Record of day '"+day+"' Deleted!");
            }
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            string day = txtDay.Text;
            string breakFast = txtMBreakFast.Text;
            string lunch = txtMLunch.Text;
            string dinner = txtMDinner.Text;
            string q = "if exists ( Select Day From Menu Where  Day='" + day + "' ) select Day From Menu  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();

            if (returnValue == "0")
            {
                MessageBox.Show("Day Does Not Exist!");
            }
            else
            {
                string query = "Update Menu Set BreakFast='"+breakFast+"',Lunch='"+lunch+"',Dinner='"+dinner+"' Where day='" + day + "';";
                DB.AddQuery(query);
                MessageBox.Show("Record of day '" + day + "' Updated!");
            }
            txtDay.Clear();
            txtMBreakFast.Clear();
            txtMDinner.Clear();
            txtMLunch.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string query = "Select * FROM Menu;";
            DB.Binding(dgvMenu, query, "Menu");
            string query2 = "Select * from menu Order by DayId;";
            DB.Binding(dgvMenu, query2, "Menu");
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMenu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDay.Text = this.dgvMenu.CurrentRow.Cells[1].Value.ToString();
            txtMBreakFast.Text = this.dgvMenu.CurrentRow.Cells[2].Value.ToString();
            txtMLunch.Text = this.dgvMenu.CurrentRow.Cells[3].Value.ToString();
            txtMDinner.Text = this.dgvMenu.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
