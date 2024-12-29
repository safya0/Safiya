using Library.Models;
using Library.Models.Entity;
using Library.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository
{
    public class MemberRepo : IMember
    {
        private readonly AppDbContext _context;
        public MemberRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Member member)
        {
            await _context.AddAsync(member);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Member member)
        {
            _context.Remove(member);
           await _context.SaveChangesAsync();

        }

        public async Task<Member> Deteils(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            return await _context.Members.ToListAsync();
        }

        public async Task Update(Member member)
        {
            _context.Members.Update(member);
            await _context.SaveChangesAsync();
        }
    }
}
