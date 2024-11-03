﻿/*-----------------------------------------------------------------------------------*
 * File Name        : MotorBike.cs                                                  *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Represents a motorbike in the system, including properties     *
 *                    for engine capacity, siren availability, and first aid kit.    *
 *-----------------------------------------------------------------------------------*/

using EMS.enums;

namespace EMS.models.Vehicles
{
    /// <summary>
    /// Represents an motorbike in the system.
    /// </summary>
    /// <seealso cref="EMS.models.Vehicles.Vehicle" />
    public class MotorBike : Vehicle
    {
        #region Properties
        public int EngineCapacity { get; set; } 
        public bool HasSiren { get; set; } 
        public bool HasFirstAidKit { get; set; }
        #endregion

        #region Construters
        /// <summary>
        /// Initializes a new instance of the <see cref="MotorBike"/> class.
        /// </summary>
        /// <param name="CarRegist">The car regist.</param>
        /// <param name="YearOfRegist"></param>
        /// <param name="Age"></param>
        /// <param name="Type">The type.</param>
        /// <param name="Brand">The brand.</param>
        /// <param name="InspDate">The insp date.</param>
        /// <param name="Status">The status.</param>
        public MotorBike(string CarRegist, DateOnly YearOfRegist, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status)
           : base(CarRegist, YearOfRegist, Type, Brand, InspDate, Status)
        {
            

        }
        #endregion

        #region Methods
        /// <summary>
        /// Types the vehicles.
        /// </summary>
        /// <returns>A string containing the motorcicle's details.</returns>
        public override string TypeVehicles()
        {
            return $"Motorcicle register:{CarRegist}\n" +
                    $"Year Of Registration:{YearOfRegist}  \n" +
                    $"Age: {Age}\n" +
                    $"Type:{Type}\n" +
                    $"Brand: {Brand}\n" +
                    $"Inspetion Date:{InspDate}\n" +
                    $"Status{Status}\n ";  
        }
        #endregion
    }
}
