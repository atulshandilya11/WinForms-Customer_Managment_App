using BusinessLogicCustomer; 
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Dal
{
    public class CustomerDal

    {
        public bool Add (Customer obj)
        {
            // step 1 open connection
            try { 
            string connstr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerDb;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
            // 2. sql --. command

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
                command.CommandText =
          "INSERT INTO tblCustomer (CustomerName, PhoneNumber, ProductName, BillAmount) " +
          "VALUES (@name, @phone, @product, @amount)";

                command.Parameters.AddWithValue("@name", obj.CustomerName);
                command.Parameters.AddWithValue("@phone", obj.PhoneNumber);
                command.Parameters.AddWithValue("@product", obj.ProductName); 
                command.Parameters.AddWithValue("@amount", obj.BillAmount);

                command.ExecuteNonQuery();
                // 3. close connnection
                conn.Close();
            return true;
            } catch (Exception ex) { return false;
            }
        }
    }
}
