using System;
using System.Linq;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            int petrolRemain = 0;
            int idx = 0;
            for(int i = 0; i < petrolpumps.Count(); i++)
            {
                int petrol = petrolpumps[i][0];
                int distance = petrolpumps[i][1];
                petrolRemain += petrol - distance;
                // check if remaining petrol is empty, reset the counter, and start from the next pumpstation
                if (petrolRemain < 0){
                    idx = i + 1;
                    petrolRemain = 0;
                }
            }
            return idx;
        }
    }
}