namespace Topic_6___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;
            randNum = generator.Next(10);
            Console.WriteLine("My random number is " + randNum);

            Console.WriteLine("Here are some numbers from 0 to 4!");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.WriteLine(generator.Next(5) + " ");
            Console.WriteLine();

            Console.WriteLine("Here are some numbers from 0 to 99!");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();
        }
    }
}
