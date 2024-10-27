namespace EMS.models.Vehicles
{
    public class FireTruck : Vehicle
    {
        public int WaterTankCapacity { get; set; }

        public FireTruck(string carRegist, string type, string brand, DateTime inspDate, string status, int waterTankCapacity)
           : base(carRegist, type, brand, inspDate, status)
        {
            WaterTankCapacity = waterTankCapacity;

        }
        public override string TypeVehicles()
        {
            return $"FireTruck\n" +
                    $"Car-register:{CarRegist}" +
                    $"Type:{Type}" +
                    $"Brand: {Brand}" +
                    $"Inspetion Date:{InspDate}" +
                    $"Status{Status}" +
                    $"Water Thank Capacity:{WaterTankCapacity}";
        }
    }
}
