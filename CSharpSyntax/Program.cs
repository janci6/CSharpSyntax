using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {

        public int GlobalnaPremenna = 7;

        

        static void Main(string[] args)
        {
            const int mojaKonstanta = 4;

            int polomer = 6;
            //polomer = polomer + 1;
            //polomer += 1;
            //polomer++; // najskor vyhodnoti polomer a potom +1
            //++polomer; // najskor zvysi o 1 potom vyhodnoti polomer 

            Console.WriteLine("povodny polomer {0}", polomer);
            int novyPolomer = polomer++;
            Console.WriteLine("novy polomer {0}", novyPolomer);
            int zasenovyPolomer = ++polomer;
            Console.WriteLine("zase novy Polomer {0}", zasenovyPolomer);
            // problem bude ze pocitac bude ratat spravne uz predtym ale ukazovany vysledok bude este nedostacujuci ...

            // v priprade ze chceme zvacsit o viac tak .. polomer += 8;


            var vari = 6;
            // sa pouziva ked nevies akeho tzpu bude objekt



            // pouzitie kalkulatoru

            kalkulator.Scitaj("4", "5");
            kalkulator.Scitaj(4,6);
            int vysledok = kalkulator.vynasob(2, 5, 6, 7, 9);
            

            // if (bool) prikaz1 else prikaz2
            if (vysledok == 4) vysledok++;


            //////////////////////////////////////////////////////////

            switch(vysledok)
            {
                case 2:
                    Console.WriteLine("vysledok bol 7");
                    break;
                case 3:
                    Console.WriteLine("vysledok bol 5");break;
                default:
                    Console.WriteLine("vysledok nebol 7,5");break;


            }
            if (vysledok == 4 || vysledok == 6)
            {


            }
            // && znamena zaroven ... v pripade podmiekok napriklad 
            if (((vysledok >= 10 && vysledok < 20) || (vysledok >= 40 && vysledok <= 60)) && (vysledok != 16))// trebasledovat matematicku prioritu a pouzivat zatvorky
            {
                
            }
            







            Console.ReadKey();
 
        }
    }
}
