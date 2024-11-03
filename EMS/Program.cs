/*-----------------------------------------------------------------------------------*
 * File Name        : Program.cs                                                     *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Entry point for the Emergency Management System, demonstrating *
 *                    the instantiation and usage of various classes.                *
 *-----------------------------------------------------------------------------------*/

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
            #region Create FireFighter Object
            FireFighter fireFighter = new FireFighter
            (
                Id: 1,
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

            Console.WriteLine(fireFighter.TypePerson());
            #endregion

            #region Create Doctor Object
            Doctor doctor = new Doctor
            (
                Id: 1,
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

            Console.WriteLine(doctor.TypePerson());
            #endregion

            #region Create Nurse Object
            Nurse nurse = new Nurse
           (
               Id: 1,
               Name: "Maria",
               CitCard: "1258995",
               Profession: Profession.Enfermeiro,
               Birthday: new DateOnly(1994, 7, 23),
               Status: StatusPerson.EmDescanso,
               Email: "nnnnn@123.com",
               Phone: "023654985",
               Address: "Lisboa",
               CardNumber: "123456789",
               AreOfActivity: "pediatria"

           );

            Console.WriteLine(nurse.TypePerson());
            #endregion

            #region Create Paramedic Object
            Paramedic paramedic = new Paramedic
           (
               Id: 1,
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

            Console.WriteLine(paramedic.TypePerson());
            #endregion

            #region Create FireTruck Object
            FireTruck fireTruck = new FireTruck
                (
                    CarRegist: "23-WE-34",
                    YearOfRegist: new DateOnly(1970, 6, 26),
                    Type: TypeVehicle.FireTruck,
                    Brand: "Mercedes",
                    InspDate: new DateOnly(2024, 12, 30),
                    Status: StatusVehicle.EmManutenção,
                    WaterTankCapacity: 3000
                 );

            Console.WriteLine(fireTruck.TypeVehicles());
            #endregion

            #region Create Ambulence Object
            Ambulance ambulance = new Ambulance
               (
                   CarRegist: "25-PO-33",
                   YearOfRegist: new DateOnly(1980, 6, 26),
                   Type: TypeVehicle.Ambulence,
                   Brand: "Renault",
                   InspDate: new DateOnly(2024, 12, 30),
                   Status: StatusVehicle.EmServiço

                );

            Console.WriteLine(ambulance.TypeVehicles());
            #endregion

            #region Create MedicalEvent Object
            MedicalEvent medicalEvent = new MedicalEvent
                (
                    id: 1,
                    type: TypeEvent.Medical,
                    address:"rua das Canas nº25, Porto",
                    startEventDate: new DateTime(2024, 12, 5, 15, 15, 00),
                    endEventDate: new DateTime(2024, 12, 5, 20, 30, 00),
                    description: "Acidente entre duas viaturas",
                    severityLevel: EventSeverityLevel.Séria,
                    status: StatusEvent.EmProgresso,
                    numberOfVictims: 3,
                    typeOfEmergency: TypeOfEmergency.Choque
                );

            Console.WriteLine(medicalEvent);
            #endregion

            #region Create Equipment Object

            Equipment equipment = new Equipment
                (
                   id: 4,
                   name: "Oxigénio",
                   description: "botija de 30l",
                   quantity: 5,
                   maintenanceDate: new DateOnly(2024, 05, 25),
                   status: StatusEquipment.Disponivel

                );

            Console.WriteLine (equipment);
            #endregion
        }
    }
}