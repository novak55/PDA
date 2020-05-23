using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkolC
{
    class MyException_KouleExistujiciCislo : Exception
    {
        public MyException_KouleExistujiciCislo(string message) : base(message)
        {

        }
    }
}
