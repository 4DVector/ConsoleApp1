using ConsoleApp1.Logic;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            ArrayOperations op = new ArrayOperations();
            int[] numbers = { 45, 12, 89, 7, 33, 21 };

            Console.WriteLine("Початковий масив:");
            op.PrintArray(numbers);
            
            op.Sort(numbers);
            Console.WriteLine("\nМасив після сортування:");
            op.PrintArray(numbers);
            
            int target = 33;
            int result = op.Search(numbers, target);

            Console.WriteLine($"\nПошук числа {target}:");
            if (result != -1)
            {
                Console.WriteLine($"Елемент знайдено на позиції: {result}");
            }
            else
            {
                Console.WriteLine("Елемент не знайдено");
            }
        }
    }
}