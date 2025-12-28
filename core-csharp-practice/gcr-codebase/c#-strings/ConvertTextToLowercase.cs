using System;;
class ConvertTextToLowercase
{
    static void Main()
    {
        Console.WriteLine("Enter the text: "); //input
        string s= Console.ReadLine();
        string result=""; 
        for(int i=0;i<s.length;i++)
        {
            if(s[i]>='A' && s[i]<='Z')
            {
                result +=(char)(s[i]+32);
            }
            else
            {
                result +=s[i];
            }
        }
        Console.WriteLine("Lowercase Text: "+result); //output
    }
}