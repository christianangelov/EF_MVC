using System.ComponentModel.DataAnnotations;

namespace EFMVC.Models
{
    public class Subject
    {
        //Key is when the field is a primary key
        [Key]
        public int SubjectId { get; set; }
        // ? is when the field can be nullable 
        public string? SubjectName { get; set; }
        // [Required] is when the field is not nullable 
      
        public string? SubjectTerm { get; set; }
        public int SubjectCredets { get; set; }

    }
}
