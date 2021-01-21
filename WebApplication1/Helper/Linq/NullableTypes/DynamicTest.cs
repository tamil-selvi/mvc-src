using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper.Linq.NullableTypes
{
    //static languages: at compile-time
    //Dynamic languages : at run-time
    public class DynamicTest
    {

        public void test()
        {
            dynamic excelObject = "name";
            excelObject.Optimize();
        }

    }
}
