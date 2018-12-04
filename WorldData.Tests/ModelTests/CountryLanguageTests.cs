
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldData.Models;
using MySql.Data.MySqlClient;

namespace WorldData.Tests
{
  [TestClass]
  public class CountryLanguageTest
  {
    [TestMethod]
    public void CountryLanguageConstructor_CreatesInstanceOfCountryLanguage_CountryLanguage()
    {
      //Arrange
      CountryLanguage testCountryLanguage = new CountryLanguage("TST", "test-language", true, 4.0f);

      //Act and Assert
      Assert.AreEqual(typeof(CountryLanguage), testCountryLanguage.GetType());
    }


    [TestMethod]
    public void GetCountryCode_ReturnsCountryCode_String()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);

      //Act
      string resultCountryCode = testCountryLanguage.GetCountryCode();

      //Assert
      Assert.AreEqual("TST", resultCountryCode);
    }

    [TestMethod]
    public void SetCountryCode_UpdatesCountryCode_Void()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);


      //Act
      string inputCountryCodeUpdate = "AFG";
      testCountryLanguage.SetCountryCode(inputCountryCodeUpdate);
      string resultCountryCode = testCountryLanguage.GetCountryCode();

      //Assert
      Assert.AreEqual("AFG", resultCountryCode);
    }

    [TestMethod]
    public void GetLanguage_ReturnsLanguage_String()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);

      //Act
      string resultLanguage = testCountryLanguage.GetLanguage();

      //Assert
      Assert.AreEqual("test-Language", resultLanguage);
    }

    [TestMethod]
    public void SetLanguage_UpdatesLanguage_Void()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);


      //Act
      string inputLanguageUpdate = "test-Language01";
      testCountryLanguage.SetLanguage(inputLanguageUpdate);
      string resultLanguage = testCountryLanguage.GetLanguage();

      //Assert
      Assert.AreEqual("test-Language01", resultLanguage);
    }

    [TestMethod]
    public void GetIsOfficial_ReturnsIsOfficial_Bool()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);

      //Act
      bool resultIsOfficial = testCountryLanguage.GetIsOfficial();

      //Assert
      Assert.AreEqual(true, resultIsOfficial);
    }

    [TestMethod]
    public void SetIsOfficial_UpdatesIsOfficial_Void()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);


      //Act
      bool inputIsOfficialUpdate = false;
      testCountryLanguage.SetIsOfficial(inputIsOfficialUpdate);
      bool resultIsOfficial = testCountryLanguage.GetIsOfficial();

      //Assert
      Assert.AreEqual(false, resultIsOfficial);
    }

    [TestMethod]
    public void GetPercentage_ReturnsPercentage_float()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);

      //Act
      float resultPercentage = testCountryLanguage.GetPercentage();

      //Assert
      Assert.AreEqual(4.0f, resultPercentage);
    }

    [TestMethod]
    public void SetPercentage_UpdatesPercentage_Void()
    {
      //Arrange
      string inputCountryCode = "TST";
      string inputLanguage = "test-Language";
      bool inputIsOfficial = true;
      float inputPercentage = 4.0f;

      CountryLanguage testCountryLanguage = new CountryLanguage(inputCountryCode, inputLanguage, inputIsOfficial, inputPercentage);


      //Act
      float inputPercentageUpdate = 4.4f;
      testCountryLanguage.SetPercentage(inputPercentageUpdate);
      float resultPercentage = testCountryLanguage.GetPercentage();

      //Assert
      Assert.AreEqual(4.4f, resultPercentage);
    }


  }
}
