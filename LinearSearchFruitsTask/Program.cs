namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            Console.Write("Enter a fruit to search for: ");
            string searchTerm = Console.ReadLine()?.ToLower();

            int position = LinearSearch(fruits, searchTerm);

            if (position != -1)
            {
                Console.WriteLine($"True, found at index {position}");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static int LinearSearch(string[] fruitsArray, string searchTerm)
        {
            for (int i = 0; i < fruitsArray.Length; i++)
            {
                if (fruitsArray[i].ToLower() == searchTerm)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
