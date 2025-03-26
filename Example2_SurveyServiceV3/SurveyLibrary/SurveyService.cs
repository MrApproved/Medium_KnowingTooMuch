using Example2_SurveyService.SurveyLibrary.Interfaces.Repositories;
using Example2_SurveyService.SurveyLibrary.Interfaces.Services;
using Example2_SurveyService.SurveyLibrary.Models;

namespace Example2_SurveyService.SurveyLibrary
{
    public class SurveyService
    {
        private readonly SurveySender _sender;
        private readonly SurveyRepository _surveys;

        public SurveyService(
            SurveySender sender,
            SurveyRepository surveys)
        {
            _sender = sender;
            _surveys = surveys;
        }

        public void SendSurvey(SendSurveyRequest request)
        {
            if(request.AllowContacting)
            {
                var survey = _surveys.Search(request.Filter);

                if(survey != null)
                    _sender.Send(request, survey);
            }
        }
    }
}