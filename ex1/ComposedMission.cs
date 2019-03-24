using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    class ComposedMission : IMission
    {
        private List<func> listOfFuncs;
        public event EventHandler<double> OnCalculate;

        public ComposedMission(string name)
        {
            this.Name = name;
            this.Type = "Composed";
            this.listOfFuncs = new List<func>();
        }

        public string Name { get; }

        public string Type { get; }

        public ComposedMission Add(func value)
        {
            this.listOfFuncs.Add(value);
            return this;
        }

        public double Calculate(double value)
        {
            var ret = value;
            foreach (func f in this.listOfFuncs)
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
