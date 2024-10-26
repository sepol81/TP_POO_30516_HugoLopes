

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
        public Event(int id, string type ,string description, string severityLevel, string status)
        {
            Id = id;
            Type = type;

            Description = description;
            SeverityLevel = severityLevel;
            Status = status;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="newStatus">The new status.</param>
        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }

        /// <summary>
        /// Updats the severity level.
        /// </summary>
        /// <param name="newSeverityLevel">The new severity level.</param>
        public void UpdatDeverityLevel(string newSeverityLevel)
        {
            SeverityLevel = newSeverityLevel;
        }

        /// <summary>
        /// Assigns the person.
        /// </summary>
        /// <param name="person">The person.</param>
        public void AssignPerson(Person person)
        {
            AssignedPersonnel.Add(person);
        }

        /// <summary>
        /// Assignequipments the specified equipment.
        /// </summary>
        /// <param name="equipment">The equipment.</param>
        public void Assignequipment(Equipment equipment)
        {
            AssignedEquipment.Add(equipment);
        }
        #endregion
    }
}
