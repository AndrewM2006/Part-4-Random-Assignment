using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_Random_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Part 1 - Random Integers");
            int num1, num2, random;
            num1=0; num2=0;
            bool valid=false;
            Console.WriteLine("Please Enter Two Integers");
            while (valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }
            valid = false;
            while(valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    valid = true;
                    Console.WriteLine("5 random values in that range are:");
                    for (int i = 0; i < 5; i++)
                    {
                        if (num1 >= num2)
                        {
                            random = generator.Next(num2, num1 + 1);
                            if (i <= 3)
                            {
                                Console.Write(random + ", ");
                            }
                            else
                            {
                                Console.WriteLine(random);
                            }
                        }
                        else
                        {
                            random = generator.Next(num1, num2 + 1);
                            if (i <= 3)
                            {
                                Console.Write(random + ", ");
                            }
                            else
                            {
                                Console.WriteLine(random);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }
            Console.WriteLine("Part 2 Dice Roller");
            int dice1, dice2;
            Console.WriteLine("Dice Roll 1 =");
            dice1 = generator.Next(1, 7);
            Console.WriteLine(dice1);
            Console.WriteLine("Dice Roll 2 =");
            dice2 = generator.Next(1, 7);
            Console.WriteLine(dice2);
            Console.WriteLine($"The sum of these rolls is equal to {dice1+dice2}.");
            Console.WriteLine("Part 3 Random Decimal Numbers");
            int decimals, precision, numberOfDigits;
            string stringPrecision;
            double num3, num4;
            Console.Write("How many decimals do you want in the random numbers? ");
            decimals= Convert.ToInt32(Console.ReadLine());
            Console.Write("Specify the decimal precision: .");
            precision = Convert.ToInt32(Console.ReadLine());
            stringPrecision = Convert.ToString(precision);
            numberOfDigits= Convert.ToInt32(stringPrecision.Length);
            num3 = +precision / numberOfDigits; num4 = +precision / numberOfDigits;
            Console.WriteLine("3 Random Numbers in that range are: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(generator.NextDouble() * (num3-num4) +num3);
            }
            Console.ReadLine();
        }
    }
}
