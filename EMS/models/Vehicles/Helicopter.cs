using EMS.enums;


namespace EMS.models.Vehicles
{
    public class Helicopter : Vehicle
    {
        public Helicopter(string CarRegist, DateOnly YearOfRegist, int Age, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status)
           : base(CarRegist, YearOfRegist, Age, Type, Brand, InspDate, Status)
        {
            

        }
        public override string TypeVehicles()
        {
            return  $"Car-register:{CarRegist}" +
                    $"Year Of Registration:{YearOfRegist}" +
                    $"Age: {Age}" +
                    $"Type:{Type}" +
                    $"Brand: {Brand}" +
                    $"Inspetion Date:{InspDate}" +
                    $"Status{Status}";
        }
    }
}
