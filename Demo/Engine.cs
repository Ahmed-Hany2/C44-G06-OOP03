using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Cars
    {
        private Engine engine;
        public Cars() 
        {
            engine = new Engine();
            engine.Start();
        }
    }
}
