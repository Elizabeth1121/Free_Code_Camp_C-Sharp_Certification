using System.Runtime.CompilerServices;

namespace Array_Manipulation
{
    public class Exercise_Split_Join
    {
        public char[] strConvertToChar (string str)
        {
            return str.ToCharArray();
        }

        public char[] reverseCharArr (char[] arr)
        {
            Array.Reverse(arr);

            return arr;
        }

        public string commaSperateArr (char[] arr)
        {
            string str = String.Join(",", arr);

            return str;
        }

        public string[] splitStr (string str)
        {
            return str.Split(",");
        }
    }
}