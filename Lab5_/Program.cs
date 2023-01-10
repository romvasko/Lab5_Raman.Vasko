// See https://aka.ms/new-console-template for more information
using Lab5_.Classes;

Pair<int, string> pair = new Pair<int, string>(15,"sss");
pair.GetPairSum(x => Console.WriteLine(x));
Console.WriteLine(pair.ToString());

ComparablePair<int, string> pair2 = new ComparablePair<int, string>(1, "66");
ComparablePair<int, string> pair3 = new ComparablePair<int, string>(10, "78");

pair2.getCompareResult(pair3, x => Console.WriteLine(x));

ComparablePair<int, string> pair4 = new ComparablePair<int, string>(100, "1");
ComparablePair<int, string> pair5 = new ComparablePair<int, string>(100, "2");

pair4.getCompareResult(pair5, x => Console.WriteLine(x));

ComparablePair<int, string> pair6 = new ComparablePair<int, string>(100, "2");
ComparablePair<int, string> pair7 = new ComparablePair<int, string>(100, "1");

pair6.getCompareResult(pair7, x => Console.WriteLine(x));

ComparablePair<int, string> pair8 = new ComparablePair<int, string>(10, "66");
ComparablePair<int, string> pair9 = new ComparablePair<int, string>(1, "78");

pair8.getCompareResult(pair9, x => Console.WriteLine(x));

ComparablePair<int, string> pair10 = new ComparablePair<int, string>(100, "100");
ComparablePair<int, string> pair11 = new ComparablePair<int, string>(100, "100");

pair10.getCompareResult(pair11, x => Console.WriteLine(x));