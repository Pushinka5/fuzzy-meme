internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(PrintNumbers(n));

        string PrintNumbers(int number)
        {
            if (number == 1) return "1";
            return number + " " + RrintNumbers(number - 1);
        }
    }
}