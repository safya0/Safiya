using Library.Models;
using Library.Models.Entity;
using Library.Repository.IRepo;
using Library.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository
{
    public class BorrowingRepo : IBorrowing
    {
        private readonly AppDbContext _context;
        public BorrowingRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(BorrowingViewModel viewModel)
        {
            BorrowingRecord record = new BorrowingRecord()
            {
                ReturnDate = viewModel.ReturnDate,
                BorrowDate = viewModel.BorrowDate,
                RecordId = viewModel.RecordId,
                MemberId = viewModel.MemberId,
                Bookid = viewModel.Bookid,
            };
            await _context.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(BorrowingRecord record)
        {
            _context.Remove(record);
            await _context.SaveChangesAsync();
        }

        public async Task<BorrowingRecord> Details(int id)
        {
            return await _context.BorrowingRecords.Include(x => x.Book).Include(x => x.Member).FirstOrDefaultAsync(x => x.RecordId == id);
        }

        public async Task<IEnumerable<BorrowingRecord>> GetAllBorrowing()
        {
            return await _context.BorrowingRecords.Include(x => x.Book).Include(x => x.Member).ToListAsync();
        }

        public async Task Update(BorrowingViewModel viewModel, int id)
        {
            var Y = await _context.BorrowingRecords.FindAsync(id);
            Y.BorrowDate = viewModel.BorrowDate;
            Y.ReturnDate = viewModel.ReturnDate;
            Y.MemberId = viewModel.MemberId;
            Y.Bookid = viewModel.Bookid;
            await _context.SaveChangesAsync();
        }
    }
}
