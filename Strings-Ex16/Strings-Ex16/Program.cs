using System;

namespace Strings_Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetStringBeforeChar("https://www.siit.com/net-exercises"));
        }
        //Write a method to get the last part of a string before a specified character. Input :  https://www.siit.com/net-exercises Output:  https://www.siit.com/net
        public static string GetStringBeforeChar(string input)
        {
            string result = string.Empty;
            char targetCharacter = '-';

            int targetCharIndex = input.IndexOf(targetCharacter);

            result = input.Substring(0, targetCharIndex);

            return result;
        }
    }
}
