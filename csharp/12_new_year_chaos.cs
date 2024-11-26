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
		
            Dictionary<int, int> history = new Dictionary<int, int>();		
            
            for(int i = 0; i < q.Count(); i++)
            {
                int expectedVal = i+1;			
                
                while(q[i] > expectedVal && q.Count() >= q[i])
                {
                    expectedVal++;
                    
                    if(!history.ContainsKey(q[i]))
                    {
                        history.Add(q[i], 1);
                    }
                    else
                    {
                        history[q[i]] = history[q[i]] + 1;
                    }
                }
            }
            
            int totalMovements = 0;
            foreach(var item in history)
            {
                if(item.Value > 2)
                {
                    Console.WriteLine("Too chaotic");
                }
                
                totalMovements += item.Value;
            }	
            
            if(totalMovements != 0)
            {
                Console.WriteLine(totalMovements);
            }	
        }
    }
}