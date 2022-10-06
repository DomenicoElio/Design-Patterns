using Design_Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern.Entities
{
    public class Context
    {

        private IStrategy _strategy;

        public Context() { }

        public Context (IStrategy strategy) { this._strategy = strategy; }

        public void SetStrategy(IStrategy strategy) { this._strategy = strategy; } 

        public void BusinessFunction() {
            Console.WriteLine("Sorting the data");
            var result = this._strategy.Algorithm(new List<string> { "d","o","m","e","n", "i", "c", "o"});

            string output = string.Empty;
            foreach (var element in result as List<string>) { 
                output += element + ","; 
            }
            Console.WriteLine(output);
        }
    }
}
