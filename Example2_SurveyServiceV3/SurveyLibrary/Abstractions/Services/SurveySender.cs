using Example2_SurveyService.SurveyLibrary.Interfaces.Models;
using Example2_SurveyService.SurveyLibrary.Models;

namespace Example2_SurveyService.SurveyLibrary.Interfaces.Services
{
    public interface SurveySender
    {
        void Send(SendSurveyRequest request, Survey survey);
    }
}
