using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Example
    {
        static void Main()
        {
            string ignorePhrase = "fox";
            int numLines = 2;

            if (!File.Exists(@"example.txt"))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("example.txt"))
                {
                    for (int i = 1; i <= numLines; i++)
                    {
                        Console.Write("Input line {0}: ", i);
                        string line = Console.ReadLine();

                        if (!line.Contains(ignorePhrase))
                        {
                            writer.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("The line has been ignored which contains the string '{0}'.", ignorePhrase);
                        }
                    }
                }
                using (StreamReader reader = new StreamReader("example.txt"))
                {
                    Console.WriteLine("The content of the file is:");
    
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing to or reading from the file:");
                Console.WriteLine(e.Message);
            }
        }
        }
}
