using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityNo2_UNIT1
{
    internal class Vehicle
    {
        public string? licenseType { get; set; }
        public string? year { get; set; }
        public string? brand { get; set; }
        public string? description { get; set; }
        public string? color { get; set; }

        public void addTo(Person person)
        {
            if (person.license[0] != null)
            {
                if (person.license[0].type == this.licenseType)
                {
                    if (person.gender == "MALE")
                    {
                        if (this.brand == "TOYOTA" || this.brand == "FORD")
                        {
                            Console.WriteLine(person.name);
                            Console.WriteLine("Car added");
                            Console.WriteLine();
                            person.addVehicle(this);
                        }
                        else
                        {
                            Console.WriteLine(person.name);
                            Console.WriteLine("Only TOYOTA or FORD cars can be added to MEN");
                            Console.WriteLine();
                        }
                    }
                    else if (person.gender == "FEMALE")
                    {
                        if (this.color == "RED")
                        {
                            Console.WriteLine(person.name);
                            Console.WriteLine("Car added");
                            Console.WriteLine();
                            person.addVehicle(this);
                        }
                        else
                        {
                            Console.WriteLine(person.name);
                            Console.WriteLine("Only RED cars can be added to WOMEN");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(person.name);
                    Console.WriteLine("The license of this person isn't for this car");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(person.name);
                Console.WriteLine("This person can't have a car without license");
                Console.WriteLine();
            }
        }
    }
}