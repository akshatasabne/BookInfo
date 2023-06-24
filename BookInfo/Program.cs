using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookDetails details = new BookDetails();
            Console.WriteLine(details.printdata());
            BookDetails details1 = new BookDetails(125,"Risk",450);
            Console.WriteLine(details1.printdata());
        }
    }
}
