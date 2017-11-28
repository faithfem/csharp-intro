using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Faith efm";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            //REPLACE
            fullName.Replace("Faith", "FaithEfm"); //See other use in line 32
            fullName.Replace('o', '0');
            //fullName.Replace(' ', '');

            Console.WriteLine(fullName.Replace("Faith", "FaithEfm"));

            //To remove whitespace & return invalid
            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //How to convert numbers to strings
            var str = "25"; //Convert the age of 25 to a string
            var age = Convert.ToInt32(str);
            var sage = Convert.ToByte(str);
            Console.WriteLine(str);
            Console.WriteLine(sage);

            //Convert to Currency
            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); //Will show decimal places
            Console.WriteLine(price.ToString("C0")); //Without decimal places


            //Section 8 Chapter 64: Summarizing Text
            var sentence = "This is a a really really really really long text";
            const int maxLength = 20; //To limit characters in a word to 20 (avoids breaking up words)

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>(); //A list to store all the words that are going to be part of the summary

                //LOOP over each word
                foreach (var word in words)
                {
                    summaryWords.Add(word); //Add the summary list words (line 61) to the loop
                    totalCharacters += word.Length + 1; //Add 1 for the space after the words. 
                    if (totalCharacters > maxLength) //If total Characters is >20, we'll get out of the loop
                        break;
                }
            }

        }
    }
}
