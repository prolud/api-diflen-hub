using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Models
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }
        [Column("public_id")]
        public Guid PublicId { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public long Experience { get; set; }
        public bool Status { get; set; }

        [Column("file_type")]
        public string? FileType
        {
            get
            {
                return field ?? "";
            }
            set;
        }

        [Column("profile_picture")]
        public byte[]? ProfilePicture
        {
            get
            {
                return field ?? [];
            }
            set;
        }
    }
}
