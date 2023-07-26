
// short key for command = ctrl+k and ctrl+c
// short key for uncommand = ctrl+k and ctrl+u

using GenDel;

public delegate int MyDelegate();// for returning in delegate 
//public delegate void MyDelegate(string message); // delegates are write outside the class. mydelegate is name you can change .


class Program
{
    //public static ArithmeticException arithmeticException; // for exception generic constraints 

    //static void Swap<T>(ref T num1, ref T num2) //ref means passing reference
    //{
    //    T temp;
    //    temp = num1;
    //    num1 = num2;
    //    num2 = temp;


    //}
    //static void InvokeDelegate(MyDelegate del) //Delegate invoke  del is a parameter 
    //{
    //    del("Hi");
    //}


    public static void Main (string[] args)     // or public static void Main (string[] args,ArithmeticException arithmeticException) for arithmetic exception.
    {
        //GenUse<int> guint = new GenUse<int>(10);
        //GenUse<double> gudbl = new GenUse<double>(10.10);
        //GenUse<string> gustr = new GenUse<string>("hello");

        //Console.WriteLine(guint.Num);
        //Console.WriteLine(gudbl.Num);
        //Console.WriteLine(gustr.Num);
        //-----------------------------------------

        //GenUse<int>intarr = new GenUse<int> (500);
        //for (int i = 0; i < 500; i++)
        //{
        //    intarr.setarr(i, ((i+1)*10));
        //}
        //for(int i = 0;i < 500; i++)
        //{
        //   Console.WriteLine("intarr  "+ intarr.getarr(i));

        //}
        //Console.WriteLine("_------------");
        //GenUse<char> chararr = new GenUse<char>(26);
        //for (int i = 0; i < 26; i++)
        //{
        //    chararr.setarr(i,  Convert.ToChar(i+65));
        //}
        //for (int i = 0; i < 26; i++)
        //{
        //    Console.WriteLine("chararr  "+chararr.getarr(i));
        //}
        //---------------------------------------------------------------------------

        //GenUse <ArithmeticException> ae = new GenUse<ArithmeticException>(arithmeticException); //new is a constructor call 
        //Console.WriteLine(value: ae.disp().Message);
        //-----------------------------------------------------------------------

        //int n1 = 10, n2 = 20;

        //char c1 = 'a', c2 = 'b';

        //Swap(ref n1, ref n2);
        //Swap<char>(ref c1, ref c2);

        //Console.WriteLine("A = {0}  B = {1}",n1,n2);
        //Console.WriteLine("C = {0}  D = {1}",c1,c2);
        //--------------------------------------------------------------------------------

        //Delegates 

        // MyDelegate del = new MyDelegate(DelUse.Method1);//or
        //// MyDelegate del = DelUse.Method1; // you can write both type
        //del.Invoke("Pass a message what you want");//or
        //del("Pass a message what you want"); // both are working same invoke is just a key word

        //MyDelegate del1, del2;
        //del1 = DelUse.Method1;
        ////del.Invoke("Pass a message what you want"); 
        //del2 = DelUse1.Method1;
        ////del.Invoke(" message");

        //InvokeDelegate(del1);
        //InvokeDelegate(del2);

        //Multi Csting delegates ------------- 

        MyDelegate del1 = DelUse.Method1; // invoking the class with the method 
        MyDelegate del2 = DelUse1.Method2;
        MyDelegate del = del1 + del2;
        Console.WriteLine(del());
     
        //addition  + or +=
        //MyDelegate del = del1 + del2;      
        //del(123);

        //// subraction - or -=

        //MyDelegate dell = del1 + del2 - del2;
        //dell(123);
    }
}