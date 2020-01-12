using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxarea=0;
            Console.WriteLine("請輸入陣列(輸入0結束):");
            List<int> list = new List<int>();
            int tmp=1;
            while (tmp!=0)
            {
                tmp = Convert.ToInt32(Console.ReadLine());
                list.Add(tmp);
            }

            for (int i = 0; i < list.Count; i++)
            {
                int w , leftpivot=0 , rightpivot=0 ;
                // for left
                for(int j = i; j >= 0; j--)
                {
                    if (list[j] >= list[i])
                    {
                        leftpivot = j;
                    }
                }
                // for right
                for(int k = i; k < list.Count ; k++)
                {
                    if (list[k] >= list[i])
                    {
                        rightpivot = k;
                    }
                }
                w = rightpivot - leftpivot;
                maxarea = Math.Max(maxarea,w* list[i]);
                //Console.WriteLine("i= " + i + ", w= " + w + ", his[i]= " + list[i]);
            }
            
            Console.WriteLine("最大面積為" + maxarea);
            Console.ReadKey(true);

        }
    }
}
