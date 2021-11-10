using System;
using System.Collections.Generic;
using System.Text;

namespace Hra_Života
{
    class Hra
    {
        const int SIRKA = 5;
        const int VYSKA = 5;

        Bunka[,] hraciDeska;

        public Hra()
        {
            Random random = new Random();
            
            hraciDeska = new Bunka[SIRKA, VYSKA];
            for (int i = 0; i < VYSKA; i++)
            {
                for (int x = 0; x < SIRKA; x++)
                {
                    int rnd = random.Next(2);
                    bool zivost = (rnd == 0);
                    hraciDeska[i, x] = new Bunka(zivost, i, x);
                }
            }
        }


        public int OkoliBunkyZive(Bunka bunka)
        {
            if (bunka == null) return -1;
            int celkovyPocet = 0;


            
            return 0;
        }
    }
}
