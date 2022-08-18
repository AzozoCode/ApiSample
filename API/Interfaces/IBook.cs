using Library_Data.Models;

namespace API.Interfaces
{
    public interface IBook
    {
        Task<IEnumerable<Book>> GetBooks();
        Book GetBook(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        Task SaveChanges();
    }
}
