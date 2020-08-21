using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Challenge_1_Program
    {
        static void Main(string[] args)
        {
            var console = new RealConsole();
            Challenge_1_UI ui = new Challenge_1_UI(console);
            ui.Start();

        }
    }
}
