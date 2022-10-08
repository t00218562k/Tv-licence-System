using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tv_Licence
{
    class History
    {
        private int historyId;
        private int cus_Id;
        private String street;
        private String town;
        private String county;
        private String ExpiryDate;
        private double fee;

        public History() 
        {
            historyId = 0;
            cus_Id = 0;
            street = "";
            town = "";
            county = "";
            ExpiryDate = "";
            fee = 0;
        }

        public History(int historyId, int cus_Id, String street, String town, String county, String ExpiryDate, double fee)
        {
            this.historyId = historyId;
            this.cus_Id = cus_Id;
            this.street = street;
            this.town = town;
            this.county = county;
            this.ExpiryDate = ExpiryDate;
            this.fee = fee;
        }

        public void setHistoryId(int historyId)
        {
            this.historyId = historyId;
        }
        public int getHistoryId()
        {
            return historyId;
        }
        public void setCus_Id(int cus_Id)
        {
            this.cus_Id = cus_Id;
        }
        public int getCus_Id()
        {
            return cus_Id;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }
        public String getStreet()
        {
            return street;
        }

        public void setTown(String town)
        {
            this.town = town;
        }
        public String getTowm()
        {
            return town;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }
        public String getCounty()
        {
            return county;
        }

        public void setPurchaseDate(String ExpiryDate)
        {
            this.ExpiryDate = ExpiryDate;
        }
        public String getPurchaseDate()
        {
            return ExpiryDate;
        }

        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public double getFee()
        {
            return fee;
        }

        public static int getNextHistoryId()
        {
            int nextId;


            //Connect to DB;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL query (MAX() func);

            String sqlQuery = "Select Max(HistoryId) From History";


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

        public void addHistory() 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Insert into History Values(" +
                this.historyId + ", " +
                this.cus_Id + ", '" +
                this.street + "', '" +
                this.town + "', '" +
                this.county + "', '" +
                this.ExpiryDate + "', '" +
                this.fee +
                "')";

            //Execute the SQL query  (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public static DataSet findHistory(String street, String Town, String County) 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String sqlQuery = "SELECT Cus_Id, ExpiryDate " +
                "FROM history WHERE Street = '" + street +
                "' AND Town = '" + Town + "' And County = '" + County + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter dr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            dr.Fill(ds, "history");

            conn.Close();
            return ds;        
        }

        public static double revenue(String year, String month)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery;
            double count = 0;

            if (month.Equals("All"))
                sqlQuery = "SELECT COUNT(*) FROM History WHERE SUBSTR(expiryDate, 8) = " + year;
            else
                sqlQuery = "SELECT COUNT(*) FROM History WHERE SUBSTR(expiryDate, 8) = '" + year + "' AND  SUBSTR(expiryDate, 4, 3) = '" + month + "'";

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

                count = double.Parse(row["COUNT(*)"].ToString());

                conn.Close();
                return count;
            }

            conn.Close();
            return 0;
        }


    }
}
