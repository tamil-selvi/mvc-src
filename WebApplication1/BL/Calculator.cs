using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BL
{
    public class Calculator
    {
        public List<int> FiboNumbers = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        public Dictionary<int, int> dict1 = new Dictionary<int, int>() { {1,0 },{ 2, 0 }, { 3, 0 } };
        public Dictionary<int, int> dict2 = new Dictionary<int, int>() { {7,0 }, {8,0 }, {9,0 } };

        public int age => 35;
        public int Add(int a, int b) 
        {
            return a + b;
        }

        public Double AddDouble(Double a, Double b)
        {
            return a + b;
        }

        public bool IsOdd(int value)
        {
            return (value % 2) == 1;
        }

        public void AppendDictionary<TKey,TValue> (Dictionary<TKey,TValue> fromdict, Dictionary<TKey, TValue> toDict)
        {
            foreach(var item in fromdict)
            {
                if(!toDict.ContainsKey(item.Key))
                    toDict.Add(item.Key, item.Value);
            }
            
        }
    }
}
