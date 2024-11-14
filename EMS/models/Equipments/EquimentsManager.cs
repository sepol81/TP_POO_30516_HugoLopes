/*-----------------------------------------------------------------------------------*
 * File Name         : EquipmentManager.cs                                           *
 * Author            : Hugo Lopes                                                    *
 * Creation Date     : 26/10/2024                                                    *
 * Description       : Manages a collection of equipment used in rescue activities.  *
 *                    This class provides methods to add, remove, and list equipment.*
 *-----------------------------------------------------------------------------------*/
using EMS.models.Vehicles;
using EMS.models.Equiments;

namespace EMS.models.Equiments
{
    /// <summary>
    /// Manages equipment and vehicles within the emergency management system.
    /// </summary>
    public class EquimentsManager 
    {
        #region Properties                
        
        private List<Equipment> equipmentList;
        private List<Vehicle> vehicles ;
        #endregion

        #region Constructor                
        /// <summary>
        /// Initializes a new instance of the <see cref="EquimentsManager"/> class.
        /// </summary>
        public EquimentsManager()
        {
            equipmentList = new List<Equipment>();
            vehicles = new List<Vehicle>();
        }

      
        #endregion

        #region Methods         
        /// <summary>
        /// Adds the equipment to vehicle.
        /// </summary>
        /// <param name="vehicleCarRegist">The vehicle car regist.</param>
        /// <param name="equipment">The equipment.</param>
        public void AddEquipmentToVehicle(string vehicleCarRegist, Equipment equipment){}
        /// <summary>
        /// Adds the equipment.
        /// </summary>
        /// <param name="equipment">The equipment.</param>
        public void AddEquipment(Equipment equipment){}
        /// <summary>
        /// Removes the equipment.
        /// </summary>
        /// <param name="equipment">The equipment.</param>
        public void RemoveEquipment(Equipment equipment){}
        /// <summary>
        /// Lists the equipments.
        /// </summary>
        public void ListEquipmentsForVehicle(string vehicleCarRegist){}

        #endregion
    }
}
