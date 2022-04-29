using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmianaZnakow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj slowo; ");
            string slowo =Console.ReadLine();
            char[] tab = new char[slowo.Length];
            for(int i =0; i<slowo.Length;i++)
            {
                tab[i] = slowo[i]; 
            }
            char s;
            s = tab[0];
            tab[0] = tab[tab.Length - 1];
            tab[tab.Length - 1] = s;
            foreach(char x in tab)
            {
                Console.Write(x);
            }

           Console.ReadKey();
            


        }
    }
}
