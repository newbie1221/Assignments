namespace assignment5
{

    class Accounts {
        public int accountno;
        public string custname;
        public string acctype;
        public char ttype;
        public int amount;
        public int balance=1000;
        public void show() {
            Console.WriteLine($"Account no: {accountno}, Custname:{custname}, acctype:{acctype}, Balance:{balance}");
        }
    }
    class check0
        {
        Accounts accounts=new Accounts();
        
        public void check(string ttype, int amt)
        {
            if (ttype == "w")
                debit(amt);
            else
                credit(amt);
        }
        public void debit(int amt) {
            accounts.balance = accounts.balance - amt;
            Console.WriteLine($"Account no: {accounts.accountno}, Custname:{accounts.custname}, acctype:{accounts.acctype}, Transaction:w, Amount:{amt}, Balance:{accounts.balance}");
            
        }
        public void credit(int amt)
        {
            accounts.balance = accounts.balance + amt;
            Console.WriteLine($"Account no: {accounts.accountno}, Custname:{accounts.custname}, acctype:{accounts.acctype}, Transaction:d, Amount:{amt}, Balance:{accounts.balance}");
        }
        public void accept(int acno,string cusname,string acctype) {
            accounts.accountno = acno;
            accounts.custname = cusname;
            accounts.acctype = acctype;
        }
        public Accounts show() {
            return accounts;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            check0 c1=new check0();
            c1.accept(1815001, "Debopriyo", "Savings");
            
            Accounts accounts=new Accounts();
            accounts = c1.show();
            accounts.show();
            c1.check("w", 540);
            accounts.show();
            c1.check("f", 500);
            accounts = c1.show();
            accounts.show();
        }
    }
}