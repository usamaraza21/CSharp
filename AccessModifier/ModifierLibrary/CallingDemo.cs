using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModifierLibrary
{
    public class CallingDemo
    {
        private void DemoCalls()
        {
            AccessDemo test1 = new AccessDemo();
            test1.InternalDemo();
            test1.PublicDemo();

        }
    }
}