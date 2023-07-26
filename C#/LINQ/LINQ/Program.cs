
using LINQ;
using System;

delegate bool EligibilityCheck(People p); // delegate returns true or false

class program
{
    public static void Main(string[] args) // 
    {
        People[] people =
        {
            new People() { Name = "abc" , Age = 20 },
            new People() { Name = "qer" , Age = 30 },
            new People() { Name = "asd" , Age = 23 },
            new People() { Name = "tuty" , Age = 18 },
            new People() { Name = "try" , Age = 10 }
        };

        //People[] voters = new People[people.Length]; // voters is a array name 

        //int i = 0;
        //foreach ( People p in people )      // linque query
        //{
        //    if (p.Age >= 18)
        //    {
        //        voters[i++] = p;
        //        Console.WriteLine(p.Name);
        //    }
        //}
        ////----------------------------------------- using delegate method

        //List<People> voters = VoterCheck.where(people, delegate (People p)  // voters is a list
        //{

        //    return p.Age >= 18;
        //});
        //foreach (People voter in voters)
        //{
        //    Console.WriteLine(voter.Name);
        //}

        /*
        ////-------------------------------------------------------------
        //// using array
        Console.WriteLine("Name   Age");
        People[]voters = people.Where(p=> p.Age >=18).ToArray();
        foreach (var voter in voters)
        {
      
            Console.WriteLine(voter.Name + "   " + voter.Age);
        }

        ////----------------------------------------------------
        Console.WriteLine(" ---------------------------------    ");





       ////-------------------------------
       //// using list
       Console.WriteLine("Name   Age");
        List<People>vote = people.Where(p => p.Age >= 18).ToList();
        foreach (var voter in vote)
        {

            Console.WriteLine(voter.Name + "   " + voter.Age);
        }
        ////----------------------------------------------------
        Console.WriteLine(" ---------------------------------- ");





        ////-------------------------------------
        /// convert in to query syntex
       
        Console.WriteLine("Name   Age");
        var  vot = from p in people where p.Age >= 18 select p;
        foreach (var voter in vot)
        {

            Console.WriteLine(voter.Name + "   " + voter.Age);
        }
        */

        //----------------------------------------
        ExampleForClassification ex = new ExampleForClassification();
        ex.ex1(); // call the ex1 

    }
}