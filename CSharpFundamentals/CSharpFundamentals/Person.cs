using System;


namespace CSharpFundamentals
{
    public class Person //Person is the class name
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }
}
