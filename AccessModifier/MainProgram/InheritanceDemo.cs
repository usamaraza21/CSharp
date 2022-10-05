using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModifierLibrary;
namespace MainProgram
{
    public class InheritanceDemo : AccessDemo 
    {
        private void DemoTest()
        {
            ProtectedDemo();
            PrivateProtectedDemo();
            ProtectedInternalDemo();
            InternalDemo();
            PublicDemo();
            
        }
    }
}