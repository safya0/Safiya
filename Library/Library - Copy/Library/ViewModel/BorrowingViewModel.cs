using Library.Models.Entity;

namespace Library.ViewModel
{
    public class BorrowingViewModel
    {
        public int RecordId { get; set; }
        public DateOnly ReturnDate { get; set; }
        public DateOnly BorrowDate { get; set; }
        public int Bookid { get; set; }
        public  ICollection <Book> Book { get; set; }
        public int MemberId { get; set; }
        public ICollection <Member> Member { get; set; }
    }
}
