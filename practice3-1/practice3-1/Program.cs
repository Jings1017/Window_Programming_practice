using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("輸入y來開始隨機發牌，輸入n結束遊戲:");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    // generate 
                    int[] poker = new int[52];
                    for (int i = 1; i <= poker.Length; i++)
                    {
                        poker[i - 1] = i;
                    }

                    // shuffle
                    int t = 0;
                    int tmp;
                    Random r = new Random();
                    for (int i = 0; i < poker.Length; i++)
                    {
                        t = r.Next(0, 52);
                        tmp = poker[i];
                        poker[i] = poker[t];
                        poker[t] = tmp;
                    }

                    // dist.
                    int[] A = new int[13];
                    int[] B = new int[13];
                    int[] C = new int[13];
                    int[] D = new int[13];
                    for (int i = 0; i < poker.Length; i++)
                    {
                        if (i < 13)
                        {
                            A[i] = poker[i];
                        }
                        else if (i < 26)
                        {
                            B[i - 13] = poker[i];
                        }
                        else if (i < 39)
                        {
                            C[i - 26] = poker[i];
                        }
                        else
                        {
                            D[i - 39] = poker[i];
                        }
                    }
                    /*Array.Sort(A);
                    Array.Sort(B);
                    Array.Sort(C);
                    Array.Sort(D);*/
                    Console.Write("玩家1獲得的牌: ");
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] <= 13)
                        {
                            Console.Write("A_" + A[i] + " ");
                        }
                        else if (A[i] <= 26)
                        {
                            Console.Write("B_" + (A[i] % 13 + 1) + " ");
                        }
                        else if (A[i] <= 39)
                        {
                            Console.Write("C_" + (A[i] % 13 + 1) + " ");
                        }
                        else if (A[i] <= 52)
                        {
                            Console.Write("D_" + (A[i] % 13 + 1) + " ");
                        }
                    }
                    Console.WriteLine();

                    Console.Write("玩家2獲得的牌: ");
                    for (int i = 0; i < B.Length; i++)
                    {
                        if (B[i] <= 13)
                        {
                            Console.Write("A_" + B[i] + " ");
                        }
                        else if (B[i] <= 26)
                        {
                            Console.Write("B_" + (B[i] % 13 + 1) + " ");
                        }
                        else if (B[i] <= 39)
                        {
                            Console.Write("C_" + (B[i] % 13 + 1) + " ");
                        }
                        else if (B[i] <= 52)
                        {
                            Console.Write("D_" + (B[i] % 13 + 1) + " ");
                        }
                    }
                    Console.WriteLine();

                    Console.Write("玩家3獲得的牌: ");
                    for (int i = 0; i < C.Length; i++)
                    {
                        if (C[i] <= 13)
                        {
                            Console.Write("A_" + C[i] + " ");
                        }
                        else if (C[i] <= 26)
                        {
                            Console.Write("B_" + (C[i] % 13 + 1) + " ");
                        }
                        else if (C[i] <= 39)
                        {
                            Console.Write("C_" + (C[i] % 13 + 1) + " ");
                        }
                        else if (C[i] <= 52)
                        {
                            Console.Write("D_" + (C[i] % 13 + 1) + " ");
                        }
                    }
                    Console.WriteLine();

                    Console.Write("玩家4獲得的牌: ");
                    for (int i = 0; i < D.Length; i++)
                    {
                        if (D[i] <= 13)
                        {
                            Console.Write("A_" + D[i] + " ");
                        }
                        else if (D[i] <= 26)
                        {
                            Console.Write("B_" + (D[i] % 13 + 1) + " ");
                        }
                        else if (D[i] <= 39)
                        {
                            Console.Write("C_" + (D[i] % 13 + 1) + " ");
                        }
                        else if (D[i] <= 52)
                        {
                            Console.Write("D_" + (D[i] % 13 + 1) + " ");
                        }
                    }

                    // pair check
                    int[] numA = new int[13];
                    int[] numB = new int[13];
                    int[] numC = new int[13];
                    int[] numD = new int[13];
                    for (int i = 0; i < numA.Length; i++)
                    {
                        numA[i] = 0;
                        numB[i] = 0;
                        numC[i] = 0;
                        numD[i] = 0;
                    }
                    for (int i = 0; i < A.Length; i++)
                    {
                        numA[A[i] % 13]++;
                        numB[B[i] % 13]++;
                        numC[C[i] % 13]++;
                        numD[D[i] % 13]++;
                    }
                    Console.WriteLine();
                    for (int i = 0; i < numA.Length; i++)
                    {
                        if (numA[i] > 1)
                        {
                            Console.WriteLine("玩家1有對子");
                            break;
                        }
                    }
                    for (int i = 0; i < numB.Length; i++)
                    {
                        if (numB[i] > 1)
                        {
                            Console.WriteLine("玩家2有對子");
                            break;
                        }
                    }
                    for (int i = 0; i < numC.Length; i++)
                    {
                        if (numC[i] > 1)
                        {
                            Console.WriteLine("玩家3有對子");
                            break;
                        }
                    }
                    for (int i = 0; i < numD.Length; i++)
                    {
                        if (numD[i] > 1)
                        {
                            Console.WriteLine("玩家4有對子");
                            break;
                        }
                    }
                }
                else if(input == "n")
                {
                    break;
                }
            } 
        }
    }
}
