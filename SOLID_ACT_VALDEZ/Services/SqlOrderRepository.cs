using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SOLID_ACT_VALDEZ.Models;
using SOLID_ACT_VALDEZ.Service;

namespace SOLID_ACT_VALDEZ.Services
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly string connectionString;

        public SqlOrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Save(Order order)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("INSERT INTO Orders (Email, Total) VALUES(@e, @t)", conn))
                {
                    cmd.Parameters.AddWithValue("@e", order.CustomerEmail);
                    cmd.Parameters.AddWithValue("@t", order.Total);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
