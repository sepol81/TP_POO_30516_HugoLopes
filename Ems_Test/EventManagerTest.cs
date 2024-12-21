using EMS.Data;
using EMS.enums;
using EMS.models.Events;
using EMS.services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace EMS_Test
{
    public class EventManagerTest
    {
        private readonly EMS_DBContext _dbContext;
        private readonly EventsManager _eventsManager;

        public EventManagerTest()
        {
           
            var options = new DbContextOptionsBuilder<EMS_DBContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase") 
                .Options;

            _dbContext = new EMS_DBContext(options);
            _eventsManager = new EventsManager(_dbContext);
        }

        [Fact]
        public void AddEvent_ShouldAddEventToDatabase()
        {
            var newEvent = new Event(
                TypeEvent.Medical,
                "Teste Morada",
                DateTime.Now,
                DateTime.Now.AddHours(1),
                "Teste Descrição",
                EventSeverityLevel.Moderada,
                StatusEvent.EmProgresso
            );

            _eventsManager.AddEvent(newEvent);

            var addedEvent = _dbContext.Event.FirstOrDefault(e => e.Description == "Teste Descrição");
            Assert.NotNull(addedEvent);
        }

        [Fact]
        public void RemoveEvent_ShouldRemoveEventFromDatabase()
        {
            var existingEvent = new Event(
                TypeEvent.Medical,
                "Teste Morada",
                DateTime.Now,
                DateTime.Now.AddHours(1),
                "Teste Descrição",
                EventSeverityLevel.Moderada,
                StatusEvent.EmProgresso
            );

            _dbContext.Event.Add(existingEvent);
            _dbContext.SaveChanges();

            _eventsManager.RemoveEvent(existingEvent.Id);

            var removedEvent = _dbContext.Event.FirstOrDefault(e => e.Id == existingEvent.Id);
            Assert.Null(removedEvent);
        }

        [Fact]
        public void GetAllEvents_ShouldReturnAllEvents()
        {
            var events = new[]
            {
                new Event(
                    TypeEvent.Medical,
                    "Teste Morada 1",
                    DateTime.Now,
                    DateTime.Now.AddHours(1),
                    "Teste Descrição 1",
                    EventSeverityLevel.Moderada,
                    StatusEvent.EmProgresso
                ),
                new Event(
                    TypeEvent.Medical,
                    "Teste Morada 2",
                    DateTime.Now,
                    DateTime.Now.AddHours(1),
                    "Teste Descrição 2",
                    EventSeverityLevel.Moderada,
                    StatusEvent.Concluído
                )
            };

            _dbContext.Event.AddRange(events);
            _dbContext.SaveChanges();

            var allEvents = _eventsManager.GetAllEvents();
            Assert.Equal(2, allEvents.Count());
        }

        [Fact]
        public void GetEventById_ShouldReturnCorrectEvent()
        {
            var existingEvent = new Event(
                TypeEvent.Medical,
                "Teste Morada",
                DateTime.Now,
                DateTime.Now.AddHours(1),
                "Teste Descrição",
                EventSeverityLevel.Moderada,
                StatusEvent.EmProgresso
            );

            _dbContext.Event.Add(existingEvent);
            _dbContext.SaveChanges();

            var result = _eventsManager.GetEventById(existingEvent.Id);

            Assert.Equal(existingEvent.Id, result.Id);
        }
    }
}
