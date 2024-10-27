namespace EMS.models.Vehicles
{
    public abstract class Vehicle
    {
        #region Private Properties        
        /// <summary>
        /// Gets or sets the car regist.
        /// </summary>
        /// <value>
        /// The car regist.
        /// </value>
        private string carRegist { get; set; }
        private string type { get; set; }
        private string brand { get; set; }
        private DateTime inspDate { get; set; }
        private string status { get; set; }
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
        public string Type
        {
            get => type;
            set => type = value;
        }
        public string Brand
        {
            get => brand;
            set => brand = value;
        }
        public DateTime InspDate
        {
            get => inspDate;
            set => inspDate = value;
        }
        public string Status
        {
            get => status;
            set => status = value;
        }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicles"/> class.
        /// </summary>
        /// <param name="carRegist">The car regist.</param>
        /// <param name="type">The type.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="inspDate">The insp date.</param>
        /// <param name="status">The status.</param>
        public Vehicle(string carRegist, string type, string brand, DateTime inspDate, string status)
        {
            this.carRegist = carRegist;
            this.type = type;
            this.brand = brand;
            this.inspDate = inspDate;
            this.status = status;
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
