using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secrate
{
    public class DHLsecrate
    {
        public void GetPersonByName()//לפי השם
        {
            try
            {
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message, ex.GetType()); }

        }
        public void GetPersonBySecretCode() //
        {

        }
        public void InsertNewPerson() //
        {
            try
            {
                Console.WriteLine("Enter your name and the name of the target and report separated by a semicolon");
                string[] allInfo = Console.ReadLine().Split(';');
                string report = allInfo[0];
                string nameOfTarget = allInfo[1];

            }
            catch (Exception ex) { Console.WriteLine(ex.Message, ex.GetType()); }

        }
        public void InsertIntelReport() { }//
        public void UpdateReportCount() { }//
        public void UpdateMentionCount() { }//
        public void GetReporterStats() { }//
        public void GetTargetStats() { }//
        public void CreateAlert() { }//
        public void GetAlerts() { }//
    }
}
