using StrategyDesign_Pattern.Ibehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesign_Pattern.BehaviorClass
{
    public class FlyWithWings : IFyBehavior
    {
      void IFyBehavior.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
