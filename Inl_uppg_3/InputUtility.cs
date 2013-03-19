//Johan Persson
//tf041968 - Malmö Högskolausing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inl_uppg_3
{
    class InputUtility
    {

        public bool kollaInput(string gissning)
        {
            int siffra; 
            if(int.TryParse(gissning, out siffra))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
