﻿using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8

            // 1 byte (8 bit) unsigned, where signed means it can be negative
            byte myByte = 255;
            byte mySecondByte = 0;

            // 1 byte (8 bit) signed, where signed means it can be negative
            sbyte mySbyte = 127;
            sbyte mySecondSbyte = -128;


            // 2 byte (16 bit) unsigned, where signed means it can be negative
            ushort myUshort = 65535;

            // 2 byte (16 bit) signed, where signed means it can be negative
            short myShort = -32768;

            // 4 byte (32 bit) signed, where signed means it can be negative
            int myInt = 2147483647;
            int mySecondInt = -2147483648;

            // 8 byte (64 bit) signed, where signed means it can be negative
            long myLong = -9223372036854775808;

            //注意: float類型需要用f標識
            // 4 byte (32 bit) floating point number
            float myFloat = 0.751f;
            float mySecondFloat = 0.75f;
            //注意:double類型需要用d標識
            // 8 byte (64 bit) floating point number
            double myDouble = 0.751;
            double mySecondDouble = 0.75d;
            //注意：decimal類型需要用m標識
            // 16 byte (128 bit) floating point number
            decimal myDecimal = 0.751m;
            decimal mySecondDecimal = 0.75m;

            // Console.WriteLine(myFloat - mySecondFloat);
            // Console.WriteLine(myDouble - mySecondDouble);
            // Console.WriteLine(myDecimal - mySecondDecimal);

            //注意：char類型需要用單引號括起來
            char myChar = 'A';
            Console.WriteLine(myChar);

            //注意：string類型需要用雙引號括起來
            string myString = "Hello World";
            // Console.WriteLine(myString);
            string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // Console.WriteLine(myStringWithSymbols);

            //array，固定靜態大小，不能動態增加或減少，可以用List來代替

            //after  C# 版本 11 或更新版本可以用這個 List Patterns
            int[] myIntArray1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //舊版的需要使用{}來定義，一旦省略new int[]，就不能指定長度且需要再宣告時同時初始化
            //int[] myIntArray = {1,2,3 ,4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(myIntArray1[0]);

            //使用new 來定義可以指定長度，並且可以直接指派元素
            // int[] myIntArray = new int[10];
            int[] myIntArray2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(myIntArray2[1]);


            //2D array
            int[,] my2DArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("my2DArray[1,1] " + my2DArray[1, 1]);

            int[,,] my3DArray = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine("my3DArray[1,1,1] " + my3DArray[1, 1, 1]);

            //List，可以動態增加或減少，但是不能用[]來取值，只能用Add()來增加
            // List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<string> myList = new List<string>();
            myList.Add("apple");
            myList.Add("banana");
            Console.WriteLine("myList[0] = " + myList[0]);

            //enumerate，可以用foreach來遍歷，IEnumerable<string>是一個接口，可以用來定義一個集合，但是不能用來實例化一個對象
            IEnumerable<string> myEnumerable = myList;
            //ToList()可以將IEnumerable轉換為List
            List<string> mySecondList = myEnumerable.ToList();


            //dictionary，key-value pair，key不能重複，一樣使用Add()來增加
            Dictionary<string, int> myDic = new Dictionary<string, int>();
            myDic.Add("apple", 1);
            myDic.Add("banana", 2);
            Console.WriteLine("myDic[apple] = " + myDic["apple"]);



        }
    }
}


