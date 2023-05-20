using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoViaticos.ConexionSql;

namespace CalculoViaticos.CRUD
{
    public class Alimentacion:ConnectionToSql
    {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Alimentacion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Clear();
                    leer = command.ExecuteReader();
                    table.Load(leer);
                    connection.Close();
                }
            }
            return table;
        }
    }
}
