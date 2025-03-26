using Example2_SurveyService.SurveyLibrary.Abstractions.Models;
using Example2_SurveyService.SurveyLibrary.Abstractions.Repositories;
using Example2_SurveyService.SurveyLibrary.Models;
using System.Net.Mail;

namespace Example2_SurveyService.SurveyLibrary
{
    public class SurveyService
    {
        private readonly SmtpClient _smtpClient;
        private readonly SurveyRepository _surveys;

        public SurveyService(
            SurveyRepository surveys)
        {
            var emailDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}temp-emails";

            // This is just to help you locate your email directory, feel free to delete this line when not needed
            Console.WriteLine(emailDirectory);

            if (!Directory.Exists(emailDirectory))
                Directory.CreateDirectory(emailDirectory);

            _smtpClient = new SmtpClient();
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
            _smtpClient.PickupDirectoryLocation = $"{AppDomain.CurrentDomain.BaseDirectory}/temp-emails";

            _surveys = surveys;
        }

        public void SendSurvey(SendSurveyRequest request)
        {
            if(request.AllowPromotionalEmails)
            {
                var survey = _surveys.Search(request.Filter);

                if(survey != null)
                    _smtpClient.Send("knowingtomuch@medium.com", request.EmailAddress, survey.Subject, survey.Body);
            }
        }
    }
}