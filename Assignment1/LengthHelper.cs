using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class LengthHelper
    {
        public int findLength(string str)
        {
            int length = str.Length;
            return length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            LengthHelper lengthHelper = new LengthHelper();
            int length = lengthHelper.findLength(str);
            Console.WriteLine("Length of string is: " + length);
            Console.ReadKey();
        }
    }
}




