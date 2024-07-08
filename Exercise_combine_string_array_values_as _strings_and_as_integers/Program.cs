// starter code
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// Rule 1: If the value is alphabetical, concatenate it to form a message.
// Rule 2: If the value is numeric, add it to the total.
// Rule 3: The result should match the following output:

// Message: ABCDEF
// Total: 68.3

//---------------------------------------------------------VER 1-----------------------------------------
// store values into an decimal
//decimal sum = 0;

// store values into a string
//string concatenate = string.Empty;

//for (int i = 0; i < values.Length; i++)
//{

    // if value can be turned into an int, then its an decimal, otherwise its a word
    //if (decimal.TryParse(values[i], out decimal result))
    //{
        //sum += result;
    //}
    //else
    //{
        //concatenate += values[i];
    //}
//}

//---------------------------------------------------------VER 1-----------------------------------------

//---------------------------------------------------------VER 2-----------------------------------------
int counter = values.Length -1;

// storing decimal values
decimal sum = 0;

// storing string values
string concatenate = string.Empty;


while (counter >= 0)
{
    if(decimal.TryParse(values[counter], out decimal result))
    {
        sum += result;
    }
    else
        concatenate += values[counter];

    counter--;
}
//---------------------------------------------------------VER 2-----------------------------------------


System.Console.WriteLine("concatenate: {0} \n sum: {1}", concatenate, sum);