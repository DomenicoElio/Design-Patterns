using Design_Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern.Entities
{
    public class ConcreteStrategyA : IStrategy
    {
        public object Algorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }

    }
}
