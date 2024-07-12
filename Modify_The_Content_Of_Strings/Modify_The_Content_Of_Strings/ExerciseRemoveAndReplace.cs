public partial class Program
{
    public class ExerciseRemoveAndReplace
    {
        public void RemoveSubstringAtIndex(string message)
        {
            string updatedString = message.Remove(5, 20);

            Console.WriteLine(updatedString);
        }

        public void SwapChar(string message)
        {
            string updatedString = message.Replace("--", " ");
            updatedString = updatedString.Replace("-", "");

            Console.WriteLine(updatedString);
        }
    }
}