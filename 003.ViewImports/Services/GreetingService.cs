using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _003.ViewImports.Services
{
    public class GreetingService : IGreeting
    {
        public string Greet()
        {
            return "Hello, dear user!";
        }
    }
}
