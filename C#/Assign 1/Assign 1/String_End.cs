using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class String_End
    {

        public static string[] AddStringEnding(string[] arr, string ending)
        {
            string[] result = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] + ending;
                Console.Write(arr[i] + " ");
            }

            return result;
        }

    }
}
