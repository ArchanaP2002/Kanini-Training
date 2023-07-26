// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
int num1, num2, ans;
num1 = Convert.ToInt16( Console.ReadLine());
num2 = Convert.ToInt16(Console.ReadLine());
ans = num1 + num2;
Console.WriteLine("result :" + ans);
*/
/*
int number = 8;
float flnum = number;
Console.WriteLine(flnum);
char ch = Convert.ToChar(flnum);
*/
//float ans =  Convert.ToDouble (Math.Sqrt(4));
/*
double ans = Math.Sqrt(4);
Console.WriteLine(ans);
Console.WriteLine(Math.Equals(ans, ans));

string s1 = "hi";
string s2 = "hello";
Console.WriteLine(s1.Equals(s2));
 

string s1 = "hello world";
string s2 = "hello";
Console.WriteLine(s1.Length);*/
//Console.WriteLine(s1.Substring ( 2));
//Console.WriteLine(s1.Substring(2,5));
//Console.WriteLine(s1.IndexOf('r'));
/*
string s1 = "hello world!";
string s2 = "hi";
Console.WriteLine(s1 + s2);
Console.WriteLine($"{s1}+{s2}");
*/
//int x = 5, y = 10;
//Console.WriteLine($"{x}_{y}");




using Basicprograms1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {

        //Animal dog = new Animal("dog",2,1,4,1);
        //Animal cow = new Animal("cow", 2, 1, 4, 1);
        //Animal cat = new Animal("cat", 2, 1, 4, 1);

        //cat.MakeSound(cat.Name);
        //dog.Type(dog.Name);
        //dog.MakeSound(dog.Name);
        //cow.Type(cow.Name);

        /*
        // Interface

        Add_Derive add_Derive = new Add_Derive();
        
        
        Console.WriteLine(add_Derive.intadd(1, 2));
        Console.WriteLine(add_Derive.stringadd("arcxf", "a"));
        */
        /*
        //Abstract class

        Interest interest = new Interest(10,1234566,"Archana",20000,0);
        double intamt = interest.CalculateInterest();
        Console.WriteLine(intamt);
        */

        //Console.WriteLine("Enter CollegeName, address, pincode, ");

        //string collegename = Console.ReadLine();
        //string address = Console.ReadLine();
        //int pincode =  Convert.ToInt32 ( Console.ReadLine()); 

        //Console.WriteLine( " EID,Name, Dept, Fav subject, Sal Ts ");
        //int eid = Convert.ToInt32 ( Console.ReadLine());
        //string name = Console.ReadLine();
        //string dept = Console.ReadLine();
        //string favsubject = Console.ReadLine();
        //double salary = Convert.ToDouble ( Console.ReadLine());

        //Console.WriteLine("Admin staff- EID, name, sal");
        //int aeid = Convert.ToInt32(Console.ReadLine());
        //string aname = Console.ReadLine();
        //double asalary = Convert.ToDouble(Console.ReadLine());

        //Teaching_staff teaching_Staff = new Teaching_staff( collegename, address, pincode, 
        //    eid, name, dept, favsubject, salary);
        //Admin_staff admin_Staff = new Admin_staff( collegename, 
        //    address, pincode, aeid, aname, asalary);

        // double tsal= teaching_Staff.Calculatesalary();
        // double asal =admin_Staff.Calculatesalary();

        //Console.WriteLine("\nCollege Name:" + teaching_Staff.Collegename +
        //    "\nTs Emp Name:" + teaching_Staff.Name +
        //    "\nTs salary:" + tsal +
        //    "\nAs Emp Name:" + admin_Staff.Name +
        //    "\nAs salary:" + asal);




        //Console.WriteLine("Enter Roll Number, Name ,3marks");
        //int rno= Convert.ToInt32(Console.ReadLine());
        //string name = Console.ReadLine();
        //double mark1 = Convert.ToDouble(Console.ReadLine());
        //double mark2 = Convert.ToDouble(Console.ReadLine());
        //double mark3 = Convert.ToDouble(Console.ReadLine());

        //Student_Calculation student_Calculation = new(rno, name, mark1, mark2, mark3,0,0);

        //student_Calculation.Calculate();

        //Console.WriteLine("R No:" + student_Calculation.Rno +
        //    "Name:" + student_Calculation.Name +
        //    "Total" + student_Calculation.Tot +
        //    "Average" + student_Calculation.Avg);

        // ControlStatement controlStatement = new ControlStatement();


        /*string str1 = Console.ReadLine();
        controlStatement.Foreachfn(str1);
        */
        //controlStatement.arraydisp();
        //controlStatement. Loopfn();
        //controlStatement.Big3num();
        /*
                Console.WriteLine(" S ==> 2 numbers M ==> 3 numbers");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    /* case 'S':
                     case 's':
                         controlStatement.Big2num();
                         break;

                    case ('s' or 'S'):
                        controlStatement.Big2num();
                        break;
                    case 'M':
                    case 'm':
                        controlStatement.Big3num();
                        break;
                    default:
                        Console.WriteLine(" Enter S or M");
                        break;
                } */

        // Console.WriteLine("Enter The Customer id," + "AccountNumber, Name, Balance");
        //int custid = Convert.ToInt32(Console.ReadLine());
        //  int accno = Convert.ToInt32(Console.ReadLine());
        // string accname = (Console.ReadLine());
        // decimal balance = Convert.ToDecimal(Console.ReadLine());
        //bankTransactions.ReadCustomerDetails();
        //bankTransactions.PerformTransactions();
        //BankTransactions bankTransactions = new BankTransactions(custid, accno, accname,balance);
        //bankTransactions.WriteCustomerDetails();

        //15 i
        //int num;
        //Console.WriteLine("Enter the Number : ");
        //num = Convert.ToInt32(Console.ReadLine());
        //ass_func ass_Func = new ass_func();
        //if (ass_Func.palindrom_number(num))
        //{
        //    Console.WriteLine(num + " is Palindrome");
        //}
        //else
        //{
        //    Console.WriteLine(num + " is not a palindrome");
        //}
        /*
     //15 ii
     string word;
     Console.WriteLine("Enter the string : ");
     word = Console.ReadLine();
     ass_func ass_Func = new ass_func();
     if (ass_Func.palindrom_string(word))
     {
         Console.WriteLine($"{word} is palindrome");
     }
     else
     {
         Console.WriteLine($"{word} not is palindrome");
     }


     //14
     int number;
     Console.WriteLine("Enter the Number : ");
     number = Convert.ToInt32(Console.ReadLine());
     ass_func ass_Func = new ass_func();
     if (ass_Func.prime_number(number))
     {
         Console.WriteLine(number + " is prime number");
     }
     else
     {
         Console.WriteLine(number + " is not a prime number");
     }



     //13
     int num;
     Console.WriteLine("Enter the number :");
     num = Convert.ToInt32(Console.ReadLine());
     ass_func ass_Func = new ass_func();
     ass_Func.perfect_number(num);



     //12
     int num1;
     Console.WriteLine("Enter the number :");
     num1 = Convert.ToInt32(Console.ReadLine());
     ass_func ass_Func = new ass_func();
     ass_Func.Armstrong_number(num1);



     //11
     int limit;
     Console.WriteLine("Enter the number :");
     limit = Convert.ToInt32(Console.ReadLine());
     ass_func ass_Func = new ass_func();
     ass_Func.Fibonacci_sequence(limit);


     //10
     string str;
     Console.WriteLine("Enter the string :");
     str = Console.ReadLine();
     ass_func ass_Func = new ass_func();
     ass_Func.middle_char_string(str);


     //9
     string str;
     Console.WriteLine("Enter the string :");
     str = Console.ReadLine();
     ass_func ass_Func = new ass_func();
     ass_Func.number_of_char_string(str);


     //8
     string str;
     Console.WriteLine("Enter the string :");
     str = Console.ReadLine();
     ass_func ass_Func = new ass_func();
     ass_Func.number_of_words_string(str);



     //6
     int row, col, i, j;
     Console.WriteLine("Enter the Number of rows and columns :");
     row = Convert.ToInt32(Console.ReadLine());
     col = Convert.ToInt32(Console.ReadLine());
     int[,] arr = new int[row, col];
     Console.WriteLine("Enter the Matrix :");
     for (i = 0; i < row; i++)
     {
         for (j = 0; j < col; j++)
         {
             arr[i, j] = Convert.ToInt32(Console.ReadLine());
         }
     }
     ass_func ass_Func = new ass_func();
     ass_Func.transpose_matrix(arr, col, row);


     //5
     int index, i;
     Console.WriteLine("Enter the index of the array :");
     index = Convert.ToInt32(Console.ReadLine());
     int[] arr = new int[index];
     Console.WriteLine("Enter the array :");
     for (i = 0; i < index; i++)
     {
         arr[i] = Convert.ToInt32(Console.ReadLine());
     }
     ass_func ass_Func = new ass_func();
     ass_Func.array_reverse(arr, index);
     ass_Func.array_copy(arr, index);
     ass_Func.sum_array(arr, index);
     ass_Func.duplicate_elements(arr, index);
     ass_Func.unique_elements(arr, index);
     ass_Func.second_largenum(arr, index);




     //3
     int customerid;
     string name;
     int unit;
     Console.WriteLine("Enter the Customer id, Name, Unit consumed :");
     customerid = Convert.ToInt32(Console.ReadLine());
     name = Console.ReadLine();
     unit = Convert.ToInt32(Console.ReadLine());
     ElectricityBill electricityBill = new ElectricityBill(customerid, name, unit);
     double bill = electricityBill.Ebill();
     if (bill >= 100)
     {
         Console.WriteLine($"Customer id: {electricityBill.Customerid}\n Name: {electricityBill.Name}\n Unit Consumed: {electricityBill.Unit}\n Total Amount: {bill}");
     }
     else
     {
         Console.WriteLine("Your bill is lower than 100 rupee");
     }

     //7
     int index, i;
     Console.WriteLine("Enter the index of the array :");
     index = Convert.ToInt32(Console.ReadLine());
     int[] arr = new int[index];
     Console.WriteLine("Enter the array :");
     for (i = 0; i < index; i++)
     {
         arr[i] = Convert.ToInt32(Console.ReadLine());
     }
     ass_func ass_Func = new ass_func();
     ass_Func.sum_of_prime_array(arr, index);
     //4
     int ran;
     Console.WriteLine("Enter the value: ");
     ran = Convert.ToInt32(Console.ReadLine());
     ass_func ass_Func = new ass_func();
     ass_Func.pattern(ran);
     */

        //2
        //string name;
        //int roll_no;
        //double phy_mark, com_mark, che_mark;
        //Console.WriteLine("Enter the Name, roll number, subject marks :");
        //name = Console.ReadLine();
        //roll_no = Convert.ToInt32(Console.ReadLine());
        //phy_mark = Convert.ToDouble(Console.ReadLine());
        //che_mark = Convert.ToDouble(Console.ReadLine());
        //com_mark = Convert.ToDouble(Console.ReadLine());
        //Studentmark student_mark = new Studentmark(name, roll_no, phy_mark, che_mark, com_mark);
        //student_mark.studtotal_per();

        //if (student_mark.Percentage >= 80)
        //{
        //    Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
        //        $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
        //        $" Percentage = {student_mark.Percentage}\n Division = First");
        //}
        //else if (student_mark.Percentage >= 65 && student_mark.Percentage < 80)
        //{
        //    Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
        //        $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
        //        $" Percentage = {student_mark.Percentage}\n Division = Second");
        //}
        //else if (student_mark.Percentage >= 50 && student_mark.Percentage < 65)
        //{
        //    Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
        //       $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
        //       $" Percentage = {student_mark.Percentage}\n Division = Third");
        //}
        //else
        //{
        //    Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
        //       $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
        //       $" Percentage = {student_mark.Percentage}\n Division = Failed");
        //}


        //1
        //int co1, co2;
        //Console.WriteLine("Enter the Coordinate X :");
        //co1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the Coordinate Y :");
        //co2 = Convert.ToInt32(Console.ReadLine());
        //Coordinates coordinates = new Coordinates();
        //coordinates.cordinate(co1, co2); 

        //---------------------------------------------


        //Static_Demo

        Static_Demo demo = new Static_Demo();
   Static_Demo .cal();
        Console.WriteLine(Static_Demo.Amt);



    }


}


