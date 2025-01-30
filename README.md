namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            Console.Write("Enter a fruit to search for: ");
            string searchTerm = Console.ReadLine()?.ToLower();

            bool isFound = LinearSearch(fruits, searchTerm);

            if (isFound)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static bool LinearSearch(string[] fruitsArray, string searchTerm)
        {
            for (int i = 0; i < fruitsArray.Length; i++)
            {
                if (fruitsArray[i].ToLower() == searchTerm)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
