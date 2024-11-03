using EMS.enums;
using EMS.models.Persons;
using EMS.models.Vehicles;



namespace EMS.models.Events
{
    public class MedicalEvent : Event
    {
        public int NumberOfVictims { get; set; }
        public TypeOfEmergency TypeOfEmergency { get; set; }
        
        public MedicalEvent(int id, TypeEvent type, string address, DateTime startEventDate, DateTime endEventDate, string description, EventSeverityLevel severityLevel, StatusEvent status, int numberOfVictims,TypeOfEmergency typeOfEmergency)
            : base(id, type, address, startEventDate, endEventDate, description, severityLevel, status)
        {
            NumberOfVictims = numberOfVictims;
            TypeOfEmergency = typeOfEmergency;

        }
        public override string ToString()
        {
            return  $"Id: {Id}\n" +
                    $"Type: {Type}\n" +
                    $"Address: {Address}\n" +
                    $"Start Event Date: {StartEventDate}\n" +
                    $"End Event Date: {EndEventDate}\n" +
                    $"Description: {Description}\n" +
                    $"Severity Level: {SeverityLevel}\n" +
                    $"Status: {Status}\n" +
                    $"Number of Victimes: {NumberOfVictims}\n" +
                    $"Type of Emergency: {TypeOfEmergency}\n";
                    
                   
        }

    }
}
