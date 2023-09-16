using Microsoft.EntityFrameworkCore;

namespace Project1.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        #region Dbset
        public DbSet<Book> Books { get; set; }
        #endregion
    }
}
