using EMS.enums;

namespace EMS.models.Vehicles
{
    public class FireTruck : Vehicle
    {
        /// <summary>
        /// Gets or sets the water tank capacity.
        /// </summary>
        /// <value>
        /// The water tank capacity.
        /// </value>
        public int WaterTankCapacity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FireTruck"/> class.
        /// </summary>
        /// <param name="carRegist">The car regist.</param>
        /// <param name="type">The type.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="inspDate">The insp date.</param>
        /// <param name="status">The status.</param>
        /// <param name="waterTankCapacity">The water tank capacity.</param>
        public FireTruck(string CarRegist, DateOnly YearOfRegist, int Age, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status, int WaterTankCapacity)
           : base(CarRegist, YearOfRegist, Age, Type, Brand, InspDate, Status)
        {
            WaterTankCapacity = WaterTankCapacity;

        }
        /// <summary>
        /// Types the vehicles.
        /// </summary>
        /// <returns></returns>
        public override string TypeVehicles()
        {
            return $"Car-register:{CarRegist}\n" +
                    $"Year Of Registration:{YearOfRegist}\n" +
                    $"Age: {Age}\n" +
                    $"Type:{Type} \n" +
                    $"Brand: {Brand} \n" +
                    $"Inspetion Date:{InspDate} \n" +
                    $"Status{Status} \n"+
                    $"Water Thank Capacity:{WaterTankCapacity} \n";
        }
    }
}
