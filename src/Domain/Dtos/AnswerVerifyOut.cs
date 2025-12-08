namespace Domain.Dtos
{
    public class AnswerVerifyOut
    {
        public required int QuestionId { get; set; }
        public required int AlternativeId { get; set; }
        public bool IsCorrect { get; set; }
    }
}