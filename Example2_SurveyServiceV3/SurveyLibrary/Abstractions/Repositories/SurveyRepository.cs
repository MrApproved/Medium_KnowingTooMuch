using Example2_SurveyService.SurveyLibrary.Interfaces.Models;

namespace Example2_SurveyService.SurveyLibrary.Interfaces.Repositories
{
    public interface SurveyRepository
    {
        Survey Search(string filter);
    }
}
