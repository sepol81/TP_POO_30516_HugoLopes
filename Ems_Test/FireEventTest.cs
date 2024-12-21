using EMS.enums;
using EMS.models.Events;
using System;
using Xunit;

namespace EMS.Tests
{
    public class FireEventTests
    {
        #region Constructor Tests

        [Fact]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            var type = TypeEvent.Incêndio;
            var address = "39 rua da Foz";
            var startEventDate = new DateTime(2024, 12, 15, 10, 0, 0);
            var endEventDate = new DateTime(2024, 12, 15, 12, 0, 0);
            var description = "Uma casa pegou fogo causada por uma botija de gás.";
            var severityLevel = EventSeverityLevel.Critica;
            var status = StatusEvent.EmProgresso;
            var typeOfFire = TypeOfFire.Classe_D;
            var fireIntensity = "Alta";
            var affectedArea = 2000.0; // Área afetada (m²)

            // Act
            var fireEvent = new FireEvent(
                type, address, startEventDate, endEventDate, description,
                severityLevel, status, typeOfFire, fireIntensity, affectedArea);

            // Assert
            Assert.Equal(type, fireEvent.Type);
            Assert.Equal(address, fireEvent.Address);
            Assert.Equal(startEventDate, fireEvent.StartEventDate);
            Assert.Equal(endEventDate, fireEvent.EndEventDate);
            Assert.Equal(description, fireEvent.Description);
            Assert.Equal(severityLevel, fireEvent.SeverityLevel);
            Assert.Equal(status, fireEvent.Status);
            Assert.Equal(typeOfFire, fireEvent.TypeOfFire);
            Assert.Equal(fireIntensity, fireEvent.FireIntensity);
            Assert.Equal(affectedArea, fireEvent.AffectedArea);
        }
 #endregion
    } 
}    
