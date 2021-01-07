using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BL
{
    public class Customer
    {
        public String Name;
        public virtual int GetOrdersByName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }
            return 100;
        }        
    }

    public class LoyalCustomer : Customer
    {
        public int Discount
        {
            get;
            set;
        }
        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();
            else
                return new LoyalCustomer();
        }
    }
}
