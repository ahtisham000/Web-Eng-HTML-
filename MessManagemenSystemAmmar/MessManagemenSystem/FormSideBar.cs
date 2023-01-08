using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessManagemenSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCustomer.Height;
            SidePanel.Top = btnCustomer.Top;
            customer1.BringToFront();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAttendence.Height;
            SidePanel.Top = btnAttendence.Top;
            attendance1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEmployee.Height;
            SidePanel.Top = btnEmployee.Top;
            employee1.BringToFront();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPayment.Height;
            SidePanel.Top = btnPayment.Top;
            payment1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnStatistics.Height;
            SidePanel.Top = btnStatistics.Top;
            statistics1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            menu1.BringToFront();
        }
    }
}
