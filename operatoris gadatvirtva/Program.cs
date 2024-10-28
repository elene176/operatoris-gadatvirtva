using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoris_gadatvirtva
{
    class Book


    {
            public string Title { get; }
            public int Pages { get; }

            public Book(string title, int pages)
            {
                Title = title;
                Pages = pages;
            }

            // ოპერატორის გადატვირთვა: წიგნების რაოდენობის დამატება
            public static int operator -(Book b1, Book b2)
            {
                return b1.Pages - b2.Pages;
            }

            public override string ToString()
            {
                return $"{Title} - {Pages} pages";
            }
        }

        class Program
        {
            static void Main()
            {
                Book book1 = new Book("Redhead", 20);
                Book book2 = new Book("Its ash", 10);

                // წიგნების გვერდების რაოდენობის დამატება
                int totalPages = book1 - book2;
                Console.WriteLine($"Total Pages: {totalPages}"); 

                // წიგნების ინფორმაცია
                Console.WriteLine(book1);
                Console.WriteLine(book2);
                Console.ReadLine();
            }
        }
    }
    

