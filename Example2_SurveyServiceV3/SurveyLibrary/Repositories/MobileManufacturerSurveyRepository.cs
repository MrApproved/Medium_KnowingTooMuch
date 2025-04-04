﻿using Example2_SurveyService.SurveyLibrary.Interfaces.Models;
using Example2_SurveyService.SurveyLibrary.Interfaces.Repositories;
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
            => _surveys.First(x => x.MobileManufacturer.ToLower() == filter.ToLower());
    }
}
