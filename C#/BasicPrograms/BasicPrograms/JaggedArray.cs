using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class JaggedArray
    {
        public void  display() 
        {
            int[][] num = new int[2][];
            num[0] = new int [] { 1,3,5};
            num[1] = new int[] { 10, 30, 35 };

            Console.WriteLine(num[1][2]);

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Row(0):",i);

                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write("0:"+num[i][j]);
                }
                Console.WriteLine();
            }

        }
        
    }
}
