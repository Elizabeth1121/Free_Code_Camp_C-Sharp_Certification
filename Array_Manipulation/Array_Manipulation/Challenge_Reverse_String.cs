using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace Array_Manipulation
{
    public class Challenge_Reverse_String
    {
        public string[] strReverse (string str)
        {
            // split str by space
            string[] arr = str.Split(" ");
            int counter = 0;

            // loop here
            while (counter < arr.Length)
            {
                char[] letters = arr[counter].ToCharArray();
                Array.Reverse(letters);

                arr[counter] = String.Join("", letters);

                counter++;
            }

            return arr;
        }
    }
}