using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ActivityNo2_UNIT1
{
    internal class License
    {
        public string? keyCode { get; set; }
        public string? initialDate { get; set; }
        public string? expirationDate { get; set; }
        public string? type { get; set; }

        public void giveLicense(Person person, License license)
        {
            if (person.age > 90)
            {
                Console.WriteLine(person.name);
                Console.WriteLine("You CAN'T have a license");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(person.name);
                Console.WriteLine("You CAN have a license");
                Console.WriteLine();
                person.addLicense(license);
            }
        }
    }
}