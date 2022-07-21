using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDelegate
{
    class Program
    {
        public delegate void Add<A>(A a1, A a2);
        public void addnum<A1>(A1 x, A1 y)
        {
            Console.WriteLine("A1 X = " + x);
            Console.WriteLine("A1 Y = " + y);
        }
        public void addStr<A2>(A2 x, A2 y)
        {
            Console.WriteLine("A2 X = " + x);
            Console.WriteLine("A2 Y = " + y);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Add<String> a = new Add<String>(p.addnum);
            a += p.addStr;
            a.Invoke("ABCD", "HIJK");
            Console.Read();
        }
    }
}
