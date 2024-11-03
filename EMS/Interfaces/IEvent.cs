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
