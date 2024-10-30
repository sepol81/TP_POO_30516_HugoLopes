/*-----------------------------------------------------------------------*
 * Nome do Ficheiro  : Doctor.cs                                         *
 * Autor             : Hugo Lopes                                        *
 * Data de Criação   : 26/10/2024                                        *
 * Descrição         : Defines the Doctor class, representing a doctor   *  
 *                           in the Emergency Managemente System.        *
 *-----------------------------------------------------------------------*/

using EMS.enums;

namespace EMS.models.Persons
{
    /// <summary>
    /// Represents a doctor in the emergency response system.
    /// </summary>
    /// <seealso cref="Person" />
    public class Doctor : Person
    {
        #region Constructors              
        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="CitCard"></param>
        /// <param name="Profession"></param>
        /// <param name="Status"></param>
        /// <param name="Birthday"></param>
        /// <param name="Age"></param>
        /// <param name="Email"></param>
        /// <param name="Phone"></param>
        /// <param name="Address"></param>
        public Doctor(int Id, string Name, string CitCard,Profession Profession, StatusPerson Status, DateOnly Birthday, int Age, string Email, string Phone, string Address)
           : base(Id, Name, CitCard, Profession, Status, Birthday, Age, Email, Phone, Address) { }
        #endregion


        #region Methods              
        /// <summary>
        /// Abstract method that must be implemented by any subclass.
        /// It defines the type of person.
        /// </summary>
        /// <returns>
        /// A string representing the specific type of person.
        /// </returns>
        public override string TypePerson()
        {
            return  $"ID: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"CitCard: {CitCard} \n" +
                    $"Profession: {Profession} \n" +
                    $"Status: {Status}\n" +
                    $"Birthday: {Birthday} \n" +
                    $"Age: {Age} \n" +
                    $"Email: {Email} \n" +
                    $"Phone: {Phone}  \n" +
                    $"Address: {Address}  \n";
        }

        #endregion
    }
}

