using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionsContainer funcList = new FunctionsContainer();
            funcList["Double"] = val => val * 2;
            funcList["Triple"] = val => val * 3;
            funcList["Square"] = val => val * val;
            funcList["Sqrt"] = val => Math.Sqrt(val);
            funcList["Plus2"] = val => val + 2;
        }
    }
}
