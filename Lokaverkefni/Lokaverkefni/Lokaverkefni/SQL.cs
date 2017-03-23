using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Lokaverkefni
{
    public class SQL
    {
        private SqlConnection connection;

        public SQL()
        {
            string cStr = "data source=v-studentsql.2t.local;initial catalog=TS295750;integrated security=SSPI;persist security info=False;Trusted_Connection=Yes";
            //string cStr = "data source=Robbi-PC\\GSFserver;initial catalog=master;integrated security=SSPI;persist security info=False;Trusted_Connection=Yes";
            this.connection = new SqlConnection(cStr);
        }

        public SQL(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        public bool pantaNafn(int karlar, int konur, int a1, int a2)
        {
            SqlCommand command = new SqlCommand("nofn", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@karlar", SqlDbType.Int).Value = karlar;
            command.Parameters.Add("@konur", SqlDbType.Int).Value = konur;
            command.Parameters.Add("@aldur1", SqlDbType.Int).Value = a1;
            command.Parameters.Add("@aldur2", SqlDbType.Int).Value = a2;
            return this.executeStatement(command);
        }

        public bool baetaStraki(Strakar strakur)
        {
            SqlCommand command = new SqlCommand("baetavidstrakanafni", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nafn", SqlDbType.VarChar).Value = strakur.Nafn;
            command.Parameters.Add("@tidni", SqlDbType.Int).Value = strakur.Tidni1;
            command.Parameters.Add("@ef", SqlDbType.VarChar).Value = strakur.Eignarfall;
            command.Parameters.Add("@ef2", SqlDbType.VarChar).Value = strakur.Eignarfall2;
            return this.executeStatement(command);
        }

        public bool baetaStelpu(Stelpur stelpa)
        {
            SqlCommand command = new SqlCommand("baetavidstelpunafni", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nafn", SqlDbType.VarChar).Value = stelpa.Nafn;
            command.Parameters.Add("@tidni", SqlDbType.Int).Value = stelpa.tidni1;
            return this.executeStatement(command);
        }

        public bool skrastelpuNofn()
        {
            SqlCommand command = new SqlCommand("stelpunofn", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            return this.executeStatement(command);
        }

        public bool skrastrakaNofn()
        {
            SqlCommand command = new SqlCommand("strakanofn", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            return this.executeStatement(command);
        }

        public bool eydaNofn()
        {
            SqlCommand command = new SqlCommand("eydaurnafnogkt", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            return this.executeStatement(command);
        }

        public bool eydaStrakaNafni(string nafn)
        {
            SqlCommand command = new SqlCommand("eydastrakanafni", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nafn", SqlDbType.VarChar).Value = nafn;
            return this.executeStatement(command);
        }

        public bool eydaStelpuNafni(string nafn)
        {
            SqlCommand command = new SqlCommand("eydastelpunafni", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nafn", SqlDbType.VarChar).Value = nafn;
            return this.executeStatement(command);
        }

        public bool faID(Nafn nafn)
        {
            SqlCommand command = new SqlCommand("finnaid", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = nafn.ID;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            try
            {
                nafn.Kennitala = dr.GetString(1);
                nafn.Fulltnafn = dr.GetString(2);
                nafn.Heimilisfang = dr.GetString(3);
                nafn.Postnumer = dr.GetInt32(4);
            }
            catch
            {
                this.connection.Close();

                return false;
            }


            this.connection.Close();
            return true;
        }

        public List<Nafn> faKT(Nafn nafn)
        {
            List<Nafn> nofn = new List<Nafn>();

            SqlCommand command = new SqlCommand("finnakt", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@kt", SqlDbType.Char).Value = nafn.Kennitala;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                nofn.Add(new Nafn(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4)));
            }
            this.connection.Close();

            return nofn;
        }

        public List<Nafn> faHeimilisfang(Nafn nafn)
        {
            List<Nafn> nofn = new List<Nafn>();

            SqlCommand command = new SqlCommand("finnaHeimilisfang", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@hf", SqlDbType.VarChar).Value = nafn.Heimilisfang;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                nofn.Add(new Nafn(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4)));
            }
            this.connection.Close();

            return nofn;
        }

        public List<Nafn> faPostnr(Nafn nafn)
        {
            List<Nafn> nofn = new List<Nafn>();

            SqlCommand command = new SqlCommand("finnaPostnr", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@pn", SqlDbType.VarChar).Value = nafn.Postnumer;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                nofn.Add(new Nafn(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4)));
            }
            this.connection.Close();

            return nofn;
        }

        public List<Nafn> faNafn(Nafn nafn)
        {
            List<Nafn> nofn = new List<Nafn>();

            SqlCommand command = new SqlCommand("finnanafn", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nafn", SqlDbType.VarChar).Value = nafn.Fulltnafn;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                nofn.Add(new Nafn(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4)));
            }
            this.connection.Close();

            return nofn;
        }

        public bool faStrak(Strakar strakur)
        {
            SqlCommand command = new SqlCommand("faStrak", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@strakur", SqlDbType.VarChar).Value = strakur.nafn;     

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            try
            {
                strakur.tidni1 = dr.GetInt32(1);
            }
            catch (Exception)
            {
                this.connection.Close();
                return false;
            }

            this.connection.Close();
            return true;
        }

        public bool faStelpu(Stelpur stelpa)
        {
            SqlCommand command = new SqlCommand("faStelpu", this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@stelpa", SqlDbType.VarChar).Value = stelpa.nafn;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            try
            {
                stelpa.tidni1 = dr.GetInt32(1);
            }
            catch (Exception)
            {
                this.connection.Close();
                return false;
            }

            this.connection.Close();
            return true;
        }

        public bool breytaNafni(string nafn,string nyttnafn, int tidni, int kyn)
        {
            string s = null;
            if (kyn==0)
            {
                s = "breytaStraki";
            }
            else if (kyn == 1)
            {
                s = "breytaStelpu";
            }
            else
            {
                return false;
            }
            SqlCommand command = new SqlCommand(s, this.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nafn", SqlDbType.VarChar).Value = nafn;
            command.Parameters.Add("@nyttnafn", SqlDbType.VarChar).Value = nyttnafn;
            command.Parameters.Add("@tidni", SqlDbType.Int).Value = tidni;
            return this.executeStatement(command);
        }

        public List<Nafn> faNafnalista()
        {
            List<Nafn> nofn = new List<Nafn>();

            SqlCommand command = new SqlCommand("getNafnList", this.connection);
            command.CommandType = CommandType.StoredProcedure;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                nofn.Add(new Nafn(dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetString(3),dr.GetInt32(4)));
            }
            this.connection.Close();

            return nofn;
        }

        public List<Strakar> faStrakaNofn()
        {
            List<Strakar> strakar = new List<Strakar>();

            SqlCommand command = new SqlCommand("faStrakaNofn", this.connection);
            command.CommandType = CommandType.StoredProcedure;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                strakar.Add(new Strakar(dr.GetString(0),dr.GetInt32(1),dr.GetInt32(2),dr.GetString(3),dr.GetString(4)));
            }
            this.connection.Close();

            return strakar;

        }

        public List<Stelpur> faStelpuNofn()
        {
            List<Stelpur> stelpur = new List<Stelpur>();

            SqlCommand command = new SqlCommand("faStelpuNofn", this.connection);
            command.CommandType = CommandType.StoredProcedure;

            this.connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                stelpur.Add(new Stelpur(dr.GetString(0), dr.GetInt32(1), dr.GetInt32(2)));
            }
            this.connection.Close();

            return stelpur;

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
