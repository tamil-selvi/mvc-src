using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper.Linq.NullableTypes
{
    public class NullableTypeExample
    {
        public void Example()
        {
            DateTime? date = null;
            DateTime? date1 = new DateTime(2021,01,01);

            DateTime date3 = date ?? DateTime.Today;

            DateTime date4 = (date!=null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.Value); 
        }
    }
}
