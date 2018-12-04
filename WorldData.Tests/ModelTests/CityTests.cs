using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldData.Models;
using MySql.Data.MySqlClient;

namespace WorldData.Tests
{
  [TestClass]
  public class CityTest
  {
    [TestMethod]
    public void CityConstructor_CreatesInstanceOfCity_City()
    {
      //Arrange
      City testCity = new City(1, "test-name", "TST", "test-district", 1000);

      //Act and Assert
      Assert.AreEqual(typeof(City), testCity.GetType());
    }


    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      string resultCityName = testCity.GetCityName();

      //Assert
      Assert.AreEqual("test-name", resultCityName);
    }

    [TestMethod]
    public void SetCityName_UpdatesCityName_String()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      string inputCityNameUpdate = "test-name01";
      testCity.SetCityName(inputCityNameUpdate);
      string resultCityName = testCity.GetCityName();

      //Assert
      Assert.AreEqual("test-name01", resultCityName);
    }

    [TestMethod]
    public void GetCountryCode_ReturnsCountryCode_String()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      string resultCountryCode = testCity.GetCountryCode();

      //Assert
      Assert.AreEqual("TST", resultCountryCode);
    }

    [TestMethod]
    public void SetCountryCode_UpdatesCountryCode_String()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      string inputCountryCodeUpdate = "AFG";
      testCity.SetCountryCode(inputCountryCodeUpdate);
      string resultCountryCode = testCity.GetCountryCode();

      //Assert
      Assert.AreEqual("AFG", resultCountryCode);
    }

    [TestMethod]
    public void GetDistrict_ReturnsDistrict_String()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      string resultDistrict = testCity.GetDistrict();

      //Assert
      Assert.AreEqual("test-district", resultDistrict);
    }

    [TestMethod]
    public void SetDistrict_UpdatesDistrict_Void()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      string inputDistrictUpdate = "Kabol";
      testCity.SetDistrict(inputDistrictUpdate);
      string resultDistrict = testCity.GetDistrict();

      //Assert
      Assert.AreEqual("Kabol", resultDistrict);
    }

    [TestMethod]
    public void GetPopulation_ReturnsPopulation_Int()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      int resultPopulation = testCity.GetPopulation();

      //Assert
      Assert.AreEqual(1000, resultPopulation);
    }

    [TestMethod]
    public void SetPopulation_UpdatesPopulation_Void()
    {
      //Arrange
      int inputId = 1;
      string inputCityName = "test-name";
      string inputCountryCode = "TST";
      string inputDistrict = "test-district";
      int inputPopulation = 1000;

      City testCity = new City(inputId, inputCityName, inputCountryCode, inputDistrict, inputPopulation);

      //Act
      int inputPopulationUpdate = 2000;
      testCity.SetPopulation(inputPopulationUpdate);
      int resultPopulation = testCity.GetPopulation();

      //Assert
      Assert.AreEqual(2000, resultPopulation);
    }



  }
}
