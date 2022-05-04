using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1DW
{
    public abstract class BillHandler
    {
        protected BillHandler next;

        internal void SetNextBill(BillHandler billnext)
        {
            this.next = billnext;
        }

        public void SetNext(BillHandler next)
            { this.next = next; }
        public abstract void HandleRequest(int amount);
    }
}
