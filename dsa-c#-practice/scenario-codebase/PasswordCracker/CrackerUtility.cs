using System;

namespace PasswordCracker
{
    internal class CrackerUtility
    {
        private bool found = false;

        public void Crack(char[] charset, char[] buffer, int index, string target)
        {
            if (found) return;

            if (index == buffer.Length)
            {
                string attempt = new string(buffer);
                Console.WriteLine(attempt);

                if (attempt.Equals(target))
                {
                    Console.WriteLine("Password matched!");
                    found = true;
                }
                return;
            }

            for (int i = 0; i < charset.Length; i++)
            {
                buffer[index] = charset[i];
                Crack(charset, buffer, index + 1, target);
            }
        }
    }
}
