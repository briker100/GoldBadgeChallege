using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
   public class Greet
    {
        public Greet() { }


         public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Type { get; set; }
            public string Email { get; set; }

            public Greet(string firstName, string lastName, string type, string email)
            {
                Firstname = firstName;
                Lastname = lastName;
                Type = Type;
                Email = email;
            }
        
            public override string ToString()
            {
                string stringToReturn = $"{Firstname}\t {Lastname}\t{Type}\t{Email}\t\n";

                return stringToReturn;

            }
        //}
    }
}
