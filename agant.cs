using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secrate
{
    public class agant
    {
        public int id { get; }
        public string firstName { get; }
        public string lastName { get; }
        public string secretCode { get; }
        public string type { get; }
        public int numReports { get; }
        public int numMentions { get; }

        public agant(string firstName,string lastName,string secretCode ,string type, int numReports,int numMentions)
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
