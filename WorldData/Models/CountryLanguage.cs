using System;
using MySql.Data.MySqlClient;

namespace WorldData.Models
{
    public class CountryLanguage
    {
         private string _countryCode;
         private string _language;
         private bool _isOfficial;
         private float _percentage;

        public CountryLanguage(string countryCode, string language, bool isOfficial, float percentage)
        {
            _countryCode = countryCode;
            _language = language;
            _isOfficial = isOfficial;
            _percentage = percentage;
        }

        public string GetCountryCode()
        {
            return _countryCode;
        }

        public void SetCountryCode(string countryCode)
        {
            _countryCode = countryCode;
        }

        public string GetLanguage()
        {
            return _language;
        }

        public void SetLanguage(string language)
        {
            _language = language;
        }

        public bool GetIsOfficial()
        {
            return _isOfficial;
        }

        public void SetIsOfficial(bool isOfficial)
        {
            _isOfficial = isOfficial;
        }

        public float GetPercentage()
        {
            return _percentage;
        }

        public void SetPercentage(float percentage)
        {
            _percentage = percentage;
        }
    }
}
