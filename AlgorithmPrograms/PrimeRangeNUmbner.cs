using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeRangeNUmbner
    {
        public void PrimeRange()
        {
            int range = 1000;
            for (int i = 0; i < range; i++)
            {
                int flag = 0;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                       // break;
                    }
                }
                if (flag == 0 && i!=1)
                {
                    Console.WriteLine(i + "Prime number");
                }
            }
             
        }
    }
}
