using Example2_SurveyService.SurveyLibrary.Models;
using System.Net.Mail;

namespace Example2_SurveyService.SurveyLibrary
{
    public class SurveyService
    {
        private readonly SmtpClient _smtpClient;
        private readonly IEnumerable<CarManufacturerSurvey> _carManufacturerSurveys;

        public SurveyService(
            IEnumerable<CarManufacturerSurvey> carManufacturerSurveys)
        {
            var emailDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}temp-emails";

            // This is just to help you locate your email directory, feel free to delete this line when not needed
            Console.WriteLine(emailDirectory);

            if (!Directory.Exists(emailDirectory))
                Directory.CreateDirectory(emailDirectory);

            _smtpClient = new SmtpClient();
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
            _smtpClient.PickupDirectoryLocation = $"{AppDomain.CurrentDomain.BaseDirectory}/temp-emails";

            _carManufacturerSurveys = carManufacturerSurveys;
        }

        public void SendSurvey(SendSurveyRequest request)
        {
            if(request.AllowPromotionalEmails)
            {
                var carManufacturerSurvey = _carManufacturerSurveys.First(x => x.CarManufacturer.ToLower() == request.CarManufacturer.ToLower());

                if(carManufacturerSurvey != null)
                    _smtpClient.Send("knowingtomuch@medium.com", request.EmailAddress, carManufacturerSurvey.Subject, carManufacturerSurvey.Body);
            }
        }
    }
}