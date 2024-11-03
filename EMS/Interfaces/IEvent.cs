/*-----------------------------------------------------------------------------------*
 * File Name         : IEvent.cs                                                     *
 * Author            : Hugo Lopes                                                    *
 * Creation Date     : 26/10/2024                                                    *
 * Description       : Interface for managing emergency events, allowing assignment  *
 *                    of vehicles and persons to events.                             *
 *-----------------------------------------------------------------------------------*/

using EMS.models.Persons;
using EMS.models.Vehicles;


namespace EMS.interfaces
{
    /// <summary>
    /// Interface to manage emergency events.
    /// </summary>
    public interface IEvent
    {
        void AssignedVehicles(Vehicle vehicle);
        void AssignedPersons(Person person);


    }
}
