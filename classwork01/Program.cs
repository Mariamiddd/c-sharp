namespace classwork01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [3, -5, 7, -2, 8, 1];

            arr.Sort();

            int low = lowest(arr);
            int high = highest(arr);

            Console.WriteLine($"lowest number: {low}");
            Console.WriteLine($"highest number: {high}");

            checkLow(arr);
            checkHigh(arr);


        }


        static int lowest(int[] arr)
        {
            return arr[0];
        }

        static int highest(int[] arr)
        {
            return arr[arr.Length - 1];

        }

        static void checkLow(int[] arr)
        {
            if(lowest(arr) < 0)
            {
                Console.WriteLine($"lowest number: {lowest(arr)} is negative");
            }
            else
            {
                Console.WriteLine($"highest number: {lowest(arr)} is positive");
            }
        }

        static void checkhigh(int[] arr)
        {
            if (lowest(arr) < 0)
            {
                Console.WriteLine($"lowest number: {lowest(arr)} is negative");
            }
            else
            {
                Console.WriteLine($"highest number: {lowest(arr)} is positive");
            }
        }

    }
}
