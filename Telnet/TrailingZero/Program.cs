using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZero
{
    class Program
    {
        static void Main(string[] args)
        {

            int count, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (count = 1; count <= number; count++)
            {
                fact = fact * count;
            }
            var FactStr = fact.ToString();
            var ArrStr = FactStr.Split();
            int Digitcount = 0;
            foreach (var item in ArrStr)
            {
                for (int i = 0; i < ArrStr.Count(); i++)
                {
                    if (int.Parse(ArrStr[i])==0)
                    {
                        Digitcount++;
                        
                    }
                    
                }
                
                
            }


            Console.Write("The number of Trailing Zeros  is: " + Digitcount++);

        }
    }
}
