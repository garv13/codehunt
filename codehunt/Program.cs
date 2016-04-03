using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codehunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, s, p;
            p = "baab";
            s = "aabaab";
            if (p == "")
                Console.WriteLine( s);
            else
            {
                char[] array = p.ToCharArray();
                a = s.Trim(array);
                s.Replace(s,p);
                Console.WriteLine(a);
            }
        }
    }
}
