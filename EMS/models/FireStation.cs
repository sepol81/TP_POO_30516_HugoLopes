﻿/*-----------------------------------------------------------------------------------*
 * File Name        : FireStation.cs                                                 *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Defines the FireStation class, representing a fire station in  *
 *                    the Emergency Management System, managing persons,vehicles,    *
 *                    and equipment.                                                 *
 *-----------------------------------------------------------------------------------*/

using EMS.models.Persons;
using EMS.models.Vehicles;
using EMS.models.Equiments;
using EMS.models.Events;

namespace EMS.models
{
    /// <summary>
    /// 
    /// </summary>
    public class FireStation
    {
        #region Propreties        
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Location { get; set; } 
        public List<FireFighter> FireFighters { get; private set; }
        public List<Doctor> Doctors { get; private set; }
        public List<Nurse> Nurses { get; private set; }
        public List<Vehicle> FireTrucks { get; private set; } 
        public List<Equipment> Equipment { get; private set; }
        #endregion

        #region Construters        
        /// <summary>
        /// Initializes a new instance of the <see cref="FireStation"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="location">The location.</param>
        public FireStation(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
            FireFighters = new List<FireFighter>();
            Doctors = new List<Doctor>();
            Nurses = new List<Nurse>();
            FireTrucks = new List<Vehicle>();
            Equipment = new List<Equipment>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the fire fighter.
        /// </summary>
        /// <param name="fireFighter">The fire fighter.</param>
        public void AddFireFighter(FireFighter fireFighter){}

        /// <summary>
        /// Adds the doctor.
        /// </summary>
        /// <param name="doctor">The doctor.</param>
        public void AddDoctor(Doctor doctor){}

        /// <summary>
        /// Adds the nurse.
        /// </summary>
        /// <param name="nurse">The nurse.</param>
        public void AddNurse(Nurse nurse){}

        /// <summary>
        /// Adds the fire truck.
        /// </summary>
        /// <param name="fireTruck">The fire truck.</param>
        public void AddFireTruck(Vehicle fireTruck){}

        /// <summary>
        /// Adds the equipment.
        /// </summary>
        /// <param name="equipment">The equipment.</param>
        public void AddEquipment(Equipment equipment){}

        /// <summary>
        /// Responds to emergency.
        /// </summary>
        /// <param name="fireEvent">The fire event.</param>
        public void RespondToEmergency(FireEvent fireEvent){}
        #endregion
    }
}