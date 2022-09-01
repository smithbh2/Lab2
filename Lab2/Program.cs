namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Num1 = new int();
            int Num2 = new int();
            int Sum = new int();
            Console.WriteLine("Please enter your first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Sum = Num1 + Num2;
            Console.WriteLine($"{Num1} + {Num2} = {Sum}");


        }
    }
}