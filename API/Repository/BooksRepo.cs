
using API.Interfaces;
using Library_Data.Data_Access;
using Library_Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class BooksRepo:IBook
    {
        private readonly LibraryDbContext db;

        public BooksRepo(LibraryDbContext db)
        {
            this.db = db;
        }

        public void AddBook(Book book)
        {
            db.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book = db.Books.Find(id); 

            if(book != null)
            {
                db.Books.Remove(book);
            }
        }

        public Book GetBook(int id)
        {
            return db.Books.Find(id);

            //var book = db.Books.Where(x => x.BookID == id).FirstOrDefault();
            //if(book != null)
            //{
            //    return book;
            //}
            //return null;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await db.Books.ToListAsync();
        }

        public async Task SaveChanges()
        {
            await db.SaveChangesAsync();
        }

        public void UpdateBook(Book book)
        {
            var item = db.Books.FirstOrDefault(x => x.Title == book.Title);

            if(item != null)
            {
                book.Author = item.Author;
                book.DatePublished = item.DatePublished;
            }
        }
        
    }
}
