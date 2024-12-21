using EMS.enums;
using EMS.models.Events;
using System;
using Xunit;

namespace EMS.Tests
{
    public class MedicalEventTests
    {
        #region Constructor Tests        
        /// <summary>
        /// Constructors the should initialize properties correctly.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            var type = TypeEvent.Medical;
            var address = "26 rua do Tanque";
            var startEventDate = new DateTime(2024, 12, 15, 8, 0, 0);
            var endEventDate = new DateTime(2024, 12, 15, 10, 0, 0);
            var description = "Paciente tropeçou e caiu no passeio";
            var severityLevel = EventSeverityLevel.Moderada;
            var status = StatusEvent.Concluído;
            var numberOfVictims = 1;
            var typeOfEmergency = TypeOfEmergency.Fratura;

            // Act
            var medicalEvent = new MedicalEvent(
                type, address, startEventDate, endEventDate, description,
                severityLevel, status, numberOfVictims, typeOfEmergency);

            // Assert
            Assert.Equal(type, medicalEvent.Type);
            Assert.Equal(address, medicalEvent.Address);
            Assert.Equal(startEventDate, medicalEvent.StartEventDate);
            Assert.Equal(endEventDate, medicalEvent.EndEventDate);
            Assert.Equal(description, medicalEvent.Description);
            Assert.Equal(severityLevel, medicalEvent.SeverityLevel);
            Assert.Equal(status, medicalEvent.Status);
            Assert.Equal(numberOfVictims, medicalEvent.NumberOfVictims);
            Assert.Equal(typeOfEmergency, medicalEvent.TypeOfEmergency);
        }

        #endregion
    }
}
