using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("questions")]
    public class Question
    {
        public int Id { get; set; }
        
        [Column("public_id")]
        public Guid PublicId { get; set; } = Guid.NewGuid();
        
        public string Statement { get; set; } = string.Empty;

        [Column("lesson_id")]
        public int LessonId { get; set; }

        [Column("unity_id")]
        public int UnityId { get; set; }

        public ICollection<Alternative> Alternatives { get; set; } = [];
    }
}