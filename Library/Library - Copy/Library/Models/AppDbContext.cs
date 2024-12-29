using Library.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext> options ) : base( options) { }
       public   DbSet    <Member> Members { get; set; } 
        public DbSet <Book> Books { get; set; }
        public DbSet<BorrowingRecord> BorrowingRecords { get; set; }
    }
}
