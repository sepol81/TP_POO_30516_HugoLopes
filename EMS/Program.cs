using EMS.models;
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
            // Creating a FireFighter object using property initializers
            FireFighter fireFighter = new FireFighter
            (
                Id: 1,
                Name: "Test1",
                CitCard: "3456789",
                Birthday: new DateTime(2024, 7, 21),
                Age: 39,
                Email: "fffff@123.com",
                Phone: "945556954",
                Address: "Barcelos"

            );

            Console.WriteLine(fireFighter.TypePerson());

            Doctor doctor = new Doctor
            (
                Id: 1,
                Name: "Test2",
                CitCard: "865987",
                Birthday: new DateTime(2024, 7, 23),
                Age: 39,
                Email: "ddddd@123.com",
                Phone: "95896625",
                Address: "Porto"

            );

            Console.WriteLine(doctor.TypePerson());

            Nurse nurse = new Nurse
           (
               Id: 1,
               Name: "Test3",
               CitCard: "1258995",
               Birthday: new DateTime(2024, 7, 23),
               Age: 39,
               Email: "nnnnn@123.com",
               Phone: "023654985",
               Address: "Lisboa"

           );

            Console.WriteLine(nurse.TypePerson());

        }


    }
}