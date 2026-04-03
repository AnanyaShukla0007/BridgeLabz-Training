using System;;
class ConvertTextToUppercase
{
    static void Main()
    {
        Console.WriteLine("Enter the text: "); //input
        string s= Console.ReadLine();
        string result=""; 
        for(int i=0;i<s.length;i++)
        {
            if(s[i]>='a' && s[i]<='z')
            {
                result +=(char)(s[i]-32);
            }
            else
            {
                result +=s[i];
            }
        }
        Console.WriteLine("Uppercase Text: "+result); //output
    }
}