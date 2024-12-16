using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            int result = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                int valToFind = arr[i] - k;
                if(valToFind != arr[i] && arr.IndexOf(valToFind) != -1)
                {
                    result++;
                }
            }
            return result;
        }
    }
}