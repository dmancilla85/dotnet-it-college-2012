using System;
class PrintArray
{
    public static void Main(String[] args)
    {

        int[] x = { 10, 20, 30, 40, 50 };
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine(x[i]);
        }
    }
}

//using System;
//class Printlength
//{
//  public static void Main(String[] args)
//  {

//    int[] x = {10,20,30,40,50};
//    for(int i = 0; i<x.Length;i++)
//    {
//      Console.WriteLine(x[i]);
//    }
//  }
//}

//using System;
//class Multi
//{
//  public static void Main()
//  {
//    int[,]x;
//    x = new int[4,4];
//    x[0,0] = 1;
//    x[1,1] = 1;
//    x[2,2] = 1;
//    x[3,3] = 1;
//    Console.WriteLine(x[0,0] +" " +x[0,1] + " " +x[0,2] + " "+x[0,3]);
//    Console.WriteLine(x[1,0] +" " +x[1,1] + " " +x[1,2] + " "+x[1,3]);
//    Console.WriteLine(x[2,0] +" " +x[2,1] + " " +x[2,2] + " "+x[2,3]);
//    Console.WriteLine(x[3,0] +" " +x[3,1] + " " +x[3,2] + " "+x[3,3]);
//  }
//}
