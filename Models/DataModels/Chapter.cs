using System.ComponentModel.DataAnnotations;

namespace UniversityAPI2.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        [Required]
        public string Chapters { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
    }
}
