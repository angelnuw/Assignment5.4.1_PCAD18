namespace Assignment5._4._1
{
    internal class Program
    {

        static void NumberProblem(int n)
        {
            if (n == 0)
                return;

            NumberProblem(n / 10);

            Console.Write(n % 10 + " ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            NumberProblem(number);
            Console.WriteLine();
        }
    }
}
