using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {


        // task 1
        /* static void Lol(ref int a , ref int b,ref int c)
         {

             a = b;
             b = c;
             c = a;
         }
         static void Main(string[] args)
         {

             int a = 1;
             int b= 2;    
             int c = 3;

             WriteLine ($" No swap =  {a} {b} {c}");

             Lol(ref a,ref b,ref c);

             WriteLine ($"After swap = {a} {b} {c}");

         }
        */

        //task 2

        //static void Func(ref int x, ref int y, ref int z)
        //{
        //    int[] array = { x, y, z };
        //    Array.Sort(array);

        //    foreach(int numbers in array)
        //    {
        //        Console.WriteLine(numbers);
        //    }
        //}

        //   static void Main(string[] args) 
        //   {
        //     int[]omas=new int[3];
        //     for(int i = 0; i < 3; i++) 
        //     {
        //        Write($"Enter numb{i+1}= ");
        //        omas[i] = int.Parse(Console.ReadLine());

        //     }

        //    Func(ref omas[0], ref omas[1], ref omas[2]);


        //   }


        // task 3
        //static void Func(double rad)
        //   {
        //    const double Pi = 3.14159;
        //    double length=(Pi*2)*rad;   
        //           double res =  Pi * (Math.Pow(rad, 2));
        //    WriteLine($"Square= radius {rad}^2 + 3.14= " + res);
        //    WriteLine($"Circle length {length}");

        //}

        //static void Main(string[] args) 
        //{
        //    Write("Enter RAD value = ");
        //    double rad=double.Parse(Console.ReadLine());

        //    Func( rad);
        //}

        static void Str(string str,char words)
        {
            int count = 1;

            foreach ( char caracter  in str) 
            {
                if (caracter == words)
                {
                   
                    Write(words);

                 
                }


                count++;

            }

            
        }

        static void Main(string[] args)
        {
            Write("Enter an sentences= ");
            string str = Console.ReadLine();
            Write("Enter SYMBOL= ");
            char words =Convert.ToChar(Console.ReadLine());

            Str(str,words);
        }


    }
}

