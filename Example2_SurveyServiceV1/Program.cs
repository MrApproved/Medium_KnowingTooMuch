using Example2_SurveyService.SurveyLibrary;
using Example2_SurveyService.SurveyLibrary.Models;

namespace Example2_SurveyService
{
    public class Program
    {
        static void Main(string[] args)
        {
            var surveyService = new SurveyService(
                new List<CarManufacturerSurvey>()
                {
                    new CarManufacturerSurvey() {
                        CarManufacturer = "Fiat",
                        Body = "Fiat Survey Link",
                        Subject = "Fiat Survey"
                    }
                });

            surveyService.SendSurvey(new SendSurveyRequest()
            {
                AllowPromotionalEmails = true,
                CarManufacturer = "FIAT",
                EmailAddress = "test@medium.com"
            });
        }
    }
}