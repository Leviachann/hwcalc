using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Please enter a number! ");
        double firstnum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an opeator: ");
        string op = Console.ReadLine();

        Console.Write("Please enter another number! ");
        double secondnum = Convert.ToDouble(Console.ReadLine());

        Console.Write(Calc(firstnum, op, secondnum));

        Console.ReadLine();
    }
    static double Calc(double num1, string opera, double num2)
    {
        switch (opera)
        {
            case "+":
                return (num1 + num2);
            case "-":
                return (num1 - num2);
            case "*":
                return (num1 * num2);
            case "/":
                return (num1 / num2);
            default:
                return 0;
        }
    }
}
