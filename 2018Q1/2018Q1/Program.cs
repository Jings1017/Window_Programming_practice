using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n,l=0,w=0,t=0;
            string[] a = new string[3]{ "Stone", "Scissor", "Paper" };
            Console.WriteLine("How many rounds will you play?");
            n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                int guess,ans;
                Console.WriteLine("make your chioce! (0:Stone, 1:Scissor, 2:Paper)");
                Random rand = new Random();
                ans = rand.Next(0, 3);
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("You choosed {0}, and computer choosed {1}", a[guess], a[ans]);
                if (guess == ans)
                {
                    t++;
                    Console.WriteLine("Tie!");
                }
                else if((guess==0 && ans==1) || (guess==1 && ans==2) || (guess==2 && ans == 0))
                {
                    w++;
                    Console.WriteLine("You win this round");
                }
                else if((guess == 0 && ans == 2) || (guess == 1 && ans == 0) || (guess == 2 && ans == 1))
                {
                    l++;
                    Console.WriteLine("Oops, you lose this round");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("Total result:");
            Console.WriteLine("W    L    T");
            Console.WriteLine(l + " win, " + w + " lose," + t + " tie");
            Console.Read();
        }
    }
}
