using System;
class SplitTextIntoWordsAndLengths
{
    static void Main()
    {
        Console.WriteLine("Enter the text: "); //input
        string s=Console.ReadLine();
        string word="";
        int length=0;
        for(int i=0;i<s.length;i++) //loop
        {
            if(i==s.length || s[i]=' ')
            {
                if(word !="") //word has no space in between
                {
                    Console.WriteLine(word+"->"+length);
                    word="";
                    length=0;
                }
            }
            else
            {
                word +=s[i];
                length++;
            }
        } 
    }
}