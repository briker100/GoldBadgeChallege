using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Greet
    {
        //public class Greets
        //{

            public string firstname { get; set; }
            public string lastname { get; set; }
            public string type { get; set; }
            public string email { get; set; }

            public Greet(string FirstName, string LastName, string Type, string Email)
            {
                firstname = FirstName;
                lastname = LastName;
                type = Type;
                email = Email;
            }



            public override string ToString()
            {
                string stringToReturn = $"{firstname}\t {lastname}\t{type}\t{email}\t\n";

                return stringToReturn;

            }
        //}
    }
}
