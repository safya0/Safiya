using Library.Models;
using Library.Models.Entity;
using Library.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository
{
    public class BookRepo : IBook
    {
        private readonly AppDbContext _context;
        public BookRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Book Book)
        {
            await _context.AddAsync(Book);
            await _context.SaveChangesAsync();
        }

        public  async Task Delete(Book Book)
        {
            _context.Remove(Book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book> Deteils(int id)
        {
            return await _context.Books.FindAsync(id);

        }

        public async Task<IEnumerable<Book>> GetAllBook()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task Update(Book Book)
        {
            _context.Books.Update(Book);
            await _context.SaveChangesAsync();
        }
    }
}
