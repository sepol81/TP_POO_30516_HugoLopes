using EMS.enums;

namespace EMS.models.Events
{
       
        public class FireEvent : Event
        {
            public TypeOfFire TypeOfFire { get; set; }
            public string FireIntensity { get; set; }
            public double AffectedArea { get; set; }

            public FireEvent(int id, TypeEvent type, string address, DateTime startEventDate, DateTime endEventDate, string description, EventSeverityLevel severityLevel, StatusEvent status,TypeOfFire typeOfFire, string fireIntensity, double affectedArea)
            : base(id, type,address, startEventDate, endEventDate, description, severityLevel, status)
            {
                {
                    TypeOfFire = typeOfFire;
                    FireIntensity = fireIntensity;
                    AffectedArea = affectedArea;
                }
            }
            public override string ToString()
            {
            return $"Id: {Id}\n" +
                $"Type: {Type}\n" +
                $"Address: {Address}\n" +
                $"Start Event Date: {StartEventDate}\n" +
                $"End Event Date: {EndEventDate}\n" +
                $"Description: {Description}\n" +
                $"Severity Level: {SeverityLevel}\n" +
                $"Status: {Status}\n" +
                $"Type Of Fire: {TypeOfFire}\n" +
                $"Fire Intensity: {FireIntensity}\n" +
                $"Affected Area: {AffectedArea}\n";
        }
        }
}
