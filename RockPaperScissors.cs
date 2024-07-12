using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 - rock
             * 2 - paper
             * 3 - scissors
             */
            int[] arr = { 1, 2, 3 };
            Random random = new Random();
            while(true)
            {
                Console.WriteLine("\n1.rock\n2.paper\n3.scissors\nEnter your choice(Enter -1 to end the game) : ");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                int sysChoice = random.Next(1, 4);

                if (userChoice == -1)
                    break;
                switch(userChoice)
                {
                    case 1:
                        {
                            if (sysChoice == 2)
                                Console.WriteLine("You lost because the system's choice is paper\nWanna try again?");
                            else
                                Console.WriteLine("You won the Game. the system's choice is scissors\nWanna Play again");
                            break;
                        }
                    case 2:
                        {
                            if (sysChoice == 3)
                                Console.WriteLine("You lost because the system's choice is scissors\nWanna try again?");
                            else
                                Console.WriteLine("You won the Game. the system's choice is rock\nWanna Play again");
                            break;
                        }
                    case 3:
                        {
                            if (sysChoice == 1)
                                Console.WriteLine("You lost because the system's choice is rock\nWanna try again?");
                            else
                                Console.WriteLine("You won the Game. the system's choice is paper\nWanna Play again?");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Enter valid choice!");
                            break;
                        }
                }
            }
        }
    }
}


Output:
1.rock
2.paper
3.scissors
Enter your choice(Enter -1 to end the game) :
2
You lost because the system's choice is scissors
Wanna try again?

1.rock
2.paper
3.scissors
Enter your choice(Enter -1 to end the game) :
3
You won the Game. the system's choice is paper
Wanna Play again?

1.rock
2.paper
3.scissors
Enter your choice(Enter -1 to end the game) :
1
You won the Game. the system's choice is scissors
Wanna Play again

1.rock
2.paper
3.scissors
Enter your choice(Enter -1 to end the game) :
-1
