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
            #region Create FireFighter Object
            FireFighter fireFighter = new FireFighter
            (
                Id: 1,
                Name: "Test1",
                CitCard: "3456789",
                Status: "",
                Birthday: new DateTime(2024, 7, 21),
                Age: 39,
                Email: "fffff@123.com",
                Phone: "945556954",
                Address: "Barcelos"

            );

            Console.WriteLine(fireFighter.TypePerson());
            #endregion

            #region Create Doctor Object
            Doctor doctor = new Doctor
            (
                Id: 1,
                Name: "Test2",
                CitCard: "865987",
                Status: "",
                Birthday: new DateTime(2024, 7, 23),
                Age: 39,
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
               Birthday: new DateTime(2024, 7, 23),
               Status:"",
               Age: 39,
               Email: "nnnnn@123.com",
               Phone: "023654985",
               Address: "Lisboa"

           );

            Console.WriteLine(nurse.TypePerson());
            #endregion
        }


    }
}