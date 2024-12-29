using System.ComponentModel.DataAnnotations;

namespace Library.Models.Entity
{
    public class BorrowingRecord
    {
        [Key]
        public int RecordId { get; set; }
        public DateOnly ReturnDate { get; set; }    
        public DateOnly	BorrowDate { get; set; }
        public int  Bookid { get; set; }
        public Book Book { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
