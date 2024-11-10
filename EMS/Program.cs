/*-----------------------------------------------------------------------------------*
 * File Name        : Program.cs                                                     *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Entry point for the Emergency Management System, demonstrating *
 *                    the instantiation and usage of various classes.                *
 *-----------------------------------------------------------------------------------*/

using EMS.Data;
using EMS.enums;
using EMS.models.Equiments;
using EMS.models.Events;
using EMS.models.Persons;
using EMS.models.Vehicles;

namespace EMS 
{

    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            using (var context = new EmergenciesDBContext())
            {
                #region Create FireFighter Object
                FireFighter fireFighter = new FireFighter
                (
                    
                    Name: "João",
                    CitCard: "3456789",
                    Profession: Profession.Bombeiro,
                    Status: StatusPerson.EmServiço,
                    Birthday: new DateOnly(1975, 7, 21),
                    Email: "fffff@123.com",
                    Phone: "945556954",
                    Address: "Barcelos",
                    Rank: RankFireFighter.Comandante,
                    YearsOfExp: 2,
                    Certifications: new List<string> { "Certificação de Resgate", "Primeiros Socorros" },
                    Skills: new List<string> { "Combate a Incêndios", "Salvamento em Altura" }
                );
                context.FireFighters.Add(fireFighter);
                #endregion

                #region Create Doctor Object
                Doctor doctor = new Doctor
                (
                    
                    Name: "António",
                    CitCard: "865987",
                    Profession: Profession.Medico,
                    Status: StatusPerson.Disponivel,
                    Birthday: new DateOnly(1981, 7, 23),
                    Email: "ddddd@123.com",
                    Phone: "95896625",
                    Address: "Porto",
                    CardNumber: "123015622",
                    Specialty: "Emergências"
                );
                context.Doctors.Add(doctor);
                #endregion

                #region Create Nurse Object
                Nurse nurse = new Nurse
                (
                    
                    Name: "Maria",
                    CitCard: "1258995",
                    Profession: Profession.Enfermeiro,
                    Birthday: new DateOnly(1994, 7, 23),
                    Status: StatusPerson.EmDescanso,
                    Email: "nnnnn@123.com",
                    Phone: "023654985",
                    Address: "Lisboa",
                    CardNumber: "123456789",
                    AreaOfActivity: "pediatria"
                );
                context.Nurses.Add(nurse);
                #endregion

                #region Create Paramedic Object
                Paramedic paramedic = new Paramedic
                (
                    
                    Name: "Silva",
                    CitCard: "1285545",
                    Profession: Profession.Paramédico,
                    Birthday: new DateOnly(1993, 7, 23),
                    Status: StatusPerson.Disponivel,
                    Email: "pppp@123.com",
                    Phone: "023654985",
                    Address: "Évora",
                    TechnicalNumber: "1236958"
                );
                context.Paramedics.Add(paramedic);
                #endregion

                #region Create FireTruck Object
                FireTruck fireTruck = new FireTruck
                (
                    CarRegist: "26-WE-34",
                    YearOfRegist: new DateOnly(1970, 6, 26),
                    Type: TypeVehicle.FireTruck,
                    Brand: "Mercedes",
                    InspDate: new DateOnly(2024, 12, 30),
                    Status: StatusVehicle.EmManutenção,
                    WaterTankCapacity: 3000,
                    CrewCapacity: 8
                );
                context.FireTrucks.Add(fireTruck);
                #endregion

                #region Create Ambulance Object
                Ambulance ambulance = new Ambulance
                (
                    CarRegist: "29-PO-33",
                    YearOfRegist: new DateOnly(1980, 6, 26),
                    Type: TypeVehicle.Ambulence,
                    Brand: "Renault",
                    InspDate: new DateOnly(2024, 12, 30),
                    Status: StatusVehicle.EmServiço,
                    CrewCapacity: 4
                );
                context.Ambulances.Add(ambulance);
                #endregion

                #region Create MedicalEvent Object
                MedicalEvent medicalEvent = new MedicalEvent
                (
                  
                    type: TypeEvent.Medical,
                    address: "rua das Canas nº25, Porto",
                    startEventDate: new DateTime(2024, 12, 5, 15, 15, 00),
                    endEventDate: new DateTime(2024, 12, 5, 20, 30, 00),
                    description: "Acidente entre duas viaturas",
                    severityLevel: EventSeverityLevel.Séria,
                    status: StatusEvent.EmProgresso,
                    numberOfVictims: 3,
                    typeOfEmergency: TypeOfEmergency.Choque
                );
                context.Medical_Events.Add(medicalEvent);
                #endregion

                #region Create Equipment Object
                Equipment equipment = new Equipment
                (
                    
                    name: "Oxigénio",
                    description: "botija de 30l",
                    quantity: 5,
                    maintenanceDate: new DateOnly(2024, 05, 25),
                    status: StatusEquipment.Disponivel
                );
                context.Equipments.Add(equipment);
                #endregion

                // Salvar todas as alterações na base de dados
                context.SaveChanges();

                Console.WriteLine("Objetos salvos na base de dados com sucesso.");
            }
        }
    }
}