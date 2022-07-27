using System.Text.RegularExpressions;
namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jump over the lazy dog";
            check0(s);
            check1(s);
            check2(s);
            check3(s);
            check4(s);
            check5(s);
            check6(s);
            check7(s);
            check8(s);
            check9(s);
            check10(s);
            check11(s);
            check12(s);
            check13(s);
            check14(s);
            check15(s);
            check16(s);
        }
        static void check0(string s) { Console.WriteLine(s[12]);}
        static void check1(string s) { if (s.Contains("is")) { Console.WriteLine("Present"); } else { Console.WriteLine("Not Present"); } }

        static void check2(string s) {
            s += " and killed it";
            Console.WriteLine(s);
        }

        static void check3(string s)
        {
            if (s.EndsWith("dog"))
            { Console.WriteLine("Ends with dog"); }
            else
            { Console.WriteLine("Donot End with dog"); }
        }

        static void check4(string s)
        {
                string s1 = "The quick brown Fox jumps over the lazy Dog";
            if (String.Equals(s1, s))
                Console.WriteLine("Same"); 
            else
                Console.WriteLine("Not same");

        }
        static void check5(string s)
        {string s1= "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            if (!String.Equals(s1,s))
                Console.WriteLine("Not same");
            else
                Console.WriteLine("Same");
        }
        static void check6(string s)
        {
            Console.WriteLine($"Length of string is: {s.Length}");
        }
        static void check7(string s)
        {
            Console.WriteLine($"New String : {s.Replace("The","A")}");
        }
        static void check8(string s)
        {
            string[] s1 = s.Split("jump");
            for (int i = 0; i < s1.Length; i++)
                Console.WriteLine(s1[i]);
        }
        static void check9(string s) {
            string[] s1 = s.Split(" ");
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i]=="fox" || s1[i]=="dog")
                    Console.WriteLine(s1[i]);
            }
        }

        static void check10(string s) {
            Console.WriteLine(s.ToLower());
        }
        static void check11(string s) {
            Console.WriteLine(s.ToUpper());
        }
        static void check12(string s) {
            Console.WriteLine(s.IndexOf("a"));  
        }
        static void check13(string s) { 
            Console.WriteLine(s.LastIndexOf("e"));
        }
        static void check14(string s) { 
            Console.WriteLine("Enter string path");
            string s1=Console.ReadLine();
            string x = @"";
            x += s1 + "/WebApps/MyApps/Images";
            Console.WriteLine(x);
        }
        static void check15(string s) {
            string s1 =@"I WANDE'D lonely as a cloud 
That floats high o'er vales and hills,
When all at once I saw a crowd,
A host, of golden daffodils;
Beside the lake, beneath the trees, 
Fluttering and dancing in the breeze.";
            Console.WriteLine(s1);
        }
        static void check16(string s) {
            if (s == "Yhe quick brown fox jump over the lazy dog")
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not Same");
        }
    }

}