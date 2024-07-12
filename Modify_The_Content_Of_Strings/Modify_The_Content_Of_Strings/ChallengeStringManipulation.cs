public partial class Program
{
    public class ChallengeStringManipulation
    {
        //const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        public void PerformStringOperation(string message)
        {
            string quantity = "";
            string output = "";

            // for the quantity
            quantity = message.Remove(0, 35);
            quantity = quantity.Remove(4, 13);

            // for the output
            output = message.Replace("<div>", "");
            output = output.Replace("</div>", "");
            output = output.Replace("&trade", "%reg");

            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Output: " + output);
        }
    }
}