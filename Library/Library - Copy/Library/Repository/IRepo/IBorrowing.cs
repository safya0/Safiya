using Library.Models.Entity;
using Library.ViewModel;

namespace Library.Repository.IRepo
{
    public interface IBorrowing
    {
        Task<IEnumerable<BorrowingRecord>> GetAllBorrowing();
        Task Create (BorrowingViewModel viewModel);
        Task Delete(BorrowingRecord record);
        Task Update (BorrowingViewModel borrowingRecord,int id);
        Task <BorrowingRecord> Details(int id);
    }
}
