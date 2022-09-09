using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern.Interfaces
{
    public interface IStrategy
    {
        object Algorithm(object data);
    }
}
