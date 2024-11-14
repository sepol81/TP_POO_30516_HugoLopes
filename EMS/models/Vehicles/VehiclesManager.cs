/*-----------------------------------------------------------------------------------*
 * File Name        : VehiclesManager.cs                                             *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Class for managing vehicles in the Emergency Management System.*
 *-----------------------------------------------------------------------------------*/

namespace EMS.models.Vehicles
{
    /// <summary>
    /// Manages a collection of vehicles
    /// </summary>
    public class VehiclesManager
    {
        #region Properties
        
        private List<Vehicle> vehicles;
        #endregion

        #region Construters
        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclesManager"/> class.
        /// </summary>
        public VehiclesManager()
        {
            vehicles = new List<Vehicle>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public void AddVehicle(Vehicle vehicle){}
        /// <summary>
        /// Removes the vehicle.
        /// </summary>
        /// <param name="carRegist">The car regist.</param>
        public void RemoveVehicle(string carRegist){}
        /// <summary>
        /// Updates the vehicle.
        /// </summary>
        /// <param name="updatedVehicle">The updated vehicle.</param>
        public void UpdateVehicle(Vehicle updatedVehicle){}

        #endregion
    }
}
