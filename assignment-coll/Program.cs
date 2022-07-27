using System.Collections;
namespace assignment_coll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            Console.WriteLine("Enter 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);  
            }
        }
    }
}