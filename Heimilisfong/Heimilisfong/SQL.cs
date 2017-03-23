using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;

namespace Heimilisfong
{
    public class SQL
    {
        private SqlConnection connection;

        public SQL()
        {
            //string cStr = "data source=v-studentsql.2t.local;initial catalog=TS295750;integrated security=SSPI;persist security info=False;Trusted_Connection=Yes";
            string cStr = "data source=Robbi-PC\\GSFserver;initial catalog=master;integrated security=SSPI;persist security info=False;Trusted_Connection=Yes";
            this.connection = new SqlConnection(cStr);
        }

        public SQL(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }


        public bool skraGotur(Address address)
        {
            SqlCommand command = new SqlCommand("newStreet", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@postnumer", SqlDbType.Int).Value = address.Postnumer;
            command.Parameters.Add("@heitinf", SqlDbType.VarChar).Value = address.Nefnifall;
            command.Parameters.Add("@heitithf", SqlDbType.VarChar).Value = address.Thagufall;

            return this.executeStatement(command);
        }


        private bool executeStatement(SqlCommand command)
        {
            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                command = null;
                this.connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }  
}
