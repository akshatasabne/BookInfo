using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo
{
    internal class BookDetails
    {
        int book_id;
        string Book_name;
        double price;

        public BookDetails()
        {
            book_id = 123 ;
            Book_name = "Integrity";
            price = 500;
        }
        public BookDetails(int book_id, string book_name, double price)
        {
            book_id = book_id;
            Book_name = book_name;
            price = price;
        }
        public string printdata()
        {
            return $" Book_id {book_id} \n book_name {Book_name} \n {price}";
        }
    }
}
