using EMS.models.Persons;


namespace EMS.models.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class EventsManager
    {
        /// <summary>
        /// The events
        /// </summary>
        private List<Event> events;
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsManager"/> class.
        /// </summary>
        public EventsManager()
        {
            events = new List<Event>();
        }
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
    }
}
