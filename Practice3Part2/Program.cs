using System.Threading.Tasks;

namespace Practice3Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //Console.Write("Будь ласка, введіть рядок символів від 0 до 9: ");
            //string userInput = Console.ReadLine();

            //try
            //{
            //    int number = task1.StringToInt(userInput);
            //    Console.WriteLine($"Перетворено в ціле число: {number}");
            //}
            //catch (OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
            //task 2
            Console.Write("Будь ласка, введіть двійкове число (рядок з 0 та 1): ");
            string userInput = Console.ReadLine();

            try
            {
                int number = task2.BinaryStringToInt(userInput);
                Console.WriteLine($"Перетворено в ціле число: {number}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}