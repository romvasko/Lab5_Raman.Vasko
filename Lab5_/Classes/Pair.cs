using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_.Classes {
    public class Pair<S,T> 
    {
        public S Value1 { get; set; }
        public T Value2 { get; set; }

        public Pair(S value1, T value2) {
            Value1 = value1;
            Value2 = value2;
        }

        public void GetPairSum(Action<string> output) {
            output($"Sum: {Value1.ToString() + Value2.ToString()}");
        }

        public override string ToString() 
        {
            return $"({Value1.ToString()}, {Value2.ToString()})";
        }
    }
}
