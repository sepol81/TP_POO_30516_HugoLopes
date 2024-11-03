using EMS.enums;


namespace EMS.models.Vehicles
{
    /// <summary>
    /// Represents an helicopeter in the system.
    /// </summary>
    /// <seealso cref="EMS.models.Vehicles.Vehicle" />
    public class Helicopter : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Helicopter"/> class.
        /// </summary>
        /// <param name="CarRegist">The car regist.</param>
        /// <param name="YearOfRegist"></param>
        /// <param name="Age"></param>
        /// <param name="Type">The type.</param>
        /// <param name="Brand">The brand.</param>
        /// <param name="InspDate">The insp date.</param>
        /// <param name="Status">The status.</param>
        public Helicopter(string CarRegist, DateOnly YearOfRegist, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status)
           : base(CarRegist, YearOfRegist, Type, Brand, InspDate, Status)
        {
            

        }
        /// <summary>
        /// Types the vehicles.
        /// </summary>
        /// <returns>A string containing the helicopter's details.</returns>
        public override string TypeVehicles()
        {
            return  $"Helicopter-register:{CarRegist}" +
                    $"Year Of Registration:{YearOfRegist}" +
                    $"Age: {Age}" +
                    $"Type:{Type}" +
                    $"Brand: {Brand}" +
                    $"Inspetion Date:{InspDate}" +
                    $"Status{Status}";
        }
    }
}
