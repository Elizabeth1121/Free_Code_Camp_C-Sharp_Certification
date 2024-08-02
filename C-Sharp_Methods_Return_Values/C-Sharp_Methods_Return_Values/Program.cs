Console.WriteLine($"Reversing word here: {ReverseWord("Hello")}");

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}