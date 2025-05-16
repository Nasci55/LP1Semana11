using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC2
{
    public class Program
    {
        private static void Main(string args)
        {
            Controller contr = new Controller(args);

            contr.Start();
        }
    }
}