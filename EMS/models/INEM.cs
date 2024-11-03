using EMS.models.Events;
using EMS.models.Persons;
using EMS.models.Vehicles;

namespace EMS.models
{
    public class INEM
    {
        #region Propreties        
        /// <summary>
        /// Gets the inem vehicles.
        /// </summary>
        /// <value>
        /// The inem vehicles.
        /// </value>
        public List<Vehicle> INEMVehicles { get; private set; }
        /// <summary>
        /// Gets the medical staff.
        /// </summary>
        /// <value>
        /// The medical staff.
        /// </value>
        public List<Person> MedicalStaff { get; private set; }
        /// <summary>
        /// Gets the active medical events.
        /// </summary>
        /// <value>
        /// The active medical events.
        /// </value>
        public List<MedicalEvent> ActiveMedicalEvents { get; private set; }
        #endregion

        #region Construtor        
        /// <summary>
        /// Initializes a new instance of the <see cref="INEM"/> class.
        /// </summary>
        public INEM()
        {
            INEMVehicles = new List<Vehicle>();
            MedicalStaff = new List<Person>();
            ActiveMedicalEvents = new List<MedicalEvent>();
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Addvehicles the specified inem vehicle.
        /// </summary>
        /// <param name="INEMVehicle">The inem vehicle.</param>
        public void Addvehicle(Vehicle INEMVehicle){}

        /// <summary>
        /// Adds the medical inem.
        /// </summary>
        /// <param name="medicalPerson">The medical person.</param>
        public void AddMedicalINEM(Person medicalPerson){}
        /// <summary>
        /// Assigns the resources to event.
        /// </summary>
        /// <param name="medicalEvent">The medical event.</param>
        public void AssignResourcesToEvent(MedicalEvent medicalEvent) {}

        #endregion
    }
}
