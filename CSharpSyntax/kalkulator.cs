using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class kalkulator
    {
        public static int Scitaj(int a,int b)
        {
            return a + b;
        }
        public static int Scitaj(int a,int b, int c)
        {
            return a + b + c;

        }
        public static int Scitaj(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);

            int mv1 = int.Parse(a);
            int mv2 = int.Parse(b);
            return Scitaj(mv1 , mv2);

        }

        internal static int vynasob(int v1, int v2, int v3, int v4, int v5)
        {
            return v1;
        }
    }
}
