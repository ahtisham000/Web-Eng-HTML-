using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MessManagemenSystem
{
    class DB
    {
        public static SqlConnection GetConnection()
        {
            string conString = @"Data Source=AHTISHAMSPC/SQLEXPRESS;Initial Catalog=Mess_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                //MessageBox.Show("Ok!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            return con;
        }


        public static void AddMenu(MenuClass menu)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO Menu(Day,BreakFast,Lunch,Dinner) VALUES(@Day,@BreakFast,@Lunch,@Dinner);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Day", menu.day);
            cmd.Parameters.AddWithValue("@BreakFast", menu.breakFast);
            cmd.Parameters.AddWithValue("@Lunch", menu.lunch);
            cmd.Parameters.AddWithValue("@Dinner", menu.dinner);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void AddCustomerData(CustomerClass customer)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO Customer(CustomerId,Name,Address,City,Phone,Gender,DateOfJoin) VALUES(@CustomerId,@Name,@Address,@City,@Phone,@Gender,@DateOfJoin);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@City", customer.City);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Gender", customer.Gender);
            cmd.Parameters.AddWithValue("@DateOfJoin", customer.DateOfJoin);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static void AddEmployeeData(EmployeeClass emp)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO Employee(EmployeeId,Name,CNIC,Phone,Address,City,Gender,JobType,Salary,DateOfJoin) VALUES(@EmployeeId,@Name,@CNIC,@Phone,@Address,@City,@Gender,@JobType,@Salary,@DateOfJoin);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmployeeId", emp.employeeId);
            cmd.Parameters.AddWithValue("@Name", emp.name);
            cmd.Parameters.AddWithValue("@CNIC", emp.cnic);
            cmd.Parameters.AddWithValue("@Address", emp.address);
            cmd.Parameters.AddWithValue("@City", emp.city);
            cmd.Parameters.AddWithValue("@Phone", emp.phone);
            cmd.Parameters.AddWithValue("@Gender", emp.gender);
            cmd.Parameters.AddWithValue("@JobType", emp.jobtype);
            cmd.Parameters.AddWithValue("@Salary", emp.salary);
            cmd.Parameters.AddWithValue("@DateOfJoin", emp.dateOfJoin);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void AddAccount(AccountClass account)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO Account(CustomerId,Name) VALUES(@CustomerId,@Name);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerId", account.customerId);
            cmd.Parameters.AddWithValue("@Name", account.name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void AddSupplier(SupplierClass sup)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO Supplier(SupplierId,Name,CNIC,Phone,Category) VALUES(@SupplierId,@Name,@CNIC,@Phone,@Category);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SupplierId", sup.supplierId);
            cmd.Parameters.AddWithValue("@Name", sup.name);
            cmd.Parameters.AddWithValue("@CNIC", sup.cnic);
            cmd.Parameters.AddWithValue("@Phone", sup.phone);
            cmd.Parameters.AddWithValue("@Category", sup.category);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void AddItem(ItemClass i)
        {
            SqlConnection con = GetConnection();
            string query = "INSERT INTO Item(SupplierId,ItemName,Quantity,Amount,Date) VALUES(@SupplierId,@ItemName,@Quantity,@Amount,@Date);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SupplierId", i.supplierId);
            cmd.Parameters.AddWithValue("@ItemName", i.itemname);
            cmd.Parameters.AddWithValue("@Quantity", i.quantity);
            cmd.Parameters.AddWithValue("@Amount", i.amount);
            cmd.Parameters.AddWithValue("@Date", i.date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        

        public static void AddQuery(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataSet GetDisconnectedData(string query, string table)
        {
            SqlConnection con = GetConnection();
            //string query = "Select * From '"+table+"';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, table);
            return dataSet;
        }

        public static void Binding(DataGridView grid, string query, string table)
        {
            DataSet ds = GetDisconnectedData(query, table);
            grid.DataSource = ds.Tables[table];
        }
    }
}
