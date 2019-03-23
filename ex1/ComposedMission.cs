using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    class ComposedMission : IMission
    {
        private string name;
        private string type;

        public ComposedMission(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name {
            get
            {
                return this.name;
            }
        }

        public string Type {
            get
            {
                return this.type;
            }
        };

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
