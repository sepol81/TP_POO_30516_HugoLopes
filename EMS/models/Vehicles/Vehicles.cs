using EMS.enums;
using Utils;

namespace EMS.models.Vehicles
{
    public abstract class Vehicle
    {
        /// <summary>
        /// The age calculator
        /// </summary>
        private readonly CalAge.Date ageCalculator = new CalAge.Date();
        #region Private Properties        
        /// <summary>
        /// Gets or sets the car regist.
        /// </summary>
        /// <value>
        /// The car regist.
        /// </value>
        private string carRegist { get; set; }
        private DateOnly yearOfRegist { get; set; }
        private TypeVehicle type { get; set; }
        private string brand { get; set; }
        private DateOnly inspDate { get; set; }
        private StatusVehicle status { get; set; }
        #endregion

        #region Public Properties        
        /// <summary>
        /// Gets or sets the car regist.
        /// </summary>
        /// <value>
        /// The car regist.
        /// </value>
        public string CarRegist
        {
            get => carRegist;
            set => carRegist = value;
        }
        public DateOnly YearOfRegist
        {
            get => yearOfRegist;
            set => yearOfRegist = value;
        }
        public int Age => ageCalculator.Age(YearOfRegist);
        public TypeVehicle Type
        {
            get => type;
            set => type = value;
        }
        public string Brand
        {
            get => brand;
            set => brand = value;
        }
        public DateOnly InspDate
        {
            get => inspDate;
            set => inspDate = value;
        }
        public StatusVehicle Status
        {
            get => status;
            set => status = value;
        }
        #endregion

        #region Constructors               
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="CarRegist">The car regist.</param>
        /// <param name="Type">The type.</param>
        /// <param name="Brand">The brand.</param>
        /// <param name="InspDate">The insp date.</param>
        /// <param name="Status">The status.</param>
        public Vehicle(string carRegist,DateOnly yearOfRegist,int Age, TypeVehicle type, string brand, DateOnly inspDate, StatusVehicle status)
        {
            CarRegist = carRegist;
            YearOfRegist=yearOfRegist;
            Age = Age;
            Type = type;
            Brand = brand;
            InspDate = inspDate;
            Status = status;
        }
        #endregion

        #region Abstract Method        
        /// <summary>
        /// Types the vehicles.
        /// </summary>
        /// <returns></returns>
        public abstract string TypeVehicles();
        #endregion
    }
}
