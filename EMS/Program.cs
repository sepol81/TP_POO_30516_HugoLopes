using EMS.enums;
using EMS.models.Persons;
using EMS.models.Vehicles;
using System;


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
                Name: "Test1",
                CitCard: "3456789",
                Profession: Profession.Bombeiro,
                Status: StatusPerson.EmServiço,
                Birthday: new DateOnly(1975, 7, 21),
                Age:0,
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
                Name: "Test2",
                CitCard: "865987",
                Profession: Profession.Medico,
                Status: StatusPerson.Disponivel,
                Birthday: new DateOnly(1981, 7, 23),
                Age: 0,
                Email: "ddddd@123.com",
                Phone: "95896625",
                Address: "Porto"

            );

            Console.WriteLine(doctor.TypePerson());
            #endregion

            #region Create Nurse Object
            Nurse nurse = new Nurse
           (
               Id: 1,
               Name: "Test3",
               CitCard: "1258995",
               Profession: Profession.Enfermeiro,
               Birthday: new DateOnly(1994, 7, 23),
               Status: StatusPerson.EmDescanso,
               Age: 0,
               Email: "nnnnn@123.com",
               Phone: "023654985",
               Address: "Lisboa"

           );

            Console.WriteLine(nurse.TypePerson());
            #endregion

            FireTruck fireTruck = new FireTruck
                (
                    CarRegist: "23-WE-34",
                    YearOfRegist: new DateOnly(1970, 6, 26),
                    Age:0 ,
                    Type: TypeVehicle.FireTruck,
                    Brand: "Mercedes",
                    InspDate: new DateOnly(2024, 12, 30),
                    Status: StatusVehicle.EmManutenção,
                    WaterTankCapacity: 3
                 );

            Console.WriteLine(fireTruck.TypeVehicles());

        }
              


        


    }
}