using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorok
{
    class Sorozatok
    {
        public int[] numbers = new int[4];
        public int odds;
        public float quotient;

        public Sorozatok(int odds, float quotient)
        {
            this.odds = odds;
            this.quotient = quotient;
        }
        public Sorozatok()
        {
            this.odds = 0;
            this.quotient = 1;
        }

        public void Feltolt()
        {
            Console.WriteLine("Add meg a számsorozatot:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Szamtani()
        {
            odds = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                odds = numbers[i + 1] - numbers[i];
                Console.WriteLine(odds);
            }
        }

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
                    Console.WriteLine("Érvénytelen. Hibás adat: {0}", i);
                    break;
                }
            }

            if (onlyBin == true)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] != '1')
                    {
                        db++;
                    }
                }

                Console.WriteLine("A megadott számsorozatban {0} db 1-es számjegy található", db);
            }
        }
    }

    class Lotto
    {
        private int[] numbers = new int[5];
        Random rnd = new Random();

        public void Nyeroszamok()
        {
            Console.WriteLine("Az ötös lottó e heti nyerőszámai:");

            for( int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine(numbers[i]);
            }
        }
    }

    class Menu
    {
        private int button;

        public Menu(int button)
        {
            this.button = button;
        }

        public void Nyomogombok(int button)
        {
            Console.WriteLine("Menüü juhééj");
            while ()
            {
                switch //...
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Sorozatok
            Sorozatok s1 = new Sorozatok();
            //s1.Feltolt();
            //s1.Szamtani();

            // 2. Bináris

            /*
            string szam;
            Binaris b1 = new Binaris();
            Console.WriteLine("Adj meg egy bináris számsort: ");
            szam = Console.ReadLine();
            b1.CountOne(szam);
            */

            // 3. Lottó
            /*
            Lotto l1 = new Lotto();
            l1.Nyeroszamok();
            */

            // 4. Menü


            Console.ReadLine();
        }
    }
}
