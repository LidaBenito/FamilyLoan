using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadr_Tools.Utility
{
   public static class GeneralMethod
    {
        public static void Sleep(int milisec = 100)
        {
            System.Threading.Thread.Sleep(milisec);
        }
    }
}
