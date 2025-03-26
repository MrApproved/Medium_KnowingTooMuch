using Example2_SurveyService.SurveyLibrary.Interfaces.Models;
using Example2_SurveyService.SurveyLibrary.Interfaces.Services;
using Example2_SurveyService.SurveyLibrary.Models;

namespace Example2_SurveyService.SurveyLibrary.Services
{
    public class ConsoleSurveySender : SurveySender
    {
        public void Send(SendSurveyRequest request, Survey survey)
            => Console.WriteLine($"knowingtomuch@medium.com - {request.Mobile}. Subject: {survey.Subject} - {survey.Body}");
    }
}
