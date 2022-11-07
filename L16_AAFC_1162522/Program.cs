
using System;

namespace L16_AAFC_1162522
{
    class Program
    {

        public static int[,] tab = new int[40, 50];
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            Random rnd = new Random();


            for (int e = 0; e < 40; e++)
            {
             for (int f = 0; f < 50; f++)
                {
               tab[e, f] = rnd.Next(-100, 100);

                }
            }

            for (int e = 0; e < 40; e++)
            {
                for (int f = 0; f < 50; f++)
                {
                    if (tab [e, f] < 0)
                    {
                    

                        sum2 = sum2 + tab [e,  f];
                        
                    }




                }







            }

            for (int e= 0; e< 40; e ++)
            {


    for (int f = 0; f < 50; f++)
                {
                    
                    
                    
                    
                    if (tab [e, f] > 0)
                    {
                        
                        sum1 = sum1 + tab  [e, f];
                    
                    }


                }
            }


            Console.WriteLine("");
            Console.WriteLine(sum1);
            Console.WriteLine("");
            Console.WriteLine(sum2);
        }
    }
}


