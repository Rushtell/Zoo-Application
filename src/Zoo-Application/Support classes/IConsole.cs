using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public interface IConsole
    {
        public void Write(string msg);

        public void WriteLine(string msg);
    }
}
