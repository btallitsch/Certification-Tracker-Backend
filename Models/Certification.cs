namespace ABA.CertificationTracker.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
    }
}