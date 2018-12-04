using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WorldData.Models
{
  public class City
  {
    private int _id;
    private string _cityName;
    private string _countryCode;
    private string _district;
    private int _population;
    private List<City> _cityList;

    public City(int id, string cityName, string countryCode, string district, int population)
    {
      _id = id;
      _cityName = cityName;
      _countryCode = countryCode;
      _district = district;
      _population = population;
      _cityList = new List<City>{};
    }

    public static List<City> GetAll()
    {
      List<City> allCities = new List<City> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM city;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int cityId = rdr.GetInt32(0);
        string cityName = rdr.GetString(1);
        string countryCode = rdr.GetString(2);
        string district = rdr.GetString(3);
        int population = rdr.GetInt32(4);
        City newCity = new City(cityId, cityName, countryCode, district, population);
        allCities.Add(newCity);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allCities;
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
