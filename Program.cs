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
            int decimals, numberOfDigits;
            string stringPrecision, formatedNumber;
            double num3, num4, randomDouble, precision;
            Console.Write("How many decimals do you want in the random numbers? ");
            valid = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out decimals))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }while (valid==false);
            Console.Write("Specify the decimal precision: .");
            valid = false;
            do
            {
                if (Double.TryParse(Console.ReadLine(), out precision))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                    Console.Write(".");
                }
            }while (valid==false);
            stringPrecision = Convert.ToString(precision);
            numberOfDigits= Convert.ToInt32(stringPrecision.Length);
            num3 =num1+precision / (numberOfDigits*10); num4 = num2+precision / (numberOfDigits*10);
            Console.WriteLine("3 Random Numbers in that range are: ");
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    randomDouble = generator.NextDouble() * (Math.Max(num3, num4) - Math.Min(num4, num3) + Math.Min(num3, num4));
                    randomDouble = Math.Round(randomDouble, decimals);
                
                } while (randomDouble >= Math.Max(num3, num4) && randomDouble <= Math.Min(num4, num3));
                formatedNumber = randomDouble.ToString("F" + decimals);
                Console.WriteLine($"Random Number {i + 1}:{formatedNumber}");
            }
            Console.ReadLine();
        }
    }
}
