using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorok
{
    class Sorozatok
    {
        private int[] numbers = new int[4];
        private int odds;
        private float quotient;

        public Sorozatok(int odds, float quotient)
        {
            this.odds = odds;
            this.quotient = quotient;
        }

        //...
    }

    class Binaris
    {
        private string number;
        private int db = 0;

        public Binaris(string number)
        {
            this.number = number;
        }

        public Binaris()
        {
            this.number = "";
        }

        public void CountOne(string number)
        {
            bool onlyBin = true;
            for (int i = 0; i < number.Length; i++)
            {
                if ((number[i] != '0') || (number[i] != '1'))
                {
                    onlyBin = false;
                    Console.WriteLine("Érvénytelen");
                    break;
                }
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '1')
                {
                    db++;
                }
            }
            if (onlyBin == true)
            {
                Console.WriteLine("A megadott számsorozatban {0} db 1-es számjegy található", db);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Sorozatok
            // TBD

            // 2. Bináris

            string szam;
            Console.WriteLine("Adj meg egy bináris számsort: ");
            szam = Console.ReadLine();
            Binaris.CountOne(szam);

            Console.ReadLine();
        }
    }
}
