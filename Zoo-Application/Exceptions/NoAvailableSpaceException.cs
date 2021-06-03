using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class NoAvailableSpaceException : Exception
    {
        public NoAvailableSpaceException(string msg) : base(msg) { }
    }
}
