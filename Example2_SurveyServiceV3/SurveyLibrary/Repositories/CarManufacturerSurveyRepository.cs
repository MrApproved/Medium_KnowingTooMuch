using Example2_SurveyService.SurveyLibrary.Interfaces.Models;
using Example2_SurveyService.SurveyLibrary.Interfaces.Repositories;
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
            => _surveys.First(x => x.CarManufacturer.ToLower() == filter.ToLower());
    }
}
