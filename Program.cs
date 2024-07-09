namespace BookManagmentSystem
{
    public class Book
    {
        public int id;
        public string name;
        public string summary;
    }
    public class BookOperations
    {
        static private List<Book> bookList;
        static private int index;

        public BookOperations()
        {
            bookList = new List<Book>(1000);
            index = 1;
            //bookList.Clear();
        }

        public void AddBook(string name, string summary)
        {
            foreach (Book i in bookList)
            {
                if (i.name == name) {
                    Console.WriteLine("We Already have Book with this Name");
                    return;
                }
            }
            Book newBook = new Book();
            newBook.id = ++index;
            newBook.name = name;
            newBook.summary = summary;
            bookList.Add(newBook);
        }

        public void ListAllBook()
        {
            Console.WriteLine("All Books are listed below");
            foreach(Book i in bookList)
            {
                Console.WriteLine($"Book Id : {i.id}");
                Console.WriteLine($"Book Name : {i.name}");
                Console.WriteLine($"Book Summary : {i.summary}");
                Console.WriteLine();
            }
        }

        public void UpdateBook(int id, string name, string summary)
        {
            bool isFound=false;
            foreach (Book i in bookList)
            {
                if(i.id == id)
                {
                    i.id= id;
                    i.name = name;
                    i.summary = summary;
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Error No Book Found By Given Id");
            }
            else
            {
                Console.WriteLine("Updation Done Succesfully");
            }

        }

        public void DeleteBook(int id)
        {
            foreach (Book i in bookList)
            {
                if (i.id == id)
                {
                    bookList.Remove(i);
                    Console.WriteLine($"Book with id {id} is deleted");
                    return;
                }
            }
            Console.WriteLine($"Book with id {id} Not Found");
        }
        ~BookOperations()
        {
            bookList.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BookOperations BMS = new BookOperations();

            int input=0;
            do
            {
                Console.WriteLine("Enter Choice from below operations");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Show All Book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("Press 5 to Stop the program");

                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 5)
                        Console.WriteLine("Enter input between 1 to 5");
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please Enter valid input from above");
                }
                finally
                {
                    Console.WriteLine();
                    string id, name, summary;
                    int idToInt=-1;
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Enter Name");
                            name= Console.ReadLine();
                            Console.WriteLine("Enter Summary");
                            summary = Console.ReadLine();
                            if (name.Equals("") || summary.Equals(""))
                            {
                                Console.WriteLine(" Name or summary are required fields");
                                break;
                            }
                            BMS.AddBook(name, summary);
                            break;
                        case 2:
                            BMS.ListAllBook(); 
                            break;
                        case 3:
                            Console.WriteLine("Enter id");
                            id = Console.ReadLine();
                            Console.WriteLine("Enter Name");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Summary");
                            summary = Console.ReadLine();
                            if (id.Equals("") || name.Equals("") || summary.Equals(""))
                            {
                                Console.WriteLine("Id or Name or summary are required fields");
                                break;
                            }
                            idToInt=-1;
                            try
                            {
                                idToInt = int.Parse(id);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.WriteLine("Please Enter valid input from above");
                                break;
                            }
                            BMS.UpdateBook(idToInt,name,summary);
                            break;
                        case 4:
                            Console.WriteLine("Enter id");
                            id = Console.ReadLine();
                            idToInt = -1;
                            try
                            {
                                idToInt = int.Parse(id);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.WriteLine("Please Enter valid input from above");
                                break;
                            }
                            BMS.DeleteBook(idToInt);
                            break;
                    }
                }
                
            } while (input != 5);
        }
    }
}
