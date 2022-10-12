using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityNo2_UNIT1
{
    internal class Person
    {
        public string? keyCode { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public int age { get; set; }
        public string? gender { get; set; }

        public License[] license = new License[1];
        List<Vehicle> Vehicles = new List<Vehicle>();

        public void addLicense(License licenseAdd)
        {
            if (license[0] == null)
            {
                license[0] = licenseAdd;
            }
            else
            {
                Console.WriteLine(this.name);
                Console.WriteLine("This person have a license already");
                Console.WriteLine();
            }

        }
        public void addVehicle(Vehicle vehicleAdd)
        {
            if (Vehicles.Count > 5)
            {
                Console.WriteLine(this.name);
                Console.WriteLine("This person is considered a suspect of fraud");
                Console.WriteLine();
            }
            else
            {
                Vehicles.Add(vehicleAdd);
            }
        }
    }
}