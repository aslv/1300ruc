using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reading
{
    static class EmailGenerator
    {
        private static Random rand = new Random();
        private static char[] validCharacters = { 'a', 'b', 'c', 'd', 'e' };
        private static char[] startingCharacter = { 'A', 'B', 'C', 'D', 'F' };
        public static string GenerateEmail()
        {
            StringBuilder sb = new StringBuilder();
            int startIndex = rand.Next(startingCharacter.Length);
            sb.Append(startingCharacter[startIndex]);
            sb.Append(GenerateLetters(6));
            sb.Append("@");
            sb.Append(GenerateLetters(3));
            sb.Append(".");
            sb.Append(GenerateLetters(3));
            return sb.ToString();
        }
        private static string GenerateLetters(int maxCount)
        {
            StringBuilder result = new StringBuilder();
            int numberOfLetters = rand.Next(maxCount) + 1;
            int letterIndex;
            for (int i = 0; i < numberOfLetters; i++)
            {
                letterIndex = rand.Next(validCharacters.Length);
                result.Append(validCharacters[letterIndex]);
            }
            return result.ToString();
        }
    }
}
