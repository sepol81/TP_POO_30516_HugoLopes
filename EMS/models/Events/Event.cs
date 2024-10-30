using EMS.models.Vehicles;
using EMS.models.Persons;
using EMS.models.Equiments;

namespace EMS.models.Events
{
    /// <summary>
    /// Represents an emergency event or occurrence. 
    /// </summary>
    public abstract class Event
    {
        #region Propreties
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        private int Id { get; set; }
        private string Type { get; set; }
        private DateTime StartEventDate { get; set; }
        private DateTime EndEventDate { get; set; }
        private string Description { get; set; }
        private string SeverityLevel { get; set; }
        private string Status { get; set; }
        private List<Vehicle> AssingnedVehicle { get; set; }
        private List<Person> AssignedPersonnel { get; set; }
        private List<Equipment> AssignedEquipment { get; set; }



        #endregion

        #region Constructors 
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="description">The description.</param>
        /// <param name="severityLevel">The severity level.</param>
        /// <param name="status">The status.</param>
        public Event(int id, string type, DateTime starEventDate, DateTime endEventDate, string description, string severityLevel, string status, string vehicle)
        {
            Id = id;
            Type = type;
            StartEventDate = starEventDate;
            EndEventDate = endEventDate;
            Description = description;
            SeverityLevel = severityLevel;
            Status = status;

        }
        #endregion

        #region Methods        


        #endregion
    }
}
