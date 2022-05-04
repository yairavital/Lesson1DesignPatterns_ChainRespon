using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_HW
{
    public class Car
    {
        public string Model { get; set; }
        public bool IsNeedRepair;

        public Car(string model, bool isNeedRepair)
        {
            Model = model;
            IsNeedRepair = isNeedRepair;
        }
    }
}
