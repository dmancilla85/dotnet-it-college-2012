using System;
class MyClient
{
    public static void Main()
    {
       

        try
        {
         int x = 0;
        int div = 100 / x;
        Console.WriteLine(div);
        }
        catch (DivideByZeroException ex1)
        {
            Console.WriteLine(ex1.Message);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
       
    }
}


//using System;
//class MyClient
//{
// public static void Main()
// {
//  int x = 0;
//  int div = 0;
// try
// {
//  div = 100/x;
//  Console.WriteLine("This line in not executed");
// }
// catch(DivideByZeroException de)
// {
//  Console.WriteLine("Exception occured: {0}", de.Message);
// }
// Console.WriteLine("Result is {0}",div);
// Console.ReadLine();
// }
//}



//using System;
//class MyClient
//{
// public static void Main()
// {
//  int x = 0;
//  int div = 0;
// try
// {
//  div = 100/x;
//  Console.WriteLine("This line in not executed");
// }
// catch(DivideByZeroException de)
// {
//  Console.WriteLine("Exception occured: {0}",de.Message);
// }
// Console.WriteLine("Result is {0}",div);
// Console.ReadLine();
// }
//}


////C#: Exception Handling: Multiple catch
//using System;
//class MyClient
//{
// public static void Main()
// {
//  int x = 0;
//  int div = 0;
// try
// {
//  div = 100/x;
//  Console.WriteLine("Not executed line");
// }
// catch(DivideByZeroException de)
// {
//  Console.WriteLine("DivideByZeroException" );
// }
// catch(Exception ee)
// {
//  Console.WriteLine("Exception" );
// }
// finally
// {
//  Console.WriteLine("Finally Block");
// }
// Console.WriteLine("Result is {0}",div);
// }
//}

