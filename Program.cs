using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("What is the word you would like to have counted?");
            string wordToFindAndCount = Console.ReadLine();
            Console.WriteLine("Thank you. What is the phrase, sentence, or paragraph I should look in?");
            string stringToSearch = Console.ReadLine();

            RepeatCounter newRepeatCounter = new RepeatCounter(wordToFindAndCount, stringToSearch);

            int count = newRepeatCounter.CountHowManyTimesTheWordWasFound();

            Console.WriteLine("Thank you. I found that word " + count + " time(s) in the phrase you gave me.");
        }
    }
}
