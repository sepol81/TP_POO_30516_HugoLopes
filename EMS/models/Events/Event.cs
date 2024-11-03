/*-----------------------------------------------------------------------------------*
 * File Name         : Event.cs                                                      *
 * Author            : Hugo Lopes                                                    *
 * Creation Date     : 26/10/2024                                                    *
 * Description       : Defines the Event class, representing an emergency event      *
 *                    or occurrence in the Emergency Management System. This class   *
 *                    maintains details such as the event's identifier, type,        *
 *                    address, dates, description, severity level, and status. It    *
 *                    also manages assigned vehicles and persons involved in the     *
 *                    event.                                                         *
 *-----------------------------------------------------------------------------------*/

using EMS.models.Vehicles;
using EMS.models.Persons;
using EMS.interfaces;
using EMS.enums;

namespace EMS.models.Events
{
    /// <summary>
    ///  Represents an emergency event or occurrence.
    /// </summary>
    /// <seealso cref="EMS.interfaces.IEvent" />
    public class Event : IEvent
    {
        #region Propreties       
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; private set; }
        public TypeEvent Type { get; set; }
        public string Address { get; set; }
        public DateTime StartEventDate { get; set; }
        public DateTime EndEventDate { get; set; }
        public string Description { get; set; }
        public EventSeverityLevel SeverityLevel { get; set; }
        public StatusEvent Status { get; set; }
        public List<Vehicle> AssignedVehicles { get; set; }
        public List<Person> AssignedPersons { get; set; }

        #endregion

        #region Constructors         
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="starEventDate">The star event date.</param>
        /// <param name="endEventDate">The end event date.</param>
        /// <param name="description">The description.</param>
        /// <param name="severityLevel">The severity level.</param>
        /// <param name="status">The status.</param>
        public Event(int id, TypeEvent type, string address, DateTime starEventDate, DateTime endEventDate, string description, EventSeverityLevel severityLevel, StatusEvent status)
        {
            Id = id;
            Type = type;
            Address = address;
            StartEventDate = starEventDate;
            EndEventDate = endEventDate;
            Description = description;
            SeverityLevel = severityLevel;
            Status = status;
            AssignedPersons = new List<Person>();
            AssignedVehicles = new List<Vehicle>();
        }
        #endregion

        #region Methods         
        /// <summary>
        /// Assigneds the persons.
        /// </summary>
        /// <param name="person">The person.</param>
        void IEvent.AssignedPersons(Person person)
        {
            if (!AssignedPersons.Contains(person))
            {
                AssignedPersons.Add(person);
            }
        }
        /// <summary>
        /// Assigneds the vehicles.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        void IEvent.AssignedVehicles(Vehicle vehicle)
        {
            if (AssignedVehicles.Contains(vehicle))
            {
                AssignedVehicles.Add(vehicle);
            }

        }
        

        #endregion
    }
}
