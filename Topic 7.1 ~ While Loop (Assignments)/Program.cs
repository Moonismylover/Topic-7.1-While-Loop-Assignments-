namespace Topic_7._1___While_Loop__Assignments_
{
    internal class Program
    {
        public static void Assignment1()
        {
            Console.Title = "Average of Numbers in a Loop";

            int numInputs, counter = 0, sum = 0, num, final;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello, user! How many numbers do you like to input? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            numInputs = Convert.ToInt32(Console.ReadLine());

            while (counter <= numInputs)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Number: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                counter++;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            final = sum / numInputs;
            Console.WriteLine($"The average of your numbers is {final}!");
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 7.1 ~ While Loop (Assignments)";

            Assignment1();

        }
    }
}
