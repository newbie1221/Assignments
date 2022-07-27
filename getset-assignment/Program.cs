namespace getset_assignment
{
    class check
    {
        public int isbn;
        public string booktitle;
        public string bookauthor;
        public string bookname;
        int quantitiybook { get; set; }
        public int Quantitiybook { get { return this.quantitiybook; } set { this.quantitiybook = value; } }

        public int price;
    }
    class proxy {
        long amount=0;
        public void famas() {
            do {
                Console.WriteLine("Do you want to buy books true/false??");
                bool c=bool.Parse(Console.ReadLine());
                if (!c)
                    break;
                Random random = new Random();
                check check = new check();
                check.isbn = random.Next(3000,8000);
                Console.WriteLine("Enter Booktitle: ");
                check.booktitle = Console.ReadLine();
                Console.WriteLine("Enter Bookname: ");
                check.bookname = Console.ReadLine();
                Console.WriteLine("Enter bookauthor");
                check.bookauthor = Console.ReadLine();
                Console.WriteLine("Enter quantity of book");
                check.Quantitiybook = int.Parse(Console.ReadLine());
                check.price = random.Next(100,900);
                amount+=(check.Quantitiybook*check.price);
                Console.WriteLine($"Booktitle: {check.booktitle}, Bookauthor: {check.bookauthor}, Bookname: {check.bookname}, Quantity: {check.Quantitiybook}");
                Console.WriteLine($"Amount of {check.Quantitiybook} book is {check.Quantitiybook * check.price}");

            } while (true);
            
        }
        public void show() {
            Console.WriteLine($"Cost of Total book bought: {amount}");
        }
    }
    class Program
    {
        static void Main()
        {
            proxy p = new proxy();
            p.famas();
            p.show();
        }
    }
}