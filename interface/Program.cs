namespace inter;



interface Payable {
    public int retrive();
    public void Add(int x);
    public void Address(string s);
}

class check0 : Payable {
    public int amount = 0;
    public int retrive() { 
        return amount;
    }
    public void Add(int x) { amount += x; }
    public void Address(string s) { Console.WriteLine($"Your address is: {s}"); }
}
class Program
{
    static void Main(string[] args)
    {
       check0 c=new check0();
        c.Add(5);
        Console.WriteLine($"Your total due amount is: {c.retrive()}");
        c.Add(9);
        Console.WriteLine($"Your total due amount is: {c.retrive()}");
        c.Add(11);
        Console.WriteLine($"Your total due amount is: {c.retrive()}");
        c.Address("National Highway, Silchar");
    }
}
