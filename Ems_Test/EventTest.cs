
using EMS.models.Events;
using EMS.models.Teams;
using EMS.models.Vehicles;
using EMS.enums;


namespace EMS.Tests
{
    public class EventTests
    {
        #region Constructor Tests        
        /// <summary>
        /// Constructors the should initialize properties correctly.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            var type = TypeEvent.Incêndio;
            var address = "123 Main Street";
            var startEventDate = new DateTime(2024, 12, 15, 10, 0, 0);
            var endEventDate = new DateTime(2024, 12, 15, 12, 0, 0);
            var description = "A fire broke out in a residential area.";
            var severityLevel = EventSeverityLevel.Moderada;
            var status = StatusEvent.EmEspera;

            // Act
            var eventObj = new Event(type, address, startEventDate, endEventDate, description, severityLevel, status);

            // Assert
            Assert.Equal(type, eventObj.Type); 
            Assert.Equal(address, eventObj.Address); 
            Assert.Equal(startEventDate, eventObj.StartEventDate); 
            Assert.Equal(endEventDate, eventObj.EndEventDate); 
            Assert.Equal(description, eventObj.Description); 
            Assert.Equal(severityLevel, eventObj.SeverityLevel); 
            Assert.Equal(status, eventObj.Status);
            Assert.Empty(eventObj.TeamsInvolved);
            Assert.Empty(eventObj.VehiclesInvolved); 
        }
        #endregion

        #region AddTeam Method Tests        
        /// <summary>
        /// Adds the team should add team to teams involved.
        /// </summary>
        [Fact]
        public void AddTeam_ShouldAddTeamToTeamsInvolved()
        {
            // Arrange
            var eventObj = new Event(TypeEvent.Incêndio, "Address", DateTime.Now, DateTime.Now.AddHours(1), "Description", EventSeverityLevel.Moderada, StatusEvent.EmEspera);
            var team = new Team { Name = "Rescue Team" };

            // Act
            eventObj.AddTeam(team);

            // Assert
            Assert.Single(eventObj.TeamsInvolved); 
            Assert.Contains(team, eventObj.TeamsInvolved); 
        }
        #endregion

        #region AddVehicle Method Tests       
        /// <summary>
        /// Adds the vehicle should add vehicle to vehicles involved.
        /// </summary>
        [Fact]
        public void AddVehicle_ShouldAddVehicleToVehiclesInvolved()
        {
            // Arrange
            var eventObj = new Event(TypeEvent.Incêndio, "Address", DateTime.Now, DateTime.Now.AddHours(2), "Test Event", EventSeverityLevel.Moderada, StatusEvent.EmProgresso);
            Vehicle vehicle = null; 

            // Act
            eventObj.AddVehicle(vehicle);

            // Assert
            Assert.Single(eventObj.VehiclesInvolved); 
            Assert.Contains(vehicle, eventObj.VehiclesInvolved);
        }
    }
}
        #endregion