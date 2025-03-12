using ABA.CertificationTracker.Data;
using ABA.CertificationTracker.Models;

namespace ABA.CertificationTracker.Repositories
{
    public interface ICertificationRepository
    {
        Task<List<Certification>> GetCertificationStatusAsync();
    }

    public class CertificationRepository : ICertificationRepository
    {
        private readonly ApplicationDbContext _context;

        public CertificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Certification>> GetCertificationStatusAsync()
        {
            return await _context.Certifications.ToListAsync();
        }
    }
}