using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_.Classes {
    public class ComparablePair<U, T> : IComparable<ComparablePair<U, T>> {
        public U Value1 { get; set; }
        public T Value2 { get; set; }
        public ComparablePair(U value1, T value2) {
            Value1 = value1;
            Value2 = value2;         
        }
        public override string ToString() {
            return $"({Value1.ToString()}, {Value2.ToString()})";
        }
        public void getCompareResult(ComparablePair<U, T> pair, Action<string> output) {
            int i = CompareTo(pair);
            if (i == 0) { output($"{this.ToString()} == {pair.ToString()}"); }
            else if (i > 0) { output($"{this.ToString()} > {pair.ToString()}"); }
            else { output($"{this.ToString()} < {pair.ToString()}"); }
        }
        public int CompareTo(ComparablePair<U, T>? other) {
            if (Value1.ToString() == other.Value1.ToString())
                return string.Compare(Value2.ToString(), other.Value2.ToString());
            return string.Compare(Value1.ToString(), other.Value1.ToString());
        }
    }
}
