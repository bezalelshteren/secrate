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
                Console.WriteLine("Enter your name and the name of the target and report separated by a semicolon");
                string[] allInfo = Console.ReadLine().Split();
                var nameOrId = allInfo[0];
                string report = allInfo[1];
                
            }

        }
        public void GetPersonBySecretCode() //
        {

        }
        public void InsertNewPerson() { }//
        public void InsertIntelReport() { }//
        public void UpdateReportCount() { }//
        public void UpdateMentionCount() { }//
        public void GetReporterStats() { }//
        public void GetTargetStats() { }//
        public void CreateAlert() { }//
        public void GetAlerts() { }//
    }
}
