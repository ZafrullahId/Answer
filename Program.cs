namespace CodeChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static int FindingAnumberInAnArray(List<int> arr, int original)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if(arr.Contains(original))
                {
                    original *= 2;
                }
               
            }
            return original;
        }
    }
}

