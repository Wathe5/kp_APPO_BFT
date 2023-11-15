using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KP_APPO
{
    class BFT_Creator
    {
        const string closeTag = " 0[0]";

        public string createConst(string data)
        {
            return (" 1[.] " + data + closeTag);
        }

        public string createVariable(string name, string data)
        {
            return (" 1[" + name + "] " + data + closeTag);
        }

        public string createLink(string name, string data)
        {
            return (" 0[" + name + "] " + data + closeTag);
        }
    }
}
