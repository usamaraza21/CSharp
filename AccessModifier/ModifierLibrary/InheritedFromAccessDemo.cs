using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModifierLibrary
{
    public class InheritedFromAccessDemo : AccessDemo
    {
        private void InheritedDemo()
        {
            PrivateProtectedDemo();
            ProtectedDemo();
            InternalDemo();
            PublicDemo();
            
        }
    }
}