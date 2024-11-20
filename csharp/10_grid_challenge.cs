using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            List<string> grid = new List<string>(){"abc", "hjk", "mpq", "rtv"};
		
            for(int i = 0; i < grid.Count(); i++)
            {
                char[] characters = grid[i].ToArray();
                Array.Sort(characters);
                grid[i] = new string(characters);
            }	
            
            for(int i = 0; i < grid[0].Count(); i++)
            {
                for(int j = 1; j < grid.Count(); j++)
                {
                    if(grid[j-1][i] > grid[j][i])
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            
            Console.WriteLine("YES");
        }
    }
}