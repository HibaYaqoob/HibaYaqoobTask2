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
                    choice = int.Parse(Console.ReadLine());

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
            ////////////////////////////////////////////////////////////////////////

            // Task 8:Sum of Even Numbers Only
            Console.Write("Enter a positive whole number: ");
            int N = int.Parse(Console.ReadLine());

            int Sum = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Sum += i;
                }
            }

            Console.WriteLine("The sum of even numbers is: " + Sum);



            ////////////////////////////////////////////////////////////////////////

            // Task 9: Validated Positive Number Input (C#)

            int m = 0;
            bool valid = false;

            do
            {
                try
                {
                    Console.Write("Enter a positive whole number: ");
                    m = int.Parse(Console.ReadLine());

                    if (m <= 0)
                    {
                        Console.WriteLine("Error: Number must be greater than zero.");
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid whole number.");
                    valid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occurred.");
                    valid = false;
                }

            } while (!valid);

            // Sum calculation (separate for loop)
            int sumis = 0;

            for (int i = 1; i <= n; i++)
            {
                sumis += i;
            }

            Console.WriteLine("The sum from 1 to " + n + " is: " + sumis);

            ///////////////////////////////////////////////////////////////

            // Task 10: Simple ATM Simulation (C#)

            int correctPin = 1234;
            int pin;
            int Attempts = 0;
            bool authenticated = false;

            double balance = 100.000;

            // ===== PIN CHECK (max 3 attempts) =====
            while (Attempts < 3)
            {
                try
                {
                    Console.Write("Enter PIN: ");
                    pin = int.Parse(Console.ReadLine());

                    if (pin == correctPin)
                    {
                        authenticated = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong PIN.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. PIN must be numeric.");
                }

                Attempts++;
            }

            if (!authenticated)
            {
                Console.WriteLine("Card Blocked");
                return;
            }

            // ===== ATM MENU =====
            int Choice = 0;

            while (Choice != 4)
            {
                Console.WriteLine("\n===== ATM Menu =====");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    Choice = int.Parse(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1: // Deposit
                            try
                            {
                                Console.Write("Enter deposit amount: ");
                                double deposit = double.Parse(Console.ReadLine());

                                if (deposit <= 0)
                                {
                                    Console.WriteLine("Invalid amount. Must be greater than 0.");
                                }
                                else
                                {
                                    balance += deposit;
                                    Console.WriteLine("Deposit successful.");
                                    Console.WriteLine("New Balance: " + balance + " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            break;

                        case 2: // Withdraw
                            try
                            {
                                Console.Write("Enter withdrawal amount: ");
                                double withdraw = double.Parse(Console.ReadLine());

                                if (withdraw <= 0)
                                {
                                    Console.WriteLine("Invalid amount. Must be greater than 0.");
                                }
                                else if (withdraw > balance)
                                {
                                    Console.WriteLine("Insufficient balance.");
                                }
                                else
                                {
                                    balance -= withdraw;
                                    Console.WriteLine("Withdrawal successful.");
                                    Console.WriteLine("New Balance: " + balance + " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            break;

                        case 3: // Check Balance
                            Console.WriteLine("Current Balance: " + balance + " OMR");
                            break;

                        case 4:
                            Console.WriteLine("Exiting ATM...");
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid menu number.");
                }
            }



        }
    }
}
