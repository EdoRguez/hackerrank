using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            string s = "aaab";
            
            var baseString = s.ToList();
            var reverseString = s.Reverse().ToList();
            
            if(baseString.SequenceEqual(reverseString))
            {
                Console.WriteLine(-1);		
                return;
            }
            
            for(int i = 0; i < baseString.Count(); i++) 
            {
                int j = baseString.Count() - i - 1;
            
                if(baseString.ElementAt(i) != baseString.ElementAt(j))
                {
                    if(baseString.ElementAt(i+1) == baseString.ElementAt(j))
                    {
                        Console.WriteLine(i);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(j);
                        return;
                    }					
                }
            }
        }
    }
}