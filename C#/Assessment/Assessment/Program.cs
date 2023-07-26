// See https://aka.ms/new-console-template for more information

using Assessment;
using Assign_1;

internal class Program
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("1. usd 2. Eur 3. SriLanka 4.Singapore 5.Pakistan");
        //Console.WriteLine("choose the currency ");

        //double choise = Convert.ToDouble
        //    (Console.ReadLine());

        //switch (choise)
        //{
        //    case 1:
        //        Dollar dollar = new Dollar();
        //        dollar.Dolar();
        //        break;
        //    case 2:
        //        Euro eUR = new Euro();
        //        eUR.EUR();
        //        break;
        //    case 3:
        //        SriLanka sriLanka = new SriLanka();
        //        break;
        //    case 4:
        //        Singapore singapore = new Singapore();
        //        break;
        //    case 5:
        //        Pakistan pakistan = new Pakistan();
        //        break;
        //    default:
        //        Console.WriteLine("select any 1");
        //        break;
        //}

        //string filePath = @"C:\Users\archa\Downloads\Assessment\allyears.txt";
        //string filePathLeapYear = @"C:\Users\archa\Downloads\Assessment\leapyears.txt";
        //string filePathNonLeapYear = @"C:\Users\archa\Downloads\Assessment\nonleapyears.txt";

        //FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        //StreamWriter sw = new StreamWriter(fs);
        //for(int i = 2200; i < 2300;i++)
        //{
        //    sw.WriteLine(i);
        //}
        //sw.Close();
        //fs.Close();

        //fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //StreamReader sr = new StreamReader(fs);

        //fs = new FileStream(filePathLeapYear, FileMode.Create, FileAccess.Write);
        //StreamWriter swLeapYear = new StreamWriter(fs);
        //string line;
        //while ((line = sr.ReadLine()) != null)
        //{
        //    int year = int.Parse(line);

        //    if (year % 4 == 0)
        //    {
        //        swLeapYear.WriteLine(year);
        //    }
        //}
        //swLeapYear.Close();

        //fs = new FileStream(filePathNonLeapYear, FileMode.Create, FileAccess.Write);
        //StreamWriter swNonLeapYear = new StreamWriter(fs);
        //fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //sr = new StreamReader(fs);
        //while ((line = sr.ReadLine()) != null)
        //{
        //    int year = int.Parse(line);

        //    if (year % 4 != 0)
        //    {
        //        swNonLeapYear.WriteLine(year);
        //    }
        //}
        //swNonLeapYear.Close();
        //sr.Close();
        //fs.Close();


        //ElectricityBill eb = new ElectricityBill();
        //eb.EnterReading();
        //eb.CalculateBill();

        Example example = new Example();
    }

}
