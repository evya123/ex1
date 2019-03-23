using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    delegate Double func(double val);
    class FunctionsContainer
    {
        Dictionary<String, func> funcArray;

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
    }
}
