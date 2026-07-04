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

            //////////////////////////////////////////////////////////////////

            // Task 2: Sum of Numbers 1 to N

            Console.Write("Enter a positive whole number: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum is: " + sum);

            //////////////////////////////////////////////////////////////////

            // Task 3: Multiplication Table

            Console.Write("Enter a number for multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            ///////////////////////////////////////////////////////////////

            // Task 4: Password Retry

            string correctPassword = "Spark2026";
            string password = "";

            while (password != correctPassword)
            {
                Console.Write("Enter the password: ");
                password = Console.ReadLine();

                if (password != correctPassword)
                {

                    Console.WriteLine("Incorrect password, try again.");
                }
            }

            Console.WriteLine("access Granted");

            /////////////////////////////////////////////////////////

            // Task 5:Number Gussing Game

            int secretNumber = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }
            } while (guess != secretNumber);

            Console.WriteLine("You guessed the number in " + attempts + "attempts.");


            ////////////////////////////////////////////////////////////////////////////////////

            // Task 6: Safe Division calculator

            try
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred: ");
            }
            ////////////////////////////////////////////////////////////////////////////////////
            // Task 7: Repeating Menu with Exit Option

            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("\n===== Menu =====");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Current Time-of-day Greeting");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;

                        case 2:
                            Console.WriteLine("Good Morning!");
                            break;

                        case 3:
                            Console.WriteLine("Exiting the program...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a numeric value.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occurred.");
                }


            }
        }
    }
}
