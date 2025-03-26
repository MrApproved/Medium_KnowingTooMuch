namespace Example2_SurveyService.SurveyLibrary.Models
{
    public class SendSurveyRequest
    {
        public string EmailAddress { get; set; }
        public string Filter { get; set; }
        public bool AllowPromotionalEmails { get; set; }
    }
}
