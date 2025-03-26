using Example2_SurveyService.SurveyLibrary.Abstractions.Models;
using Example2_SurveyService.SurveyLibrary.Abstractions.Repositories;
using Example2_SurveyService.SurveyLibrary.Models;

namespace Example2_SurveyService.SurveyLibrary.Repositories
{
    public class MobileManufacturerSurveyRepository : SurveyRepository
    {
        private readonly IEnumerable<MobileManufacturerSurvey> _surveys;
        public MobileManufacturerSurveyRepository(IEnumerable<MobileManufacturerSurvey> surveys) 
        {
            _surveys = surveys;
        }

        public Survey Search(string filter)
            => _surveys.First(x => x.Filter.ToLower() == filter.ToLower());
    }
}
