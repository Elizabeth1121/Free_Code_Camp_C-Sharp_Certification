public partial class Program
{
    public static void Main(string[] args)
    {
        //string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        //char[] openSymbols = { '[', '{', '(' };

        //ExerciseIndexOfAndAny exercise1 = new ExerciseIndexOfAndAny();
        //exercise1.FindingSymbols(message, openSymbols);

        //ExerciseRemoveAndReplace exercise2 = new ExerciseRemoveAndReplace();
        //string data = "12345John Smith          5000  3  ";
        //exercise2.RemoveSubstringAtIndex(data);

        //string message = "This--is--ex-amp-le--da-ta";
        //exercise2.SwapChar(message);

        string message = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        ChallengeStringManipulation challenge1 = new ChallengeStringManipulation();
        challenge1.PerformStringOperation(message);
    }
}