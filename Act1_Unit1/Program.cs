using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace ActivityNo1_UNIT1
{
    class Program
    {
        public static void MENU(List<Products> pro)
        {
            Console.WriteLine("What would you want to do?(ADD INV, BUY, EXIT)");
            string? firstOp = Console.ReadLine();
            string firstOpUp = firstOp!.ToUpper();

            if (firstOpUp == "ADD INV")
            {
                addItem(pro);
            }
            else if (firstOpUp == "BUY")
            {
                BUY(pro);
            }
        }

        public static void PRINT(List<Products> pro)
        {
            for (int i = 0; i < pro.Count; i++)
            {
                Console.WriteLine("(" + (i) + ")");
                Console.WriteLine("   NAME:" + pro[i].name);
                Console.WriteLine("   DESC:" + pro[i].desc);
                Console.WriteLine("   PRICE:" + pro[i].price);
                Console.WriteLine("   DISC:" + pro[i].disc);
                Console.WriteLine("   QUANTITY:" + pro[i].quantity);
                Console.WriteLine("   CODE:" + pro[i].code);
            }
        }

        public static void addItem(List<Products> pro)
        {
            PRINT(pro);
            Console.WriteLine("CHOOSE A PRODUCT:");
            int secondOp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("QUANTITY:");
            int thirdOp = Int32.Parse(Console.ReadLine());
            pro[secondOp].quantity = pro[secondOp].quantity + thirdOp;
            Console.WriteLine("QUANTITY ADDED");
            Console.WriteLine("NAME:" + pro[secondOp].name);
            Console.WriteLine("QUANTITY:" + pro[secondOp].quantity);
            MENU(pro);
        }

        public static void BUY(List<Products> pro)
        {
            Orders ord = new Orders();

            PRINT(pro);

            Boolean finish = false;
            do
            {
                Console.WriteLine("Which product would you want to buy?");
                int proBuy = Int32.Parse(Console.ReadLine());
                ord.buyPro(pro[proBuy]);
                Console.WriteLine("Do you want to buy another product?(YES, NO)");
                string? YN = Console.ReadLine();
                string YNU = YN!.ToUpper();
                if (YNU == "NO")
                {
                    finish = true;
                }
            } while (finish == false);

            for (int i = 0; i < ord.order.Count; i++)
            {
                Console.WriteLine("NAME: " + ord.order[i].name + " QUANTITY: " + ord.order[i].addedQuantity);
            }
            ord.total();
        }
        static void Main(string[] args)
        {
            List<Products> pro = new List<Products>();

            Products p1 = new Products();
            p1.name = "Apple";
            p1.desc = "Fruit";
            p1.price = 100M;
            p1.disc = 15;
            p1.quantity = 23;
            p1.code = "0001";
            pro.Add(p1);

            Products p2 = new Products();
            p2.name = "Orange";
            p2.desc = "Fruit";
            p2.price = 100M;
            p2.disc = 25;
            p2.quantity = 12;
            p2.code = "0002";
            pro.Add(p2);

            Products p3 = new Products();
            p3.name = "Banana";
            p3.desc = "Fruit";
            p3.price = 100M;
            p3.disc = 10;
            p3.quantity = 8;
            p3.code = "0003";
            pro.Add(p3);

            MENU(pro);

        }
    }
}