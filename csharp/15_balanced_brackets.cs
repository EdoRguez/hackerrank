using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            string s = "{[()]}()";

            string par = "()";
            string squ = "[]";
            string bra = "{}";
            
            while(s.IndexOf(par) != -1 || s.IndexOf(squ) != -1 || s.IndexOf(bra) != -1)
            {
                if(s.IndexOf(par) != -1)
                {
                    s = s.Replace(par, string.Empty);
                }
                else if(s.IndexOf(squ) != -1)
                {
                    s = s.Replace(squ, string.Empty);
                }
                else if(s.IndexOf(bra) != -1)
                {
                    s = s.Replace(bra, string.Empty);
                }
                else
                {
                    break;
                }
            }
            
            return s.Length == 0 ? "YES" : "NO";
        }
    }
}