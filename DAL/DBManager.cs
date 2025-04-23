using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBManager
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;


        public DBManager()
        {
            connection = new SqlConnection("Data Source=.;Initial Catalog=ECommerceWin;Integrated Security=True;Trust Server Certificate=True");
        }

        public DataTable ExecuteDataTable (string cmd)
        {
            command = new SqlCommand(cmd, connection);  
            adapter = new SqlDataAdapter(command);  
            dt = new DataTable();
            adapter.Fill(dt);   
            return dt;
        }

        public int ExecuteNonQuery (string cmd, Dictionary<string, object> dict)
        {
            command = new SqlCommand (cmd, connection);
            
            foreach(var para in dict)
            {
                command.Parameters.Add(new SqlParameter(para.Key, para.Value));
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }
    }
}
