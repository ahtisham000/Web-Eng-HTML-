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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string old = txtOld.Text;
            string checkAdminExist = "if exists ( Select LoginId From Admin Where  Password='"+old+"' ) select LoginId From Admin  else select '0';";
            string returnValue = ClassDatabase.RetrieveSingleData(checkAdminExist);

            string New = txtNew.Text;
            string user = txtUser.Text;
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
                    string updatePassword = "Update Admin Set LoginId='"+user+"',Password='"+New+"' WHERE Password='"+old+"';";
                    ClassDatabase.SqlQuery(updatePassword);
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
