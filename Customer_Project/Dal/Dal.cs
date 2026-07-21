using BusinessLogicCustomer; 
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Data;
namespace Dal
{
    public class CustomerDal

    {
        public SqlConnection CreateConnection()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            return conn;
        }
        public bool Delete(int CustomerId)
        {
            // step 1 open connection
            try
            {
                SqlConnection conn = CreateConnection();
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
                SqlConnection conn = CreateConnection();

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
                SqlConnection conn = CreateConnection();

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
                SqlConnection conn = CreateConnection();

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
