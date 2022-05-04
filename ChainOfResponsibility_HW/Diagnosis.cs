using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_HW
{
    internal class Diagnosis : CheckClassAbs
    {
       
        public override void HandleCar(Car car)
        {
            Random random = new Random();
            int test = random.Next(1, 11);
            if (test >= 6)
            {
                Console.WriteLine($"{car.Model} You passed the Diagnosis Test test successfully , You are transferred to the next test");
                if (nextCheck != null)
                    nextCheck.HandleCar(car);
                else
                    Console.WriteLine("The tretment is over");

            }
            else
            {
                Console.WriteLine($"{car.Model} We found the problem and we fixed it");
                car.IsNeedRepair = false;
            }
        }
    }
}
