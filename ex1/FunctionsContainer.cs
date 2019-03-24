using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    delegate double func(double val);
    class FunctionsContainer
    {
        private Dictionary<String, func> funcArray;

        public FunctionsContainer()
        {
            this.funcArray = new Dictionary<String, func>();
        }

        public func this[String key]
        {
            get
            {
                if (!funcArray.ContainsKey(key))
                {
                    funcArray.Add(key, value => value);
                }

                return funcArray[key];
            }
            set { funcArray[key] = value; }
        }
        public List<String> getAllMissions()
        {
            return funcArray.Keys.ToList();
        }
    }
}
