using Example2_SurveyService.SurveyLibrary.Abstractions.Models;
using Example2_SurveyService.SurveyLibrary.Abstractions.Repositories;
using Example2_SurveyService.SurveyLibrary.Models;

namespace Example2_SurveyService.SurveyLibrary.Repositories
{
    public class CarManufacturerSurveyRepository : SurveyRepository
    {
        private readonly IEnumerable<CarManufacturerSurvey> _surveys;
        public CarManufacturerSurveyRepository(IEnumerable<CarManufacturerSurvey> surveys) 
        {
            _surveys = surveys;
        }

        public Survey Search(string filter)
            => _surveys.First(x => x.Filter.ToLower() == filter.ToLower());
    }
}
