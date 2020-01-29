using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class parent
    {
        int fn;
        int sn;
        public parent(int fn, int sn)
        {
            this.fn = fn;
            this.sn = sn;
        }
        public int add()
        {
            return fn + sn;
        }

    }

    class child : parent
    {
        //int sn, fn;
        public child(int fn,int sn) : base(fn,sn)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent pa = new parent(4,3);
            child cl = new child(4,2);
            Console.WriteLine(cl.add());
            Console.WriteLine(pa.add());
            Console.ReadKey();
        }
    }
}
