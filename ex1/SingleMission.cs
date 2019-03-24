using System;
using System.Collections.Generic;
using System.Text;

namespace ex1 {
    class SingleMission : IMission {
        private func f;
        public SingleMission(func f, string name)
        {
            this.Name = name;
            this.Type = "Single";
            this.f = f;
        }

        public string Name { get; }

        public string Type { get; }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value) {
            double result = f(value);
            if (this.OnCalculate != null)
            {
                OnCalculate.Invoke(this, result);
            }
            return result;
        }
    }
}
