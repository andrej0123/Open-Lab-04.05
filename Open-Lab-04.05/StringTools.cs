using System;
using System.Linq;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string answer = "";
            
            for (var i = 0; i < orig.Length; i++)
            {
                answer += string.Concat(Enumerable.Repeat(orig[i], n));
            }
            return answer;
                    
            
        }
    }
}
