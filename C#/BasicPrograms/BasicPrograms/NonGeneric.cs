using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonGeneric
    {

        public void ArrayListElements()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(10);
            numbers.Add(70);
            numbers.Add(30);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //numbers.Clear();
            //numbers.Sort();
            //numbers.Remove(10);
            //numbers.Average();




            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


        }
        public void StackElement()
        {
            Stack numbers = new Stack();
            numbers.Push(100);
            numbers.Push(200);
            numbers.Push(300);

            

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void HashElements()
        {
            //Hashtable stud = new Hashtable();
            Dictionary<int, int> stud = new Dictionary<int, int>();

            stud.Add(0, 034);
            stud.Add(1, 1954);
            stud.Add(2, 21233);
            stud.Add(3, 3567);


            foreach (int item in stud.Keys)
            {
                // Console.WriteLine(item);
                Console.WriteLine(item + ":" + stud[item]);
            }

            // Console.WriteLine(stud.Values);

            //foreach (int item in stud.Values)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine(stud[1]);
        }
    
}
}
