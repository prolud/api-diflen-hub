namespace Domain.Dtos
{
    public class UnityDtoOut
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public bool WasAllQuestionsCorrectlyAnswered { get; set; }
        public bool WasCertificateAlreadyIssued { get; set; }
    }
}