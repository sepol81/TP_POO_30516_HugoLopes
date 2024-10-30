

namespace EMS.models
{
    #region Propreties    
    /// <summary>
    /// Represents an equipment item used in rescue activities. 
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Status { get; set; }



        #endregion
        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="Equipment"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="quantity">The quantity.</param>
        /// <param name="maintenanceDate">The maintenance date.</param>
        /// <param name="status">The status.</param>
        public Equipment(int id, string name, string description, int quantity, DateTime maintenanceDate, string status)
        {
            Id = id;
            Name = name;
            Description = description;
            Quantity = quantity;
            MaintenanceDate = maintenanceDate;
            Status = status;

        }

        #endregion

    }
}
