
using EMS.enums;
namespace EMS.models.Vehicles
{
    public class MotorBike : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MotorBike"/> class.
        /// </summary>
        /// <param name="carRegist"></param>
        /// <param name="type"></param>
        /// <param name="brand"></param>
        /// <param name="inspDate"></param>
        /// <param name="status"></param>
        public MotorBike(string CarRegist, DateOnly YearOfRegist, int Age, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status)
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
