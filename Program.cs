using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            connactionToSql connactionToSql = new connactionToSql();
            agant agant = new agant()
            {
                firstName = "firstName",
                lastName = "lastName",
                secretCode = "secretCode",
                type = "type",
                numReports = 5,
                numMentions = 8,
            };
            DHLsecrate secrate = new DHLsecrate();
            enterANewPerson enterANewPerson = new enterANewPerson();
            Console.WriteLine("byhb");
            string o =  Console.ReadLine();
             secrate.GetPersonByName(o, enterANewPerson);
        }
    }
}
