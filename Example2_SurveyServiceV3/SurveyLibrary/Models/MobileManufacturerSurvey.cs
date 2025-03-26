using Example2_SurveyService.SurveyLibrary.Interfaces.Models;

namespace Example2_SurveyService.SurveyLibrary.Models
{
    public class MobileManufacturerSurvey : Survey
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string MobileManufacturer { get; set; }
    }
}