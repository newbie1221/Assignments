namespace ConstructorAssignment
{
    class check {
        string firstname="xyz";
        string lastname= "last";
        string email= "limboo@gmail.com";
        DateOnly dob = DateOnly.Parse("1.1.1111");

        public check(string firstname, string lastname, string email, DateOnly dob) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.dob = dob;
        }

        public check(string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public check(string firstname, string lastname, DateOnly dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
        }
        public void show() {
            Console.WriteLine(this.firstname);
            Console.WriteLine(this.lastname);
            Console.WriteLine(this.email);  
            Console.WriteLine(this.dob);    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            check c0 = new check("jackel551", "morphine991", "perimiter@gmail.com", DateOnly.Parse("10.1.2000"));
            c0.show();
            check c = new check("jackel", "morphine", "abc@gmail.com");
            c.show();
            check c1 = new check("jackel111", "morphine111", DateOnly.Parse("13.3.1999"));
            c1.show();
        }
    }
}