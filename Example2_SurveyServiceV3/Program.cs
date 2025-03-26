using Example2_SurveyService.SurveyLibrary;
using Example2_SurveyService.SurveyLibrary.Models;
using Example2_SurveyService.SurveyLibrary.Repositories;
using Example2_SurveyService.SurveyLibrary.Services;

namespace Example2_SurveyService
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mobileManufacturerSurveyRepository = new MobileManufacturerSurveyRepository(new List<MobileManufacturerSurvey>()
            {
                new MobileManufacturerSurvey() {
                    MobileManufacturer = "Sony",
                    Body = "Sony Survey Link",
                    Subject = "Sony Survey"
                }
            });

            new SurveyService(new ConsoleSurveySender(), mobileManufacturerSurveyRepository).SendSurvey(new SendSurveyRequest()
            {
                AllowContacting = true,
                Mobile = "07800123123",
                Filter = "SonY",
                EmailAddress = "test@medium.com"
            });
        }
    }
}