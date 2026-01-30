using System;

namespace LexicalTwist.Utilities
{
    public class LexicalUtil
    {
        // Validation
        public bool IsValidWord(string input)
        {
            if (input.Trim().Contains(" "))
            {
                Console.WriteLine(input + " is an invalid word");
                return false;
            }
            return true;
        }

        // Check reverse (case-insensitive)
        public bool IsReverse(string first, string second)
        {
            string reversed = Reverse(first.ToLower());
            return reversed.Equals(second.ToLower());
        }

        // Reverse + lowercase + replace vowels with '@'
        public string ReverseLowerReplaceVowels(string input)
        {
            char[] arr = Reverse(input.ToLower()).ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsVowel(arr[i]))
                    arr[i] = '@';
            }
            return new string(arr);
        }

        // Combine words and process counts
        public void ProcessCombinedWords(string first, string second)
        {
            string combined = (first + second).ToUpper();

            int vowels = 0, consonants = 0;

            for (int i = 0; i < combined.Length; i++)
            {
                char c = combined[i];
                if (IsVowel(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
            }

            if (vowels > consonants)
                PrintFirstTwoDistinct(combined, true);
            else if (consonants > vowels)
                PrintFirstTwoDistinct(combined, false);
            else
                Console.WriteLine("Vowels and consonants are equal");
        }

        // Helpers
        private string Reverse(string input)
        {
            char[] arr = input.ToCharArray();
            int i = 0, j = arr.Length - 1;

            while (i < j)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return new string(arr);
        }

        private void PrintFirstTwoDistinct(string word, bool vowels)
        {
            char first = '\0', second = '\0';

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if (vowels && !IsVowel(c)) continue;
                if (!vowels && IsVowel(c)) continue;

                if (first == '\0')
                    first = c;
                else if (c != first)
                {
                    second = c;
                    break;
                }
            }

            if (second != '\0')
                Console.WriteLine("" + first + second);
            else
                Console.WriteLine(first);
        }

        private bool IsVowel(char c)
        {
            return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
                || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
