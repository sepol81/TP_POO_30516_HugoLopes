using EMS.enums;


namespace EMS.models.Vehicles
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="EMS.models.Vehicles.Vehicle" />
    public class Ambulance : Vehicle

    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ambulance"/> class.
        /// </summary>
        /// <param name="carRegist"></param>
        /// <param name="type"></param>
        /// <param name="brand"></param>
        /// <param name="inspDate"></param>
        /// <param name="status"></param>
        public Ambulance(string CarRegist, DateOnly YearOfRegist, int Age, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status)
           : base(CarRegist, YearOfRegist, Age, Type, Brand, InspDate, Status)
        {
            

        }
        /// <summary>
        /// Types the vehicles.
        /// </summary>
        /// <returns></returns>
        public override string TypeVehicles()
        {
            return $"Car-register:{CarRegist}" +
                    $"Year Of Registration:{YearOfRegist}" +
                    $"Age: {Age}" +
                    $"Type:{Type}" +
                    $"Brand: {Brand}" +
                    $"Inspetion Date:{InspDate}" +
                    $"Status{Status}";

        }

    }
}
