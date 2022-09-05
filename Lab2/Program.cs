using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //The simply intake of user variables to complete the addition request of problem one.
            int num1 = new int();
            int num2 = new int();
            int sum = new int();
            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");

            //The simply intake of user variables to answer problem twos multiplication.
            int num3 = new int();
            int num4 = new int();
            int product = new int();

            Console.WriteLine("Please enter your base number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your top multiplier: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= num4; i++)
            {
                product = num3 * i;
                Console.WriteLine($"{num3} x {i} = {product}");
            }

            //The print out of information need about data types for problem three, displayed using built in methods.
            Console.WriteLine("The type sbyte uses "+sizeof(sbyte)+" bytes in memory and has a max value of "+ sbyte.MaxValue+" and a min value of "+ sbyte.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(byte)+" bytes in memory and has a max value of "+ byte.MaxValue+" and a min value of "+ byte.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(short)+" bytes in memory and has a max value of "+ short.MaxValue+" and a min value of "+ short.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(ushort)+" bytes in memory and has a max value of "+ ushort.MaxValue+" and a min value of "+ ushort.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(int)+" bytes in memory and has a max value of "+ int.MaxValue+" and a min value of "+ int.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(uint)+" bytes in memory and has a max value of "+ uint.MaxValue+" and a min value of "+ uint.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(long)+" bytes in memory and has a max value of "+ long.MaxValue+" and a min value of "+ long.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(ulong)+" bytes in memory and has a max value of "+ ulong.MaxValue+" and a min value of "+ ulong.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(float)+" bytes in memory and has a max value of "+ float.MaxValue+" and a min value of "+ float.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(double)+" bytes in memory and has a max value of "+ double.MaxValue+" and a min value of "+ double.MinValue);
            Console.WriteLine("The type sbyte uses "+sizeof(decimal)+" bytes in memory and has a max value of "+ decimal.MaxValue+" and a min value of "+ decimal.MinValue);


            //The variables needed run the calculator as well as the while loop and switch statment that makes it function. 
            double probFourFirstValue = new double();
            double probFourSecondValue = new double();
            double finalValue = new double();

            bool loopBreak = true;
            while (loopBreak == true)
            {
                Console.WriteLine("Which operation would you like to perform? Enter '1' for addition, '2' for subtraction, '3' for multiplication, '4' for division, '5' for modulus, or '6' to escape.");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Please enter your first value: ");
                        probFourFirstValue = Convert.ToDouble (Console.ReadLine());
                        Console.WriteLine("Please enter your second value: ");
                        probFourSecondValue = Convert.ToDouble(Console.ReadLine());
                        finalValue = probFourFirstValue + probFourSecondValue;
                        Console.WriteLine("Your final value is: " + finalValue);
                        break;

                    case 2:
                        Console.WriteLine("Please enter your first value: ");
                        probFourFirstValue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter your second value: ");
                        probFourSecondValue = Convert.ToDouble(Console.ReadLine());
                        finalValue = probFourFirstValue - probFourSecondValue;
                        Console.WriteLine("Your final value is: " + finalValue);
                        break;

                    case 3:
                        Console.WriteLine("Please enter your first value: ");
                        probFourFirstValue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter your second value: ");
                        probFourSecondValue = Convert.ToDouble(Console.ReadLine());
                        finalValue = probFourFirstValue * probFourSecondValue;
                        Console.WriteLine("Your final value is: " + finalValue);
                        break;

                    case 4:
                        Console.WriteLine("Please enter your first value: ");
                        probFourFirstValue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter your second value: ");
                        probFourSecondValue = Convert.ToDouble(Console.ReadLine());
                        finalValue = probFourFirstValue / probFourSecondValue;
                        Console.WriteLine("Your final value is: " + finalValue);
                        break;

                    case 5:
                        Console.WriteLine("Please enter your first value: ");
                        probFourFirstValue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter your second value: ");
                        finalValue = probFourFirstValue % probFourSecondValue;
                        Console.WriteLine("Your final value is: " + finalValue);
                        break;

                    case 6:
                        Console.WriteLine("You have exited the calculator loop.");
                        loopBreak = false;
                        break;
                }
            }
        }
    }
}
