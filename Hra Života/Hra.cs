using System;
using System.Collections.Generic;
using System.Text;

namespace Hra_Života
{
    public class Hra
    {
        const int SIRKA = 5;
        const int VYSKA = 5;

        public Bunka[,] hraciDeska;

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

          

            for (int i = bunka.PosX - 1; i < bunka.PosX + 1; i++) 
            {
                for (int j = bunka.PosY - 1; j < bunka.PosY + 1; j++)
                {
                    if (i == bunka.PosX && j == bunka.PosY)
                    {
                        continue;
                    } else
                    {
                        try
                        {

                            Bunka sousedniBunka = hraciDeska[bunka.PosX + 1, bunka.PosY + 1];

                            if (sousedniBunka.JeZiva) celkovyPocet++;


                        }
                        catch (IndexOutOfRangeException e)
                        {
                            continue;
                        }
                    }
                }
            }

            return celkovyPocet;
        }
    }
}
