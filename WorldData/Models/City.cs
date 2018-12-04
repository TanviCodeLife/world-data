using System;
using MySql.Data.MySqlClient;

namespace WorldData.Models
{
    public class City
    {
         private int _id;
         private string _cityName;
         private string _countryCode;
         private string _district;
         private int _population;

        public City(int id, string cityName, string countryCode, string district, int population)
        {
            _id = id;
            _cityName = cityName;
            _countryCode = countryCode;
            _district = district;
            _population = population;
        }

        public int GetId()
        {
            return _id;
        }


        public string GetCityName()
        {
            return _cityName;
        }

        public void SetCityName(string cityName)
        {
            _cityName = cityName;
        }

        public string GetCountryCode()
        {
            return _countryCode;
        }

        public void SetCountryCode(string countryCode)
        {
            _countryCode = countryCode;
        }

        public string GetDistrict()
        {
            return _district;
        }

        public void SetDistrict(string district)
        {
            _district = district;
        }

        public int GetPopulation()
        {
            return _population;
        }

        public void SetPopulation(int population)
        {
            _population = population;
        }

    }
}
