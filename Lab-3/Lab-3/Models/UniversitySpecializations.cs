using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_3.Models
{
    public class UniversitySpecializations
    {
        public int Id { get; set; }
        public int UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University University { get; set; }
        public int SpecId { get; set; }
        [ForeignKey("SpecId")]
        public Specialization Specialization { get; set; }
    }
}