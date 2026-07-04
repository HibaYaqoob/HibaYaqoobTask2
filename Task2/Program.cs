namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Countdown Timer

            Console.Write("Enter the starting number: ");
            int startNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("Liftoff");
        }
    }
}
