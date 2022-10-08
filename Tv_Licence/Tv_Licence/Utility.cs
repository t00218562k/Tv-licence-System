using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace Tv_Licence
{
    class Utility
    {
        public static Boolean cardLengthValid(String card, int leng)
        {
            if (card.Length == leng)
                //checks if the card number field is not equal to 16 charcters or if any non numerics were inputed, shows a corresponding error message if true  
                return true;
            else
            {
                MessageBox.Show("Please enter " + leng + " digits");
                return false;
            }

        }

        public static Boolean expiryChecker(String cvv)
        {

            if (cvv.Length == 5 && (Char.ToString(cvv[2]) == "/"))
            //checks if the Expiry date field is 5 charcters and has a '/' after the user choosen month
            {
                DateTime dateyear = DateTime.Now;
                //create object for current date

                String stringMonth = Char.ToString(cvv[0]) + Char.ToString(cvv[1]);
                //getting user input for the month and turning it into a string

                String stringYear = Char.ToString(cvv[3]) + Char.ToString(cvv[4]);
                //getting user input for the year and turning it into a string

                int inputMonth, inputYear, currentYear;
                //ints for user expiry month, year and the current year 


                if (int.TryParse(stringMonth, out int n) && int.TryParse(stringYear, out int y))
                //checks if user put in numeric characters
                {
                    inputMonth = Int32.Parse(stringMonth);
                    //Converting user expiry month into a int

                    inputYear = Int32.Parse(stringYear);
                    //onverting user expiry year into a int

                    currentYear = Int32.Parse(dateyear.ToString("yy"));
                    //onverting current year into a int

                    if ((inputMonth < dateyear.Month) || (inputYear < currentYear))
                    //checks if user input date is before the current date, if true then the corresponding error message will appear 
                    {
                        MessageBox.Show("Card expired");
                        return false;
                    }

                    if (inputMonth > 12)
                    //checks if user month is greater then 13
                    {
                        MessageBox.Show("Month greater then 12");
                        return false;
                    }
                    return true;
                }
                else
                //if non numeric characters where inputed then corrseponding error message will appear
                {
                    MessageBox.Show("Please enter numeric values e.g '06/25'");
                    return false;
                }
            }
            else
            //if user didnt enter 5 characters and '/'
            {
                MessageBox.Show("MM /YY");
                return false;
            }
        }

        public static Boolean emailValid(String email)
        {
            //https://stackoverflow.com/questions/5342375/regex-email-validation
            if (!(Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                MessageBox.Show("This field must be a valid email e.g 'wow@gg.com'");
                return false;
            }

            return true;
        }

        public static Boolean alphaChecker(String word)
        {
            if (!(Regex.IsMatch(word, @"^[a-zA-Z\s]+$")))
                return false;

            return true;
        }

        public static Boolean alphaNumericChecker(String word)
        {
            if (!(Regex.IsMatch(word, @"^[a-zA-Z0-9\s]+$")))
                return false;

            return true;
        }

        public static Boolean valueAfterspace(String word)
        {
            int strlength = word.Length;

            for (int i = 0; i < word.Length; i++)
                if (Char.IsWhiteSpace(word[i]) && !(i + 1 == strlength))
                    if (!(Char.IsWhiteSpace(word[i + 1])))
                        return true;

            MessageBox.Show("Please enter full name e.g John Jerry");
            return false;
        }

        public static Boolean fullName(String word)
        {
            if (valueAfterspace(word) && alphaChecker(word))
                return true;

            return false;
        }

        public static String[] countys()
        {
            String[] countys = {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Down",
                "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick",
                "Londonderry", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo",
                "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"};

            return countys;
        }

        public static void sendMail(String senderMail, String topic, String message) 
        {
            //https://www.codeproject.com/Questions/885446/How-to-resolve-this-issue-failure-sending-mail-csh
            MailMessage msg = new MailMessage();
            msg.To.Add(senderMail);
            MailAddress address = new MailAddress("dummywow401@gmail.com");
            msg.From = address;
            msg.Subject = topic;
            msg.Body = message;

            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            client.Host = "relay-hosting.secureserver.net";
            client.Port = 25;

            NetworkCredential credentials = new NetworkCredential("dummywow401@gmail.com", "#arj4xMrdrrg");
            client.UseDefaultCredentials = true;
            client.Credentials = credentials;

            client.Send(msg);
        }

        public static void emailList(DataSet d1, String message)
        {
            if (d1.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Their is no rows to send notice");
                return;
            }

            for (int i = 0; i < d1.Tables[0].Rows.Count; i++)
            {
                int id = Int32.Parse(d1.Tables[0].Rows[i]["Cus_Id"].ToString());

                DataSet email = Customer.customerInfo(id);

                Utility.sendMail(email.Tables[0].Rows[0]["Email"].ToString(), "Tv licence", message);
            }

            MessageBox.Show("A notice has been sent");
        }
    }
}
