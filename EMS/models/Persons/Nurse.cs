/*-----------------------------------------------------------------------*
 * File Name        : Nurse.cs                                           *
 * Author           : Hugo Lopes                                         *
 * Creation Date    : 26/10/2024                                         *
 * Description      : Defines the Nurse class, representing a nurse in   *
 *                    the Emergency Management System. It includes       *
 *                    properties specific to nurses, such as card number *
 *                    and area of activity, and implements the           *
 *                    TypePerson method to return details of the nurse.  *
 *-----------------------------------------------------------------------*/

using EMS.enums;

namespace EMS.models.Persons
{
    /// <summary>
    /// Represents a nurse in the emergency response system.
    /// </summary>
    /// <seealso cref="Person" />
    public class Nurse : Person
    {
        #region Properties

        private string cardNumber {  get; set; }
        private string areaOfActivity { get; set; }
        


        #endregion

        #region Constructors              
        /// <summary>
        /// Initializes a new instance of the <see cref="Nurse"/> class.
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
        public Nurse(int Id, string Name, string CitCard,Profession Profession, StatusPerson Status, DateOnly Birthday, string Email, string Phone, string Address, string CardNumber, string AreOfActivity)
          : base(Id, Name, CitCard, Profession, Status, Birthday, Email, Phone, Address) 
        {
            this.cardNumber = CardNumber;
            this.areaOfActivity = AreOfActivity;

        }
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
            return $"ID: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"CitCard: {CitCard} \n" +
                    $"Profession: {Profession}\n" +
                    $"Status: {Status}\n" +
                    $"Birthday: {Birthday} \n" +
                    $"Age: {Age} \n" +
                    $"Email: {Email} \n" +
                    $"Phone: {Phone}  \n" +
                    $"Address: {Address}  \n" +
                    $"Card Number: {cardNumber}\n" +
                    $"Area Of Activity: {areaOfActivity}\n";
        }
        #endregion
    }
}
