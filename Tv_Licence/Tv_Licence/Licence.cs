using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Tv_Licence
{
    class Licence
    {
        private int licenceId;
        private int cus_Id;
        private String street;
        private String town;
        private String county;
        private String expiryDate;
        private double fee;
        private String stat;

        public Licence()
        {
            licenceId = 0;
            cus_Id = 0;
            street = "";
            town = "";
            county = "";
            expiryDate = "";
            fee = 0;
            stat = "";
        }

        public Licence(int licenceId, int cus_Id, String street, String town, String county, String expiryDate, double fee, String stat)
        {
            this.licenceId = licenceId;
            this.cus_Id = cus_Id;
            this.street = street;
            this.town = town;
            this.county = county;
            this.expiryDate = expiryDate;
            this.fee = fee;
            this.stat = stat;
        }

        public void setLicenceId(int licenceId)
        {
            this.licenceId = licenceId;
        }
        public int getLicenceId()
        {
            return licenceId;
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

        public void setExpiryDate(String expiryDate)
        {
            this.expiryDate = expiryDate;
        }
        public String getExpiryDate()
        {
            return expiryDate;
        }

        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public double getFee()
        {
            return fee;
        }

        public void setStat(String stat) 
        {
            this.stat = stat;
        }
        public String getStat() 
        {
            return stat;
        }

        public static int getNextLicenceId()
        {
            int nextId;

            //Connect to DB;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL query (MAX() func);
            String sqlQuery = "Select Max(LicenceId) From Licence";

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

        public void addLicence()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Insert into Licence Values(" +
                this.licenceId + ", " +
                this.cus_Id + ", '" +
                this.street + "', '" +
                this.town + "', '" +
                this.county + "', '" +
                this.expiryDate + "', '" +
                this.fee + "', '"+
                this.stat + "')";


            //Execute the SQL query  (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public static double getCurrentFee() 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Fee FROM CurrentFee WHERE StartDate = (SELECT Max(StartDate) FROM CurrentFee)"; 

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                OracleDataAdapter dr2 = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                dr2.Fill(ds, "CurrentFee");

                DataTable dt = ds.Tables["CurrentFee"];

                DataRow row = dt.Rows[0];

                double liciD = double.Parse(row["Fee"].ToString());

                conn.Close();
                return liciD;
            }

            conn.Close();
            return 0;
        }

        public static int findLicenceId(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM licence WHERE Cus_Id = " + id;

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

                int liciD = Int32.Parse(row["LicenceId"].ToString()); 
                
                conn.Close();
                return liciD;
            }

            conn.Close();
            return 0;
        }

        public static void transferLicence(int id, String street,String town, String county) 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String sqlQuery = "UPDATE licence SET" +
                " street = '" + street + 
                "', town = '" + town +
                "', county = '" + county +
                "' WHERE LicenceId = " + findLicenceId(id);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void cancelLicence(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
           
            String sqlQuery = "UPDATE licence SET Stat = '" + "Cancelled" + "' WHERE LicenceId = " + id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void renewLicence(int id, String fName, String lName, String email) 
        {
            String expDate = (DateTime.Now.AddYears(1)).ToString("dd-MMM-yy");

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM licence WHERE Cus_id = " + id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataAdapter dr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            dr.Fill(ds, "His");

            DataTable dt = ds.Tables["His"];

            DataRow row = dt.Rows[0];

            int cusId = Int32.Parse(row["Cus_id"].ToString());

            String street = row["Street"].ToString();

            String town = row["Town"].ToString();

            String county = row["County"].ToString();

            String expiryDate = row["ExpiryDate"].ToString();

            double fee = double.Parse(row["Fee"].ToString());

            int hisId = History.getNextHistoryId();

            History history = new History(hisId, cusId, street, town, county, expiryDate, fee);
            history.addHistory();

            conn.Close();

            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);

            String sqlQuery2 = "UPDATE Customer SET" +
                " firstname = '" + fName +
                "', lastname = '" + lName +
                "', email = '" + email +
                "' WHERE cusId = " + id;

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn2);

            conn2.Open();

            cmd2.ExecuteNonQuery();

            conn2.Close();


            OracleConnection conn3 = new OracleConnection(DBConnect.oradb);

            String sqlQuery3 = "UPDATE licence SET" +
                " ExpiryDate = '" + expDate +
                "', Fee = " + Licence.getCurrentFee() + 
                ", Stat = '" + "Valid" +
                "' WHERE LicenceId = " + findLicenceId(id);

            OracleCommand cmd3 = new OracleCommand(sqlQuery3, conn3);
            conn3.Open();

            cmd3.ExecuteNonQuery();

            conn3.Close();
       }

       public static DataSet getNoticeLicence()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String sqlQuery = "SELECT * FROM licence WHERE ExpiryDate < ADD_MONTHS(SYSDATE, 1) AND ExpiryDate >= SYSDATE AND Stat = '" + "Valid" + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter dr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            dr.Fill(ds, "licence");

            conn.Close();
            return ds;
        }

        public static void updateNotice() 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String sqlQuery = "UPDATE licence SET Stat ='" + "Soon" + "' WHERE ExpiryDate < ADD_MONTHS(SYSDATE, 1) AND ExpiryDate >= SYSDATE AND Stat = '" + "Valid" + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getOverdueLicences()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String sqlQuery = "SELECT * FROM licence WHERE ExpiryDate < SYSDATE";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter dr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            dr.Fill(ds, "licence");

            conn.Close();
            return ds;
        }

        public static void updateOverdue()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String sqlQuery = "UPDATE licence SET Stat ='" + "Expired" + "' WHERE ExpiryDate < SYSDATE";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static double revenue(String year, String month) 
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery;
            double count=0;

            if (month.Equals("All"))
                sqlQuery = "SELECT COUNT(*) FROM licence WHERE SUBSTR(expiryDate, 8) = " + year;
            else
                sqlQuery = "SELECT COUNT(*) FROM licence WHERE SUBSTR(expiryDate, 8) = '" + year +"' AND  SUBSTR(expiryDate, 4, 3) = '" + month + "'";

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

        public static double findFee(String year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            double fee;
            String sqlQuery = "SELECT Fee FROM CurrentFee WHERE SUBSTR(StartDate, 8) = '" + year + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                OracleDataAdapter dr2 = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                dr2.Fill(ds, "CurrentFee");

                DataTable dt = ds.Tables["CurrentFee"];

                DataRow row = dt.Rows[0];

                fee = double.Parse(row["Fee"].ToString());

                conn.Close();
                return fee;
            }

            conn.Close();
            return 0;
        }

        public static string licenceStat(int id) 
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM licence WHERE Cus_Id = " + id;

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

                String stat = row["Stat"].ToString();

                conn.Close();
                return stat;
            }

            conn.Close();
            return "";
        }

        public static int[] addressValidLicence(String street, String Town, String County) 
        {
            int[] ids = new int[2];

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * " +
                "FROM Licence WHERE Street = '" + street +
                "' AND Town = '" + Town + "' And County = '" + County + "'";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                OracleDataAdapter dr2 = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                dr2.Fill(ds, "licence");

                DataTable dt = ds.Tables["licence"];

                DataRow row = dt.Rows[0];

                ids[0] = Int32.Parse(row["LicenceId"].ToString());
                ids[1] = Int32.Parse(row["LicenceId"].ToString());

                conn.Close();
                return ids;
            }

            conn.Close();
            return ids;
        }
    }
}
