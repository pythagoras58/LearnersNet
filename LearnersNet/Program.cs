using System;

namespace LearnersNet
{
    class Program
    {
        public struct Book
        {
            public decimal price;
            public string author;
            public string title;


        }

        static void Main(string[] args)
        {
            /*Book book;
            book.author = "Pythagoras Danso";
            book.title = "My love for you";
            book.price = 90.24m; */

            //Console.WriteLine(book.ToString());

            int[] myArr = new int[4];
            myArr[0] = 3;
            myArr[1] = 13;
            myArr[2] = 23;
            myArr[3] = 33;

            Console.WriteLine(myArr.Length);

        }
    }
}
