using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWeekCSharp
{
    public class makeRandoms
    {

        //magic provided by stack overflower Liam
        //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
