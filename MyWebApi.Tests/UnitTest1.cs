using Xunit;
using MyWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebApi.Tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ReturnsListOfWeatherForecast()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<WeatherForecast[]>(result); // Accepter un tableau ici
            Assert.NotEmpty(okResult);  // Vérifier que la liste n'est pas vide
        }

    }
}
