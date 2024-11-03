

namespace EMS.models.Vehicles
{
    internal class VehiclesManager
    {
        /// <summary>
        /// The vehicles
        /// </summary>
        private List<Vehicle> vehicles;
        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclesManager"/> class.
        /// </summary>
        public VehiclesManager()
        {
            vehicles = new List<Vehicle>();
        }

        /// <summary>
        /// Adds the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public void AddVehicle(Vehicle vehicle) { }
        /// <summary>
        /// Removes the vehicle.
        /// </summary>
        /// <param name="carRegist">The car regist.</param>
        public void RemoveVehicle(string carRegist) { }
        /// <summary>
        /// Updates the vehicle.
        /// </summary>
        /// <param name="updatedVehicle">The updated vehicle.</param>
        public void UpdateVehicle(Vehicle updatedVehicle) { }
    }
}
