using System;
using System.Collections.Generic;
using System.Text;

namespace Pillars
{
    class Inheriter : Interface1, Interface2
    {

        // because Interfaces have no body I am not certain how to check with implementation
        // is being used here.
        public void AMethod()
        {
            throw new NotImplementedException();
        }
    }
}
