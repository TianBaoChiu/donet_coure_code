using System;
using System.Security.AccessControl;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //add、sub、mul、div
            int myInt = 5;
            int myInt2 = 6;

            myInt++;
            Console.WriteLine(myInt);

            myInt--; ;
            Console.WriteLine(myInt);

            myInt *= myInt2;

            Console.WriteLine(myInt);

            myInt /= myInt2;

            Console.WriteLine(myInt);

            //pow
            double myPowNum = Math.Pow(2, 3);
            Console.WriteLine(myPowNum);

            double mySqrtNum = Math.Sqrt(16);
            Console.WriteLine(mySqrtNum);

            //string with add  
            string myString = "Hello";
            myString += " Paul";
            Console.WriteLine(myString);

            //use backslash to escape the double quote
            myString += "\" and Marry\"";
            Console.WriteLine(myString);

            //use split to split the string
            String[] myStringArr = myString.Split(" ");
            Console.WriteLine(myStringArr[0]);
            Console.WriteLine(myStringArr[1]);
            Console.WriteLine(myStringArr[2]);
            Console.WriteLine(myStringArr[3]);

            //.Equals and "==", will be different when encounter the reference type(etc. class)
            int myInt3 = 5;
            int myInt4 = 5;
            Console.WriteLine(myInt3 == myInt4);
            Console.WriteLine(myInt3.Equals(myInt4));

            //Condition Operator
            //gt、lt、gte、lte
            int myInt5 = 6;
            int myInt6 = 5;
            Console.WriteLine(myInt5 > myInt6);
            Console.WriteLine(myInt5 < myInt6);
            Console.WriteLine(myInt5 >= myInt6);
            Console.WriteLine(myInt5 <= myInt6);


            int myInt7 = 20;
            int myInt8 = 10;

            if (myInt7 > myInt8)
            {
                Console.WriteLine("myInt7 is greater than myInt8");
            }
            else
            {
                Console.WriteLine("myInt7 is not greater than myInt8");
            }

            string myString2 = "Hello";
            string myString3 = "Hello";

            string myString4 = "hello paul";
            string myString5 = "HELLO PAUL";

            if (myString2 == myString3)
            {
                Console.WriteLine("myString2 is equal to myString3");
            }
            else
            {
                Console.WriteLine("myString2 is not equal to myString3");
            }

            //use StringComparison.OrdinalIgnoreCase to ignore the case
            if (myString4.Equals(myString5, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("myString4 is equal to myString5");
            }
            else
            {
                Console.WriteLine("myString4 is not equal to myString5");
            }

            //use ToLower to ignore the case  
            if (myString4.ToLower() == myString5.ToLower())
            {
                Console.WriteLine("myString4 is equal to myString5");
            }
            else
            {
                Console.WriteLine("myString4 is not equal to myString5");
            }

            //switch case
            int myInt9 = 6;
            switch (myInt9)
            {
                case 1:
                    Console.WriteLine("myInt9 is 1");
                    break;
                case 2:
                    Console.WriteLine("myInt9 is 2");
                    break;
                case 3:
                    Console.WriteLine("myInt9 is 3");
                    break;
                case 4:
                    Console.WriteLine("myInt9 is 4");
                    break;
                case 5:
                    Console.WriteLine("myInt9 is 5");
                    break;
                default:
                    Console.WriteLine("myInt9 is not 1,2,3,4,5");
                    break;
            }

            //Loops
            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //While loop
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            //Do While loop, while loop will check the condition first, do while loop will execute the code first
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);

            //foreach loop
            int[] myIntArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int l in myIntArray)
            {
                if (l >= 3)
                    Console.WriteLine(l);
            }

        }
    }
}