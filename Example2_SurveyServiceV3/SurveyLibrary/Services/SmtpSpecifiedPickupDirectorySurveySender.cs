using Example2_SurveyService.SurveyLibrary.Interfaces.Models;
using Example2_SurveyService.SurveyLibrary.Interfaces.Services;
using Example2_SurveyService.SurveyLibrary.Models;
using System.Net.Mail;

namespace Example2_SurveyService.SurveyLibrary.Services
{
    public class SmtpSpecifiedPickupDirectorySurveySender : SurveySender
    {
        private readonly SmtpClient _smtpClient;
        public SmtpSpecifiedPickupDirectorySurveySender()
        {
            var emailDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}temp-emails";

            // This is just to help you locate your email directory, feel free to delete this line when not needed
            Console.WriteLine(emailDirectory);

            if (!Directory.Exists(emailDirectory))
                Directory.CreateDirectory(emailDirectory);

            _smtpClient = new SmtpClient();
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
            _smtpClient.PickupDirectoryLocation = $"{AppDomain.CurrentDomain.BaseDirectory}/temp-emails";
        }

        public void Send(SendSurveyRequest request, Survey survey)
            => _smtpClient.Send("knowingtomuch@medium.com", request.EmailAddress, survey.Subject, survey.Body);
    }
}
