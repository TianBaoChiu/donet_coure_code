using System;
using System.Net;

namespace method_and_scope
{
    class Program
    {
        int Num1 = 10;        //instance variable, can be accessed by all methods,and should named with pascal case
        static int Num2 = 20; //static variable, can be accessed by static methods, and should named with pascal case

        static void Main(string[] args)
        {
            int sum = GetSum();
            Console.WriteLine("Sum of the array is: " + sum);

            int sum2 = GetSum(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Sum of the array is: " + sum2);

            // Scope();//static method can't access instance function
            Scope2();
            Scope3();
        }
        static private int GetSum()
        {
            int total_sum = 0;
            int[] myIntArr = new int[] { 1, 2, 3, 4, 5 };
            foreach (int num in myIntArr)
            {
                total_sum += num;
            }

            return total_sum;
        }

        static private int GetSum(int[] myIntArr) //function overloading with different parameters
        {
            int total_sum = 0;
            foreach (int num in myIntArr)
            {
                total_sum += num;
            }

            return total_sum;
        }

        //scope of the variable
        //instance function can access both static and instance variables
        void Scope()
        {
            int x = 10;
            if (x == 10)
            {
                int y = 20;
                Console.WriteLine("x and y: " + x + " " + y);
            }
            Console.WriteLine("x: " + x);
            //Console.WriteLine("y: " + y); //error

            Console.WriteLine("Num1: " + Num1);
        }

        //scope of the variable
        //static function can only access static variables
        static private void Scope2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i: " + i);
            }
            //Console.WriteLine("i: " + i); //error
            Console.WriteLine("Num2: " + Num2);
        }

        static private void Scope3()
        {
            //Console.WriteLine("Num1: " + Num1);
            int Num1 = 30; //local variable
            Console.WriteLine("Num1: " + Num1);
        }
    }
}