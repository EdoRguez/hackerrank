using System;
using System.Linq;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            List<int> q = new List<int>(){1, 2, 5, 3, 7, 8, 6, 4};
		
            int movements = 0;
            int p1 = 1;   
            int p2 = 2;   
            int p3 = 3;   
            
            foreach(var item in q)
            {
                if(item == p1)
                {
                    // 1 2 3
                    p1 = p2;
                    p2 = p3;
                    p3++;
                }
                else if(item == p2)
                {
                    // 2 1 3
                    movements++;
                    p2 = p3;
                    p3++;
                }
                else if(item == p3)
                {
                    // 3 1 2
                    movements += 2;
                    p3++;
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
            
            Console.WriteLine(movements);
        }
    }
}