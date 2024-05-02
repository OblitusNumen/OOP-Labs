using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_3.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University University { get; set; }
    }
}