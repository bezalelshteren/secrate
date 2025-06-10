using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secrate
{
    public class agant
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string secretCode { get; set; }
        public string type { get; set; }
        public int numReports { get; set; }
        public int numMentions { get; set; }

        public agant() { }

        public agant(string firstName, string lastName, string secretCode, string type, int numReports, int numMentions)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.secretCode = secretCode;
            this.type = type;
            this.numReports = numReports;
            this.numMentions = numMentions;

        }
    }
}
