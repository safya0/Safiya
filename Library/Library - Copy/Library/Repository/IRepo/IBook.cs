using Library.Models.Entity;

namespace Library.Repository.IRepo
{
    public interface IBook
    {
        Task<IEnumerable<Book>> GetAllBook();
        Task<Book> Deteils(int id);
        Task Create(Book Book);
        Task Delete(Book Book);
        Task Update(Book Book);
    }
}
