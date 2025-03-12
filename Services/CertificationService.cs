using ABA.CertificationTracker.Repositories;
using ABA.CertificationTracker.Models;

namespace ABA.CertificationTracker.Services
{
    public interface ICertificationService
    {
        Task<List<Certification>> GetCertificationStatusAsync();
    }

    public class CertificationService : ICertificationService
    {
        private readonly ICertificationRepository _certificationRepository;

        public CertificationService(ICertificationRepository certificationRepository)
        {
            _certificationRepository = certificationRepository;
        }

        public async Task<List<Certification>> GetCertificationStatusAsync()
        {
            return await _certificationRepository.GetCertificationStatusAsync();
        }
    }
}