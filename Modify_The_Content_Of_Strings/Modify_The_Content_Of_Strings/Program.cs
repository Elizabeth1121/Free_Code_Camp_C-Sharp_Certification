public partial class Program
{
    public static void Main(string[] args)
    {
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        char[] openSymbols = { '[', '{', '(' };

        ExerciseIndexOfAndAny exercise1 = new ExerciseIndexOfAndAny();
        exercise1.FindingSymbols(message, openSymbols);
    }
}