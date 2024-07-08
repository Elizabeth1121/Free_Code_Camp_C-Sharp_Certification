namespace Array_Manipulation
{
    public class Excercise_Clear_Resize
    {
        public string[] arrayClear (string[] str)
        {
            Array.Clear(str);

            return str;
        }

        public void arrayResize (ref string[] str, int newSize)
        {
            if(newSize < 0)
            {
                throw new Exception("Cannot be less than the size of the array");
            }
            else
                Array.Resize(ref str, newSize);
        }   
    }
}