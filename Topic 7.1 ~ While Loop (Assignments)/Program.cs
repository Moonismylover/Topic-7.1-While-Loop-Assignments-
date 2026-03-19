namespace Topic_7._1___While_Loop__Assignments_
{
    internal class Program
    {
        public static void Assignment1()
        {
            Console.Title = "Average of Numbers in a Loop";

            int numInputs, counter = 0;
            double num, sum = 0, final;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello, user! How many numbers would you like to input? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            numInputs = Convert.ToInt32(Console.ReadLine());

            while (numInputs <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid input. Try again!");
                Console.Write("How many numbers would you like to input? \nEnter here: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                numInputs = Convert.ToInt32(Console.ReadLine());
            }
            
            while (counter < numInputs)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Number: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Double.TryParse(Console.ReadLine(), out num);
                sum = sum + num;
                counter++;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            final = sum / numInputs;
            Console.WriteLine($"The average of your numbers is {final.ToString("F2")}!");
        }

        public static void Assignment2()
        {
            Console.Title = "Hi Low with Limited Tries";

            int num, counter = 7, userinput;

            Random generator = new Random();
            num = generator.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome USER! You will be given 7 guesses to guess a randomly generated number from 1-100. GOOD LUCK!");

            Console.Write("Your guess: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            userinput = Convert.ToInt32(Console.ReadLine());
            counter--;

            while (userinput != num && counter > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (userinput == num)
                {
                    break;
                }

                if (userinput > num)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Too high! \nTry again: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    userinput = Convert.ToInt32(Console.ReadLine());
                    counter--;
                }

                if (userinput < num)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Too low! \nTry again: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    userinput = Convert.ToInt32(Console.ReadLine());
                    counter--;
                }

                if (counter == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Thank you for playing! You have {counter} tries left!");
                    break;
                }

            }

            if (userinput == num)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Correct! Congrats on guessing right! Do come again!");
            }

        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 7.1 ~ While Loop (Assignments)";

            Assignment1();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("__________________________________________");
            Console.WriteLine();

            Assignment2();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("__________________________________________");
            Console.WriteLine();



        }
    }
}
