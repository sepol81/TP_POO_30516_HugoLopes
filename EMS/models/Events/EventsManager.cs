/*------------------------------------------------------------------------------------*
 * File Name         : EventsManager.cs                                               *
 * Author            : Hugo Lopes                                                     *
 * Creation Date     : 26/10/2024                                                     *
 * Description       : Manages emergency events by providing methods to add, remove,  *
 *                    and update events in the system. This class maintains a list of *
 *                    events and handles their lifecycle.                             *
 *------------------------------------------------------------------------------------*/

namespace EMS.models.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class EventsManager
    {
        #region Properties
        /// <summary>
        /// The events
        /// </summary>
        private List<Event> events;
        #endregion

        #region Construters
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsManager"/> class.
        /// </summary>
        public EventsManager()
        {
            events = new List<Event>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the event.
        /// </summary>
        /// <param name="Event">The event.</param>
        public void AddEvent(Event Event){}
        /// <summary>
        /// Removes the event.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void RemoveEvent(int id){}
        /// <summary>
        /// Updates the event.
        /// </summary>
        /// <param name="updatedEvent">The updated event.</param>
        public void UpdateEvent(Event updatedEvent){}
        #endregion
    }
}
