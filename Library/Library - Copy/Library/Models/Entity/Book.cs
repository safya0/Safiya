using System.ComponentModel.DataAnnotations;

namespace Library.Models.Entity
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Gener { get; set; }
        public string Author { get; set; }
        public ICollection  <BorrowingRecord> Borrowing { get; set; }
    }
}
