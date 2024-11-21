using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            string n = "9875";
            int k = 4;
                
            int result = superDigit(n, k);	
            
            Console.WriteLine(result);
        }
        
        public static int superDigit(string n, int k)
        {	
            long digitSum = n.ToCharArray().Sum(c => c - '0');

            long combinedSum = digitSum * k;

            return (int)(combinedSum % 9 == 0 && combinedSum != 0 ? 9 : combinedSum % 9);
        }
    }
}