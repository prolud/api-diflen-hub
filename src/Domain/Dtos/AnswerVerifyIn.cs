namespace Domain.Dtos
{
    public class AnswerVerifyIn
    {
        public int LessonId { get; set; }
        public required string UnityName { get; set; }
        public List<AlternativeDtoIn> Answers { get; set; } = [];
    }
}