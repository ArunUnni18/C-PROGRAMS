using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome
    {
        public static void PalindromeCheck()
        {
            Console.WriteLine("enter the string");
            String name = Console.ReadLine();
            Char[] array = name.ToCharArray();
            Array.Reverse(array);
            String rev = new String(array);
            Console.WriteLine(rev) ;
            if (name == rev)
            {
                Console.WriteLine("string is palindrome");   
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}
