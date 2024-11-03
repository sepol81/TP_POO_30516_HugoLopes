/*-----------------------------------------------------------------------------------*
 * File Name         : EquipmentManager.cs                                           *
 * Author            : Hugo Lopes                                                    *
 * Creation Date     : 26/10/2024                                                    *
 * Description       : Manages a collection of equipment used in rescue activities.  *
 *                    This class provides methods to add, remove, and list equipment.*
 *-----------------------------------------------------------------------------------*/

namespace EMS.models.Equiments
{
    /// <summary>
    /// 
    /// </summary>
    internal class EquimentsManager
    {
        #region Properties        
        /// <summary>
        /// The equipment list
        /// </summary>
        private List<Equipment> equipmentList;
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="EquimentsManager"/> class.
        /// </summary>
        public EquimentsManager()
        {
            equipmentList = new List<Equipment>();
        }
        #endregion

        #region Methods        
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
        public void ListEquipments(){}
              
        #endregion
    }
}
