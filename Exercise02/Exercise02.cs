using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            Novel novel = new Novel(2);
            novel[0] = new Book("100 - 123 - 456", "The American", 101);
            novel[1] = new Book("110 - 133 - 567", "City of the Sun", 203);
            Console.WriteLine("CATEGORY: NOVEL");
            novel.DisplayInfor();

            Console.ReadKey();
        }
    }
}
