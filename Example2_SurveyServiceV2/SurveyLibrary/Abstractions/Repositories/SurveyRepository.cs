using Example2_SurveyService.SurveyLibrary.Abstractions.Models;

namespace Example2_SurveyService.SurveyLibrary.Abstractions.Repositories
{
    public interface SurveyRepository
    {
        Survey Search(string filter);
    }
}
