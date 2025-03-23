namespace _18._12._24_BinaryReader
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

            WriteBinaryFile(book1);
            Book ItemFromBinary = ReadBinaryFile();

            Console.WriteLine(ItemFromBinary.title);
        }
        static void WriteBinaryFile(Book book)
        {
            string filename = "Binary file.bin";
            using (BinaryWriter writer = new BinaryWriter (File.Open(filename,FileMode.Create)))
            {
                writer.Write(book.title);
                writer.Write(book.author); 
            }
        }
        static void ReadBinaryFile(Book book)
        {
            string filename = "Binary file.bin";
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                Book book = new Book();

                book.title = reader.ReadString();
                book.author = reader.ReadString();

                return book;
            }
        }
    }
}
