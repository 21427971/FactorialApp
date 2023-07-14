using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApp
{
    class Program
    {//Msimango KSI
        static void Main()
        {//C# .NET program to generate the factorial of a number.
            int count, Num, Fact=1;
            Console.Write("Enter a Number! = ");
            Num = int.Parse(Console.ReadLine());
           for(count=1;count<=Num;count++)
            {//The product of all desc positive integers
                Fact = Fact * count;
                    //e.g N!=5,the Factorial of N will be 5=5*4*3*2*1
                    //N!=120
                    
                Console.WriteLine("x{0}",count);//Print count
            }
           // Console.WriteLine(Fact);Print factorial
            Console.WriteLine($"The Factorial of : {Num}! is {Fact}");
            Console.WriteLine("*Factorial is a product of all desc positive integers*");
        }
    }
}

