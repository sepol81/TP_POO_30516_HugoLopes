

using EMS.models.Persons;

namespace EMS.models
{
    /// <summary>
    /// Represents an emergency event or occurrence. 
    /// </summary>
    public class Event
    {
        #region Propreties
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        public string Type { get; set; } 
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        public string SeverityLevel {  get; set; }  
        public string Status { get; set; }
        public string Vehicle {  get; set; }
        public List<Person> AssignedPersonnel { get; set; }
        public List<Equipment> AssignedEquipment { get; set; }
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
        public Event(int id, string type ,string description, string severityLevel, string status,string vehicle)
        {
            Id = id;
            Type = type;

            Description = description;
            SeverityLevel = severityLevel;
            Status = status;
            Vehicle = vehicle;
        }
        #endregion

        #region Methods        
       
        #endregion
    }
}
