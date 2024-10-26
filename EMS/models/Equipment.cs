using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.models
{
    #region Propreties
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime MaintenanceDate { get;set;}
        public string Status { get; set; }

               
    
    #endregion
    #region Constructors

        public Equipment (int id, string name, string description, int quantity, DateTime maintenanceDate, string status) 
        {
            Id = id;
            Name = name;
            Description = description;
            Quantity = quantity;
            MaintenanceDate = maintenanceDate;
            Status = status;

        }

        #endregion
        #region Methods        
        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="newStatus">The new status.</param>
        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }

        /// <summary>
        /// Needses the maintenance.
        /// </summary>
        /// <returns></returns>
        public bool NeedsMaintenance()
        {
            return (DateTime.Now - MaintenanceDate).Days > 180;// maintenance every 6 months
        }

        #endregion
    }
}
