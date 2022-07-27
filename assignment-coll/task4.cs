using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_coll
{
    public class Bookstore {
        public int Bookid;
        public String BookName;
    }
    internal class task4
    {
        static void Main() {
            
            Hashtable h = new Hashtable();
            h.Add(1,new Bookstore() { Bookid = 1815, BookName = "Jackel" }) ;
            h.Add(2, new Bookstore() { Bookid = 1810, BookName = "Maroon" });
            h.Add(3, new Bookstore() { Bookid = 1812, BookName = "Hentai" });
            h.Add(4, new Bookstore() { Bookid = 1813, BookName = "Drake" });
            h.Add(5, new Bookstore() { Bookid = 1814, BookName = "Nausea" });
            foreach (var i in h.Keys)
            {
                Bookstore b=(Bookstore)h[i];
                Console.WriteLine($"Bookid: {b.Bookid} , Bookname: {b.BookName}");
            }
        }
    }
}
