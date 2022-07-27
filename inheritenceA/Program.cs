namespace inheritenceA
{
    class furniture
    {
        public int oid;
        public DateTime odate;
        public string ftype;
        public int qty=1;
        public int tamnt=0;
        public string pmode;
    }
    class chair : furniture {
        string ctype;
        string ppose;
        string wood;
        string steel;
        string color;
        int rate;


        public void getdata() {
            odate = DateTime.Today;
            Random rnd=new Random();
            Console.WriteLine("Enter Chair type wood/steel/plastic :");
            ctype = Console.ReadLine();
            Console.WriteLine("Enter your purpouse Home/Office: ");
            ppose = Console.ReadLine();
            if (ctype == "wood")
            {
                Console.WriteLine("Enter type of wood Teak/Rose wood: ");
                wood = Console.ReadLine();
                Console.WriteLine("Enter quantity of Chair");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter purchase Mode Credit/Debit card: ");
                pmode = Console.ReadLine();
                oid = rnd.Next(1000, 9000);
                rate = rnd.Next(200, 900);
                tamnt = qty * rate;
                Console.WriteLine($"Order ID:{oid}, Date:{odate}, Furniture type: Chair, ChairType: {wood} wood chair");
                Console.WriteLine($"Purpouse:{ppose}, Quantity:{qty}, Total: {tamnt}");
            }
            else if (ctype == "steel")
            {
                Console.WriteLine("Enter type of steel Gray/Green/Brown Steel : ");
                steel = Console.ReadLine();
                Console.WriteLine("Enter quantity of Chair");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter purchase Mode Credit/Debit card: ");
                pmode = Console.ReadLine();
                oid = rnd.Next(1000, 9000);
                rate = rnd.Next(200, 900);
                tamnt = qty * rate;
                Console.WriteLine($"Order ID:{oid}, Date:{odate}, Furniture type: Chair, ChairType: {steel} steel chair");
                Console.WriteLine($"Purpouse:{ppose}, Quantity:{qty}, Total: {tamnt}");
            }
            else if (ctype == "plastic")
            {
                Console.WriteLine("Enter color of plastic Green/Red/Blue/White chair: ");
                color = Console.ReadLine();
                Console.WriteLine("Enter quantity of Chair");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter purchase Mode Credit/Debit card: ");
                pmode = Console.ReadLine();
                oid = rnd.Next(1000, 9000);
                rate = rnd.Next(200, 900);
                tamnt = qty * rate;
                Console.WriteLine($"Order ID:{oid}, Date:{odate}, Furniture type: Chair, ChairType: {color} chair");
                Console.WriteLine($"Purpouse:{ppose}, Quantity:{qty}, Total: {tamnt}");
            }
        }
    }
    class cot : furniture {
        string ctype;
        string ppose;
        string wood;
        string steel;
        int rate;


        public void getdata()
        {
            odate = DateTime.Today;
            Random rnd = new Random();
            Console.WriteLine("Enter Cot type wood/steel :");
            ctype = Console.ReadLine();
            Console.WriteLine("Enter your purpouse Home/Office: ");
            ppose = Console.ReadLine();
            if (ctype == "steel")
            {
                Console.WriteLine("Enter type of steel Gray/Green/Brown Steel : ");
                steel = Console.ReadLine();
                Console.WriteLine("Enter quantity of Cot");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter purchase Mode Credit/Debit card: ");
                pmode = Console.ReadLine();
                oid = rnd.Next(1000, 9000);
                rate = rnd.Next(200, 900);
                tamnt = qty * rate;
                Console.WriteLine($"Order ID:{oid}, Date:{odate}, Furniture type: Cot, CotType: {steel} steel cot");
                Console.WriteLine($"Purpouse:{ppose}, Quantity:{qty}, Total: {tamnt}");
            }
            else if (ctype == "wood")
            {
                Console.WriteLine("Enter type of wood teak/Rose wood : ");
                wood = Console.ReadLine();
                Console.WriteLine("Enter quantity of Cot");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter purchase Mode Credit/Debit card: ");
                pmode = Console.ReadLine();
                oid = rnd.Next(1000, 9000);
                rate = rnd.Next(200, 900);
                tamnt = qty * rate;
                Console.WriteLine($"Order ID:{oid}, Date:{odate}, Furniture type: Cot, ChairType: {wood} wood cot");
                Console.WriteLine($"Purpouse:{ppose}, Quantity:{qty}, Total: {tamnt}");
            }
        }
        }
    class rack {
        static void Main() {
            //chair c1 = new chair();
            //c1.getdata();
            cot c2 = new cot();
            c2.getdata();
        }
    }
}