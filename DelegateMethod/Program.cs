using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMethod
{
    public delegate string HelloDelegate(string name);
    class SomeClass
    {
        public string SayHello(string s)
        {
            return $"Hi, {s}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            HelloDelegate hD = new HelloDelegate(someClass.SayHello);
            Console.WriteLine(hD.Invoke("Кто-то"));
            Console.ReadLine();
        }
    }
}
