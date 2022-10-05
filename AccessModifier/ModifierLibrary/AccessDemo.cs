using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModifierLibrary
{
    public class AccessDemo
    {
         

        // just for demo method for this class.
        private void Demo()
        {
            PrivateDemo();    
        }
        // PRIVATE keyword only access inside the same class.
        private void PrivateDemo()
        {

        }
        private protected void PrivateProtectedDemo()
        {

        }
        protected  void ProtectedDemo()
        {

        }
        protected internal void ProtectedInternalDemo()
        {

        }
        // INTERNAL keyword can only access inside the Assembly not outside from the Assembly.
        internal void InternalDemo()
        {

        }
        // PUBLIC keyword can access by any where inside the project and for outside the project using with namespace.
        public void PublicDemo()
        {
        }


    }
}