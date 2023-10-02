
// See https://aka.ms/new-console-template for more information

String AlphabetSoup(String str)
{
    String result = string.Empty;

    char[] charArray = str.ToLower().ToCharArray();
    Array.Sort(charArray);

    result = new string(charArray);

    return result;

}

String result = AlphabetSoup("hello");// ehllo

Console.WriteLine(result);
Console.ReadLine();