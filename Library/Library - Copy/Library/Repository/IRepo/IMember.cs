using Library.Models.Entity;

namespace Library.Repository.IRepo
{
    public interface IMember
    {
        Task<IEnumerable<Member>> GetAllMembers();
        Task <Member> Deteils(int id);
        Task Create (Member member);
        Task Delete(Member member);

        Task Update (Member member);
    }
}
