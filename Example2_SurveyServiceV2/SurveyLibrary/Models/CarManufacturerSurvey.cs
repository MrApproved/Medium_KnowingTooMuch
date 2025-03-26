using Example2_SurveyService.SurveyLibrary.Abstractions.Models;

namespace Example2_SurveyService.SurveyLibrary.Models
{
    public class CarManufacturerSurvey : Survey
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Filter { get; set; }
    }
}