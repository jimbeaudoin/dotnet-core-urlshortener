using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortenerLib
{
    public class Shortener
    {
        static Random random = new Random();
        static char[] charsArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        static int charsArrayLength = charsArray.Length;
        public Shortener()
        {
        }

        public static string GenerateShortFormat(int length)
        {
            var result = new char[length];
          
            for(int i=0; i<length; i++)
            {
                result[i] = charsArray[random.Next(charsArrayLength)];
            }
               
            return new string(result);
        }
    }
}
