namespace _18._12._24_Structures
{
    struct Book
    {
        // Declare the fields for the Books struct
        public string title;
        public string author;
        public string genre;
        public string price;
        public int pages;
        public long isbn; // long is a 64-bit integer for the 13 digit isbn
    }
    class Program
    {
        static void Display_attributes(Book Item)
        {
            Console.WriteLine(Item.title + Item.author + Item.genre + Item.price + Item.pages + Item.isbn);
        }
        static void Main(string[] args)
        {
            // Declare Book1 of type Book
            Book book1 = new Book();

            // Assign values to the Book1 object
            book1.title = "A promised land";
            book1.author = "Barack Obama";
            book1.genre = "Politics";
            book1.price = "10.99";
            book1.pages = 386;
            book1.isbn = 9780241491515;

            Book book2 = new Book();
            // Assign values to the Book2 object
            book2.title = "The promised neverlands";
            book2.author = "Masfg";
            book2.genre = "Visual novel";
            book2.price = "12.99";
            book2.pages = 56;
            book2.isbn = 5802749951141;

            Console.WriteLine(book1.title + book1.author + book1.genre + book1.price + book1.pages + book1.isbn + book2.title + book2.author + book2.genre + book2.price + book2.pages + book2.isbn);

            Book [] array = new Book[1];
            array[0].title = "Vault";
            array[0].author = "Gerardus Goudus";
            array[0].genre = "Sport";
            array[0].price = "9.99";
            array[0].pages = 150;
            array[0].isbn = 0241497891515;


            Display_attributes(array[0]);
        }
    }
}
