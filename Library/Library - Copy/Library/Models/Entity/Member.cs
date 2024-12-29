using System.ComponentModel.DataAnnotations;

namespace Library.Models.Entity
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string Name { get; set; }
        public DateOnly MembershipDate { get; set; }
        public ICollection <BorrowingRecord> BorrowingRecord { get; set; }
    }
}
