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
            AccessDemo _demo = new AccessDemo();
            _demo.ProtectedInternalDemo();
            _demo.InternalDemo();
            _demo.PublicDemo();
            PrivateProtectedDemo();
            ProtectedDemo();
        }
    }
}