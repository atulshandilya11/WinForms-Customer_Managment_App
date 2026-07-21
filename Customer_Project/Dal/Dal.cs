using BusinessLogicCustomer; 
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Dal
{
    public class CustomerDal

    {
        public bool Delete(int CustomerId)
        {
            // step 1 open connection
            try
            {
                string connstr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerDb;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                // 2. sql --. command

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Delete from tblCustomer Where CustomerID = @id ";
                command.Parameters.AddWithValue("@id", CustomerId);
                
                command.ExecuteNonQuery();
                // 3. close connnection
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Customer obj, int CustomerId)
        {
            // step 1 open connection
            try
            {
                string connstr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerDb;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                // 2. sql --. command

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText =
                "UPDATE tblCustomer " +
                "SET CustomerName = @name, " +
                "PhoneNumber = @phone, " +
                "ProductName = @product, " +
                "BillAmount = @amount " +
                "WHERE CustomerID = @id";

                command.Parameters.AddWithValue("@name", obj.CustomerName);
                command.Parameters.AddWithValue("@phone", obj.PhoneNumber);
                command.Parameters.AddWithValue("@product", obj.ProductName);
                command.Parameters.AddWithValue("@amount", obj.BillAmount);
                command.Parameters.AddWithValue("@id", CustomerId);
                command.ExecuteNonQuery();
                // 3. close connnection
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
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
        public DataSet Read()
        {
            // step 1 open connection
            try
            {
                string connstr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerDb;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                // 2. sql --. command

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT CustomerID,CustomerName,PhoneNumber,BillAmount,ProductName FROM tblCustomer";

                //command.ExecuteNonQuery();
                // Dataset and dataadapter
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet Customers = new DataSet();
                adapter.Fill(Customers);

                // 3. close connnection
                conn.Close();
                return Customers;
            }
            catch (Exception ex)
            {
                return null;
            }
        

        }
    }
}
