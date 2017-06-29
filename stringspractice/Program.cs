using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            string firstName = Console.ReadLine();
            int lengthOfName = firstName.Length;
           // Console.WriteLine(firstName);
            Console.WriteLine(lengthOfName);
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            int lengthOfLastName = lastName.Length;
           // Console.WriteLine(lastName);
            Console.WriteLine(lengthOfLastName);
            if (lengthOfName > lengthOfLastName)
            {
                Console.WriteLine("First is longer!");
            }
            else if (lengthOfName == lengthOfLastName)
            {
                Console.WriteLine("Samsis!");
            }
            else Console.WriteLine("last must be longer!");
            
            //string myFavQuote = "\"Shake and bake.\" -Ricky Bobby";
            //Console.WriteLine(myFavQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine\n";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //string startOfSentence = "My best friends name is ";
            //string endOfSentence = "Brittney";

            //Console.WriteLine(startOfSentence + endOfSentence);

            //Console.WriteLine("This is a tab. \t \nThis is a backspace \\.\nAnd this is a bell sound.");




        }
    }
}
