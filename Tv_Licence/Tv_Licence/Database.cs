using System;
using System.Collections.Generic;
using System.Text;

namespace Tv_Licence
{
    class Database
    {
        static List<String> propHis= new List<String>();
        static List<String> account= new List<String>();
        static int count = 0;
        String address, town, county, tvlicence, fname, lname;

        public Database(String address, String town, String county, String tvlicence, String fname, String lname)
        {
            this.address = address;
            this.town = town;
            this.county = county;
            this.tvlicence = tvlicence;
            this.fname = fname;
            this.lname = lname;
            propHistory();
            ++count;
        }

        public Database() 
        {
            populateList();
        }

        public void propLicence() 
        {
            String licenceInfo = "name: " + this.fname + ", " + this.lname + " | Address: " + this.address + ", " + this.town + ", " + this.county
                + " | Licence No: " + this.tvlicence;
            account.Add(licenceInfo);
        }

        public void propHistory() 
        {
            String name = "Name: " + this.fname + ", " + this.lname;
            propHis.Add(name);
        }
        private void populateList()
        {
            String licenceInfo = "name: Bobby, David" + " | Address: 91 asdad a, Cork, Cork" + " | Licence No: 12345678901234567890";
            account.Add(licenceInfo);
            String name = "Name: Bobby, David";
            propHis.Add(name);

            licenceInfo = "name: boy, David" + " | Address: 92 asdad a, Cork, Cork" + " | Licence No: 12345678901238567890";
            account.Add(licenceInfo);
            name = "Name: Boy, David";
            propHis.Add(name);
        }

        public string historyToString() 
        {
            String hisInfo="";

            for (int i=0; i< propHis.Count; i++)
                hisInfo += propHis[i] + Environment.NewLine;

            return hisInfo;      
        }

        public string accountToString()
        {
            String tolist = "";

            for (int i = 0; i < account.Count; i++)
                tolist += "\n" + account[i] + Environment.NewLine;

            return tolist;
        }
    }
}
