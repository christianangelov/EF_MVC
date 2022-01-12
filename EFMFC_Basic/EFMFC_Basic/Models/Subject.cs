using System.ComponentModel.DataAnnotations;

namespace EFMFC_Basic.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        // ? when nullable 
        public string? SubjectName { get; set; }
        // [Required] when not null 
        public string? SubjectTerm { get; set; }
        public int SubjectCredits { get; set; }
    }
}
