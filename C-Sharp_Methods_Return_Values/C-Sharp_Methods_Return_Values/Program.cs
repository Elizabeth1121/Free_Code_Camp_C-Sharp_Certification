//Console.WriteLine($"Reversing word here: {ReverseWord("Hello")}");
Console.WriteLine($"Reversing a sentence here: {ReverseSentence("There are snakes at the zoo")}");

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (var word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}