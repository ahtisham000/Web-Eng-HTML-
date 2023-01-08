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
    public partial class UIMenu : UserControl
    {
       

        public UIMenu()
        {
            InitializeComponent();
        }

        ClassMenu menu = new ClassMenu();
        private void MenuFields()
        {
            menu.day = txtDay.Text;
            menu.breakFast = txtMBreakFast.Text;
            menu.dinner = txtMDinner.Text;
            menu.lunch = txtMLunch.Text;
        }
        //save Menu Record
        private void btnMSave_Click(object sender, EventArgs e)
        {
            MenuFields();
            string checkDayExistQuery = "if exists ( Select Day From Menu Where  Day='" + menu.day + "' ) select Day From Menu  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkDayExistQuery);
            if (menu.day == "" || menu.breakFast== "" || menu.lunch == "" || menu.dinner == "" )
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
                    ClassDatabase.AddMenu(menu);
                    MessageBox.Show("Menu Saved!");
                }
            }
        }

        // Delete Menu Record
        private void btnmDelete_Click(object sender, EventArgs e)
        {
            MenuFields();
            string checkDayExistQuery = "if exists ( Select Day From Menu Where  Day='" + menu.day + "' ) select Day From Menu  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkDayExistQuery);

            if (returnValue == "0")
            {
                MessageBox.Show("Day Does Not Exist!");
            }
            else
            {
                string query = "Delete From Menu Where day='" + menu.day+ "';";
                ClassDatabase.SqlQuery(query);
                MessageBox.Show("Record of day '"+menu.day+"' Deleted!");
            }
        }

        // Update Menu Record
        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            MenuFields();
            string checkDayExistQuery = "if exists ( Select Day From Menu Where  Day='" + menu.day + "' ) select Day From Menu  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkDayExistQuery);

            if (returnValue == "0")
            {
                MessageBox.Show("Day Does Not Exist!");
            }
            else
            {
                string query = "Update Menu Set BreakFast='"+menu.breakFast+"',Lunch='"+menu.lunch+"',Dinner='"+menu.dinner+"' Where day='" + menu.day + "';";
                ClassDatabase.SqlQuery(query);
                MessageBox.Show("Record of day '" + menu.day + "' Updated!");
            }
        }

        // show Menu record on click
        private void btnMenu_Click(object sender, EventArgs e)
        {
            string showMenuQuery = "Select * FROM Menu;";
            ClassDatabase.Binding(dgvMenu, showMenuQuery, "Menu");
            string showMenuInOrderQuery = "Select * from menu Order by DayId;";
            ClassDatabase.Binding(dgvMenu, showMenuInOrderQuery, "Menu");
        }

        // Clear Fields on click
        private void btnMClear_Click(object sender, EventArgs e)
        {
            txtDay.Clear();
            txtMBreakFast.Clear();
            txtMDinner.Clear();
            txtMLunch.Clear();
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
