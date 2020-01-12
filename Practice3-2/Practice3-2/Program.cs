using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board = new bool[12,12];
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    board[i,j] = false;
                }
            }

            Random RandomObj = new Random();
            int start_x = RandomObj.Next(0, 11);
            int start_y = RandomObj.Next(0, 11);
            int x = start_x;
            int y = start_y;
            board[start_x,start_y] = true;
            int startpoint = 12 * (start_x) + start_y + 1;
            Console.WriteLine(start_x + " " + start_y);
            Console.WriteLine("起點: "+startpoint);

            int count = 1;
            int walk;
            while (true)
            {
                // left up 
                if (start_x >= 1 && start_y >= 2 && board[start_x - 1,start_y - 2]==false)
                {
                    start_x -= 1;
                    start_y -= 2;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }
                else if (start_x >= 2 && start_y >= 1 && board[start_x - 2, start_y - 1] == false)
                {
                    start_x -= 2;
                    start_y -= 1;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }
                // right up
                else if (start_x <= 9 && start_y >= 1 && board[start_x + 2, start_y - 1] == false)
                {
                    start_x += 2;
                    start_y -= 1;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }
                else if (start_x <= 10 && start_y >= 2 && board[start_x + 1, start_y - 2] == false)
                {
                    start_x += 1;
                    start_y -= 2;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }
                // left down
                else if (start_x >= 1 && start_y <= 9 && board[start_x - 1, start_y + 2] == false)
                {
                    start_x -= 1;
                    start_y += 2;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }
                else if (start_x >= 2 && start_y <= 10 && board[start_x - 2, start_y + 1] == false)
                {
                    start_x -= 2;
                    start_y += 1;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }

                // right down
                else if (start_x <= 10 && start_y <= 9 && board[start_x + 1, start_y + 2] == false)
                {
                    start_x += 1;
                    start_y += 2;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }
                else if (start_x <= 9 && start_y <= 10 && board[start_x + 2, start_y + 1] == false)
                {
                    start_x += 2;
                    start_y += 1;
                    count++;
                    board[start_x, start_y] = true;
                    walk = 12 * start_x + start_y + 1;
                    Console.WriteLine("-> " + walk);
                }

                
                else
                {
                    break;
                }
            }
            
 

            // print the board 
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Read();


        }
    }
}
