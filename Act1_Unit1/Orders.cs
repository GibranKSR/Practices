using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityNo1_UNIT1
{
    internal class Orders
    {
        public List<Products> order;
        public Orders()
        {
            this.order = new List<Products>();
        }
        public void buyPro(Products product)
        {
            Boolean IN = false;
            for (int i = 0; i < order.Count; i++)
            {
                if (product.code == order[i].code)
                {
                    IN = true;
                    product.addedQuantity++;
                }
            }
            if (IN == false)
            {
                order.Add(product);
                product.addedQuantity++;
            }
        }

        int shipping = 200;
        public void total()
        {
            decimal totalC = 0M;
            for (int i = 0; i < order.Count; i++)
            {
                totalC += (order[i].price - (order[i].disc * order[i].price / 100)) * order[i].addedQuantity;
            }
            Console.WriteLine("THE TOTAL OF YOUR ORDER IS: " + totalC + " PLUS " + shipping + " OF SHIPPING:)");
        }
    }
}