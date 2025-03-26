using Example2_SurveyService.SurveyLibrary.Interfaces.Models;

namespace Example2_SurveyService.SurveyLibrary.Models
{
    public class CarManufacturerSurvey : Survey
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string CarManufacturer { get; set; }
    }
}