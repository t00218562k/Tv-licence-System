using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Tv_Licence
{
    class Customer
    {
        private int cusId;
        private String firstName;
        private String lastName;
        private String email;

        public Customer() 
        {
            cusId = 0;
            firstName = "";
            lastName = "";
            email = "";
        }

        public Customer(int cusId, String firstName, String lastName, String email) 
        {
            this.cusId = cusId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public void setCusId(int cusId)
        {
            this.cusId = cusId;
        }
        public int getCusId()
        {
            return cusId;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getFirstName()
        {
            return firstName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String getLastName()
        {
            return lastName;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        public String geTEmail()
        {
            return email;
        }

        public static int getNextCusId()
        {
            int nextId;


            //Connect to DB;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL query (MAX() func);

            String sqlQuery = "Select Max(CusId) From Customer";


            //Execute SQL query (OracleCommand);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Check if MAx value is null or not;
            dr.Read();
            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }
            //close connection;

            conn.Close();
            //return a value to C# app;
            return nextId;
        }

        public void addCustomer()
        {
            //Open Connection;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL querry to be executed
            String sqlQuery = "Insert Into Customer Values(" +
                this.cusId + " , '" +
                this.firstName + "' , '" +
                this.lastName + "' , '" +
                this.email + "')";

            //Execute the SQL query  (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();

        }

        public static Boolean findCustomer(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Customer WHERE CusId = " + id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                return true;
            }

            conn.Close();
            return false;
        }

        public static DataSet customerInfo(int id) 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            DataSet ds = new DataSet();

            String sqlQueryOne = "SELECT * FROM customer FULL JOIN Licence ON Customer.CusId=Licence.Cus_Id WHERE CusId = " + id;

            OracleCommand cmdOne = new OracleCommand(sqlQueryOne, conn);

            OracleDataAdapter dr = new OracleDataAdapter(cmdOne);

            dr.Fill(ds, "Customer");

            conn.Close();

            return ds;
        }

        public static int findCustomerId(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM licence WHERE licenceId = " + id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                OracleDataAdapter dr2 = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                dr2.Fill(ds, "licence");

                DataTable dt = ds.Tables["licence"];

                DataRow row = dt.Rows[0];

                int liciD = Int32.Parse(row["Cus_Id"].ToString());

                conn.Close();
                return liciD;
            }

            conn.Close();
            return 0;
        }
    }
}
