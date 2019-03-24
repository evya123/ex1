using System;
using System.Collections.Generic;

namespace ex1
{
    class ComposedMission : IMission
    {
#pragma warning disable IDE0044 // Add readonly modifier
        private List<func> ListOfFuncs;
#pragma warning restore IDE0044 // Add readonly modifier
        public event EventHandler<double> OnCalculate;

        public ComposedMission(string name)
        {
            this.Name = name;
            this.Type = "Composed";
            this.ListOfFuncs = new List<func>();
        }

        public string Name { get; }

        public string Type { get; }

        public ComposedMission Add(func value)
        {
            this.ListOfFuncs.Add(value);
            return this;
        }

        public double Calculate(double value)
        {
            var ret = value;
            foreach (func f in this.ListOfFuncs)
            {
                ret = f(ret);
            }
            if (this.OnCalculate != null)
            {
                this.OnCalculate.Invoke(this, ret);
            }

            return ret;
        }
    }
}
