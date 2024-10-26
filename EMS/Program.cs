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
                Name: "Test",
                CitCard: "3456789",
                Birthday: new DateTime(1985, 5, 20),
                Age: 39,
                Email: "fffff@123.com",
                Phone: "945556954",
                Address: "123 Main St"

            );

            Console.WriteLine(fireFighter.TypePerson());

        }

    }
}