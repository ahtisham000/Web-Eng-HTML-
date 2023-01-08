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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;

            string q = "if exists ( Select LoginId From Admin Where  LoginId='"+name+"' AND Password='"+password+"' ) select LoginId From Admin else select '0';";
            SqlCommand cmd = new SqlCommand(q, DB.GetConnection());
            cmd.ExecuteScalar();
            string returnValue = cmd.ExecuteScalar().ToString();
            if (name == "" || password == "" )
            {
                MessageBox.Show("Please Enter All the Data Fields!");
            }
            else
            {
                if (returnValue == "0")
                {
                    MessageBox.Show("UserName or Password Wrong!");
                }
                else
                {
                    new Form2().Show();
                }
            }
            txtName.Clear();
            txtPassword.Clear();
            
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.Show();
        }
    }
}
