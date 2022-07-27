namespace Assignment_3
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Monthly Payment");
            double k = double.Parse(Console.ReadLine());
            double b = 915,i=1,p=k;
            while (b >= 0)
            {
                Console.WriteLine($"Month:{i}  balance:{b}  total payments:{p}");
                b = b + (b * 0.015) - p;
                i++;
                p += k;

            }
        }
    }
}