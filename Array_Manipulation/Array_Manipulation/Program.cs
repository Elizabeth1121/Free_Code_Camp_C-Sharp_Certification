using System.Linq.Expressions;

namespace Array_Manipulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            //Exercise_Sort_Reverse exercise1 = new Exercise_Sort_Reverse();
            //exercise1.arraySort(pallets);

            //System.Console.WriteLine("Sorting...");

            //foreach (var element in pallets)
            //{
                //System.Console.WriteLine($"-- {element}");
            //}

            //System.Console.WriteLine("Reverse Sorting...");
            //exercise1.arrayReverse(pallets);

            //foreach (var element in pallets)
            //{
                //System.Console.WriteLine($"-- {element}");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            Excercise_Clear_Resize excercise2 = new Excercise_Clear_Resize();
            //excercise2.arrayClear(pallets);

            //foreach (var element in pallets)
            //{
                //System.Console.WriteLine($"-- {element}");
            //}

            //excercise2.arrayResize(ref pallets, -1);

            //foreach (var element in pallets)
            //{
                //System.Console.WriteLine($"-- {element}");
            //}

            //excercise2.arrayResize(ref pallets, 6);

            //pallets[4] = "test1";
            //pallets[5] = "test2";

            //foreach (var element in pallets)
            //{
                //System.Console.WriteLine($"-- {element}");
            //}

            
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //string value = "abc123";
            //Exercise_Split_Join exercise3 = new Exercise_Split_Join();

            //char[] arr = exercise3.strConvertToChar(value);
            //exercise3.reverseCharArr(arr);

            //string str = exercise3.commaSperateArr(arr);
            //System.Console.WriteLine(str);

            //string[] arrStr = exercise3.splitStr(str);

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //string pangram = "The quick brown fox jumps over the lazy dog";

            //Challenge_Reverse_String challenge1 = new Challenge_Reverse_String();
            //string[] result = challenge1.strReverse(pangram); 

            //foreach(var item in result)
            //{
                //System.Console.Write(item + " ");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            Challenge_Sort_Parse_TagErrors challenge2 = new Challenge_Sort_Parse_TagErrors();
            string[] orderArray = challenge2.OrderIDArray(orderStream);
            challenge2.OrderIDSort(orderArray);
            challenge2.TagErrors(orderArray);
        }
    }
}