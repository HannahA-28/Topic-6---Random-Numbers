namespace Topic_6___Random_Numbers
{
    internal class Program
    {
        private static object generator;

        static void Main(string[] args)
        {
            //Random generator = new Random();
            //int randNum;
            //randNum = generator.Next(10);
            //Console.WriteLine("My random number is " + randNum);

            //Console.WriteLine("Here are some numbers from 0 to 4!");
            //Console.Write(generator.Next(5) + " ");
            //Console.Write(generator.Next(5) + " ");
            //Console.Write(generator.Next(5) + " ");
            //Console.Write(generator.Next(5) + " ");
            //Console.Write(generator.Next(5) + " ");
            //Console.WriteLine(generator.Next(5) + " ");
            //Console.WriteLine();

            //Console.WriteLine("Here are some numbers from 0 to 99!");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.WriteLine(generator.Next(100) + " ");
            //Console.WriteLine();

            //int num1 = generator.Next(10);
            //int num2 = generator.Next(10);
            //if (num1 == num2)
            //    Console.WriteLine("The random numbers were the same! Weird.");
            //if (num1 != num2)
            //    Console.WriteLine("The random numbers were different! Not weird.");
            //Console.ReadLine();

            //Console.WriteLine("Task one");
            //Random generator = new Random();
            //int max, min;
            //Console.WriteLine("Give me a maximum value.");
            //max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Give me a maximum value smaller than the maximum.");
            //min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Here is a random number between " + min + " and " + max + ":");
            //Console.WriteLine(generator.Next(min, max + 1));

            //Console.WriteLine("Task two");
            //Random generator = new Random();
            //int guess, secretNumber;
            //secretNumber = generator.Next(1, 11);
            //Console.WriteLine("Guess the random number from 1 to 10.");
            //guess = Convert.ToInt32(Console.ReadLine());
            //if (guess == secretNumber)
            //    Console.WriteLine("Congratulations, you guessed it!");
            //else
            //    Console.WriteLine("Wrong, the secret number was " + secretNumber);

            Console.WriteLine("Task three");
            Random generator = new Random();
            int diceNum;
            diceNum = generator.Next(1, 13);
            Console.WriteLine("Roll the dice.");
            Console.ReadLine();
            Thread.Sleep(500);
            if (diceNum == 6 && diceNum == 6)
                Console.WriteLine("The sum is 12");

            //Console.WriteLine("Task four");
            //Random generator = new Random();
            //int response = generator.Next(6);
            //Console.WriteLine("Welcome to the future-seer 3000. Please ask your yes or no questions.");
            //Console.ReadLine();
            //Thread.Sleep(500);
            //if (response == 0)
            //    Console.WriteLine("Yes, definitely!");
            //else if (response == 1)
            //    Console.WriteLine("Ask again later!");
            //else if (response == 2)
            //    Console.WriteLine("No way!");
            //else if (response == 3)
            //    Console.WriteLine("The future is hazy, I can't tell!");
            //else if (response == 4)
            //    Console.WriteLine("There is a high chance of it being so!");
            //else
            //    Console.WriteLine("Outlook is not so good!");
        }
    }
}
