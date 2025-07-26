namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region video 1 (Indexer)
            PhoneBook phoneBook = new PhoneBook(5);
            phoneBook.AddPerson(0, "Ahmed", 1234567890);
            phoneBook.AddPerson(1, "Sara", 9876543210);
            phoneBook.AddPerson(2, "Ali", 5555555555);

            long number = phoneBook.GetNumber("Sara");
            phoneBook["Ahmed"] = 2432114;

            #endregion
        }
    }
}
