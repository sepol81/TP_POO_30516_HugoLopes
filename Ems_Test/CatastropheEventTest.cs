using EMS.enums;
using EMS.models.Events;

namespace EMS.Tests
{
    public class CatastropheEventTests
    {
        #region Constructor Tests                
        /// <summary>
        /// Constructors the should initialize properties correctly.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            var type = TypeEvent.Catástrofe;
            var address = "35 rua da Liberdade";
            var startEventDate = new DateTime(2024, 12, 15, 10, 0, 0);
            var endEventDate = new DateTime(2024, 12, 15, 12, 0, 0);
            var description = "as chuvas fortes causaram uma derrocada.";
            var severityLevel = EventSeverityLevel.Leve;
            var status = StatusEvent.EmProgresso;
            var affectedArea = 1;
            var typeCat = TypeOfCatastrophe.Ciclones; 
            var numberOfVictims = 2; 

            // Act
            var catastropheEvent = new CatastropheEvent(
                type, address, startEventDate, endEventDate, description,
                severityLevel, status, affectedArea, typeCat, numberOfVictims);

            // Assert
            Assert.Equal(type, catastropheEvent.Type);
            Assert.Equal(address, catastropheEvent.Address);
            Assert.Equal(startEventDate, catastropheEvent.StartEventDate);
            Assert.Equal(endEventDate, catastropheEvent.EndEventDate);
            Assert.Equal(description, catastropheEvent.Description);
            Assert.Equal(severityLevel, catastropheEvent.SeverityLevel);
            Assert.Equal(status, catastropheEvent.Status);
            Assert.Equal(affectedArea, catastropheEvent.AffectedArea);
            Assert.Equal(typeCat, catastropheEvent.TypeCat);
            Assert.Equal(numberOfVictims, catastropheEvent.NumberOfVictims);
        }
    }
}
        #endregion
