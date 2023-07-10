using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    
    public class RegexNew
    {
        static string pattern = "^cen$";
        // ^ it will indicate string start
        // $ it will indicate the end of the string
        public void MyRegex()
        {
            // we have created object of class
            // we have pass a parameter pattern in given  class constructor
            Regex regex = new Regex(pattern);
            //is matched return true if its matches the string otherwie it return false
            if(regex.IsMatch("Rahim"))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("String does not match the Pattern");
            }
            Console.ReadLine();
        }
    }
}
