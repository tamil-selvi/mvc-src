using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{

    // constraints
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T = new() // any class with default constructor


    // example for create reference type  where T : class
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    // example for create value type  where T : class
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }
        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;
            
            return default(T);

        }
       
    }

    public class Utilities<T> where T : IComparable, new()
    {
        public int MyProperty { get; set; }
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //comparision will not applicalble for generics for that use IComparaere

        //public T Max<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

    }
}
