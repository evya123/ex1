using System;
using System.Collections.Generic;
using System.Text;

namespace ex1 {
    class SingleMission : IMission {
        private string name;
        private string type;

        public SingleMission(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name {
            get { 
                return this.name;
            }
        }

        public string Type {
            get{
                return this.type;
            }
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value) {
            
        }
    }
}
