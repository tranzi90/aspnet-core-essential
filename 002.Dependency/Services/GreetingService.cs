using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _002.Dependency.Services
{
    public class GreetingService : IGreeting
    {
        public string Greet()
        {
            return "Hello, dear user!";
        }
    }
}
