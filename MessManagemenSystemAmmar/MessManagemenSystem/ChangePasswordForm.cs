using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MessManagemenSystem
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string old = txtOld.Text;
            string New = txtNew.Text;
            string user = txtUser.Text;
            string q = "if exists ( Select LoginId From Admin Where  Password='"+old+"' ) select LoginId From Admin  else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (old == "" || New == "" || user == "" )
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue == "0")
                {
                    MessageBox.Show("Old Password Wrong!");
                }
                else
                {
                    string query = "Update Admin Set LoginId='"+user+"',Password='"+New+"' WHERE Password='"+old+"';";
                    DB.AddQuery(query);
                    MessageBox.Show("Password Updated!");
                }
            }
            txtNew.Clear();
            txtOld.Clear();
            txtUser.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
