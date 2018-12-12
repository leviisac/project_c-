using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        public static int kodratz=00000000;
        public int kod_ratz()
        {
            kodratz++;
            return kodratz;
        }
    }
}
