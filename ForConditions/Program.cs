

namespace ForConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Hey user please enter a value that will be used to iterate");
            input= Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 1; i <= 15; i++)
            {
              Console.WriteLine("C# For Loop : Ireration" + i);
            }
        }
    }
}
    