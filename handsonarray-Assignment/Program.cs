namespace handsonarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int[] arr = new int[5] { 10, 20, 40, 50, 60 };
            ////foreach (int i in arr)
            ////    Console.WriteLine(i);
            ////int n = int.Parse(Console.ReadLine());
            ////int[] a = new int[n];
            ////for (int i = 0; i < n; i++)
            ////{
            ////    a[i] = int.Parse(Console.ReadLine());
            ////}
            ////foreach (int i in a)
            ////    Console.WriteLine(i);
            //string[] s = { "Tulip", "Lilly", "Rose", "Miranda" };
            ////string s2 = Console.ReadLine();
            ////int flag = 0;
            ////Array.Sort(s);
            ////foreach (string i in s)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //Object [] o = new Object[s.Length];
            //Array.Copy(s, o, 3);
            //o[3] = 1;

            //foreach(Object i in o)
            //    Console.WriteLine(i);
            String[,] proxy = new string[,] {
                {"1815001", "Debopriyo1" },
                {"1815002", "Debopriyo2" },
                {"1815003", "Debopriyo3" },
                {"1815004", "Debopriyo4" },
                {"1815005", "Debopriyo5" },

            };
            Console.WriteLine("Enter Roll no.");
            String x = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (proxy[i,0] == x)
                {
                    Console.WriteLine(proxy[i,1]);
                }
            }
            



        }
    }
}