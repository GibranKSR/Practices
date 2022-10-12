using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ActivityNo2_UNIT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.keyCode = "0001";
            p1.name = "Abraham";
            p1.surname = "Orozco";
            p1.age = 18;
            p1.gender = "MALE";

            Person p2 = new Person();
            p2.keyCode = "0003";
            p2.name = "Jose";
            p2.surname = "Herrera";
            p2.age = 91;
            p2.gender = "MALE";

            Person p3 = new Person();
            p3.keyCode = "0004";
            p3.name = "Miranda";
            p3.surname = "Herrera";
            p3.age = 40;
            p3.gender = "FEMALE";



            ActivityNo2_UNIT1.License l1 = new ActivityNo2_UNIT1.License();
            l1.keyCode = "0002";
            l1.initialDate = "01/09/2022";
            l1.expirationDate = "01/09/2023";
            l1.type = "1";

            ActivityNo2_UNIT1.License l2 = new ActivityNo2_UNIT1.License();
            l2.keyCode = "0003";
            l2.initialDate = "01/09/2022";
            l2.expirationDate = "01/09/2023";
            l2.type = "1";

            ActivityNo2_UNIT1.License l3 = new ActivityNo2_UNIT1.License();
            l3.keyCode = "0002";
            l3.initialDate = "01/09/2022";
            l3.expirationDate = "01/09/2023";
            l3.type = "1";



            Vehicle v1 = new Vehicle();
            v1.licenseType = "1";
            v1.year = "1980";
            v1.brand = "FORD";
            v1.description = "OLD MUSTANG";
            v1.color = "BLACK";

            Vehicle v2 = new Vehicle();
            v2.licenseType = "1";
            v2.year = "1980";
            v2.brand = "FORD";
            v2.description = "OLD MUSTANG";
            v2.color = "BLACK";

            Vehicle v3 = new Vehicle();
            v3.licenseType = "1";
            v3.year = "1980";
            v3.brand = "FORD";
            v3.description = "OLD MUSTANG";
            v3.color = "BLACK";



            l1.giveLicense(p1, l1);
            l2.giveLicense(p2, l2);
            l3.giveLicense(p3, l3);



            v1.addTo(p1);
            v2.addTo(p2);
            v3.addTo(p3);
        }
    }
}