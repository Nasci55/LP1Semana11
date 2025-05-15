using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Controller contr = new Controller();
            IView view = new View();

            contr.Start();
        }
    }
}