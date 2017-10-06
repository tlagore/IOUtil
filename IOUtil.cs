using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOUtil
{
    public class IOUtil
    {
        public static string getString(int minLength, int maxLength, string prompt)
        {
            string retVal = "";

            do
            {
                Console.Write(prompt);
                retVal = Console.ReadLine();
                if (retVal.Length < minLength)
                    Console.WriteLine("Input must be equal to or more than " + minLength + " characters.");
                else if (retVal.Length > maxLength)
                    Console.WriteLine("Input must be equal to or less than " + maxLength + " characters.");
            }
            while (retVal.Length < minLength || retVal.Length > maxLength);          

            return retVal;
        }

    }
}
