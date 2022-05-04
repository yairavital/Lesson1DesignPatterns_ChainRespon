using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_HW
{
    public abstract class CheckClassAbs
    {
        protected CheckClassAbs nextCheck;
        public bool isFixed;
        public  void NextCheck(CheckClassAbs next)
        {
            nextCheck = next;
        }
        public abstract void HandleCar(Car car);
    }
}
