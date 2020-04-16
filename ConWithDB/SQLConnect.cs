using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExample
{
    class SqlConnect
    {
        SqlConnection connection;
        public SqlConnect(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }
        public SqlConnect()
        {
            connection = new SqlConnection(@"Data Source = HUSEYN-BURHONOV\SQLEXPRESS; Initial Catalog = Employees; Integrated Security=true;");
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        public void Get(string str)
        {
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                    Console.Write(sdr[i].ToString() + "\t");
                Console.WriteLine();
            }
        }
        public void Insert(string str)
        {
            SqlCommand command = new SqlCommand(str, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("Data is saved successfully\n");
            else
                Console.WriteLine("Error");
        }
        public void Delete(string str)
        {
            SqlCommand command = new SqlCommand(str, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("Data is deleted successfully");
            else
                Console.WriteLine("Error");
        }
        public void Update(string str)
        {
            SqlCommand command = new SqlCommand(str, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("Data is updated successfully");
            else
                Console.WriteLine("Error in updating");
        }
    }
}