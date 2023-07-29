using System;
using static System.Net.Mime.MediaTypeNames;

//ref link:https://www.youtube.com/watch?v=gB6mFHh9R4Y&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=3
// ctrl+k+c -- comment line
// arrays are not flexible but extremely fast because of data alignment

class MainClass
{
    static void Main()
    {
        //int[] ages = new[] { 25, 27, 23, 34, 36 };
        //int totalAge = 0;
        //foreach (int element in ages)
        //{
        //    Console.WriteLine(element);
        //    totalAge += element;
        //}
        //Console.WriteLine(totalAge);
        int[] ages = new[] { 
            25, 27, 23, 34, 36 
        };

        //int[] temp = new int[ages.Length + 1];
        //Array.Copy(ages, temp, ages.Length); // built-in for loop
        Array.Resize(ref ages, 7);
        //for (int i = 0; i < ages.Length; i++)
        //    temp[i] = ages[i];
        //ages = temp;
        ages[5] = 99;
        ages[6] = 101;
    }
}