using System;
using System.Text;

namespace Function
{
    public class FunctionHandler
    {
        public void Handle(string input) {
            Console.WriteLine("Text to translate: "+ input + " on " + System.Environment.MachineName);
        }
    }
}
