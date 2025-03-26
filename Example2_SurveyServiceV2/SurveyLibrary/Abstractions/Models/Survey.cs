namespace Example2_SurveyService.SurveyLibrary.Abstractions.Models
{
    public interface Survey
    {
        string Subject { get; set; }
        string Body { get; set; }
        string Filter { get; set; }
    }
}