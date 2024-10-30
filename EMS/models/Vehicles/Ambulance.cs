using EMS.enums;


namespace EMS.models.Vehicles
{
    /// <summary>
    /// Represents an ambulance in the system. 
    /// </summary>
    /// <seealso cref="EMS.models.Vehicles.Vehicle" />
    public class Ambulance : Vehicle
        {
        #region Properties

        #endregion
        
        #region Construters
        /// <summary>
        /// Initializes a new instance of the <see cref="Ambulance"/> class.
        /// </summary>
        /// <param name="CarRegist">The car regist.</param>
        /// <param name="YearOfRegist"></param>
        /// <param name="Age"></param>
        /// <param name="Type">The type.</param>
        /// <param name="Brand">The brand.</param>
        /// <param name="InspDate">The insp date.</param>
        /// <param name="Status">The status.</param>
        public Ambulance(string CarRegist, DateOnly YearOfRegist, int Age, TypeVehicle Type, string Brand, DateOnly InspDate, StatusVehicle Status)
           : base(CarRegist, YearOfRegist, Age, Type, Brand, InspDate, Status)
        {
            

        }

        #endregion

        #region Metodhs

        /// <summary>
        /// Types the vehicles.
        /// </summary>
        /// <returns>A string containing the ambulance's details.</returns>
        public override string TypeVehicles()
        {
            return  $"Vehicle register:{CarRegist}\n" +
                    $"Year Of Registration:{YearOfRegist}\n" +
                    $"Age: {Age} \n" +
                    $"Type:{Type} \n" +
                    $"Brand: {Brand} \n" +
                    $"Inspetion Date: {InspDate} \n" +
                    $"Status: {Status} \n";

        }
        #endregion
    }
}
