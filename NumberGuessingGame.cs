using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 0, count = 0;
        Random random = new Random();
        num = random.Next(1, 101);
        while(true)
        {
            count++;
            Console.Write("\nGuess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if(guess > num)
                Console.WriteLine("lower");
            else if(guess < num)
                Console.WriteLine("higher");
            else
            {
                Console.WriteLine($"The number was {num}\nGuessed in {count} tries.");
                break;
            }
        }
    }
}
