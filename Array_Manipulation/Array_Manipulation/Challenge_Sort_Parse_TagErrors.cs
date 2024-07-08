namespace Array_Manipulation
{
    public class Challenge_Sort_Parse_TagErrors
    {
        public string[] OrderIDArray(string str)
        {
            string[] IDs = str.Split(",");

            return IDs;
        }

        public string[] OrderIDSort(string[] orderArr)
        {
            Array.Sort(orderArr);

            return orderArr;
        }

        public void TagErrors(string[] orderArr)
        {

            for (int i = 0; i < orderArr.Length; i++)
            {
                if(orderArr[i].Length < 4 || orderArr[i].Length > 4)
                {
                    System.Console.WriteLine($"{orderArr[i]}    -error");
                }
                else
                    System.Console.WriteLine($"{orderArr[i]}");

            }
        }
    }
}