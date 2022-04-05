using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.kl;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while(true)
            {
                list.Add(getchapters());
                Console.WriteLine("Press 1 to exit...");
                int x=int.Parse(Console.ReadLine());
                if(x==1)
                {
                    break;
                }
            }
            Book book = new Book("author",50, list,6,200,true);
            Console.WriteLine(book.get_bookmark());
            book.set_bookmark(5);
            Console.WriteLine(book.get_bookmark());
            Console.WriteLine(book.get_price());
            book.set_price(500);
            Console.WriteLine(book.get_price());
            Console.WriteLine(book.is_available());
            Console.WriteLine(book.getChapter(3));
            Console.ReadKey();
        }
        static string getchapters()
        {
            Console.Write("Enter the name of chapters : ");
            string ch=Console.ReadLine();
            return ch;
        }
    }
}
