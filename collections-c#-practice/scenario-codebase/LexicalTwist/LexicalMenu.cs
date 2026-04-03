using System;
using LexicalTwist.Utilities;

namespace LexicalTwist.Menu
{
    public class LexicalMenu
    {
        public void Start()
        {
            LexicalUtil util = new LexicalUtil();

            Console.WriteLine("Enter the first word");
            string first = Console.ReadLine();

            if (!util.IsValidWord(first))
                return;

            Console.WriteLine("Enter the second word");
            string second = Console.ReadLine();

            if (!util.IsValidWord(second))
                return;

            if (util.IsReverse(first, second))
            {
                Console.WriteLine(util.ReverseLowerReplaceVowels(first));
            }
            else
            {
                util.ProcessCombinedWords(first, second);
            }
        }
    }
}
