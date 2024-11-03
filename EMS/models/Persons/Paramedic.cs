/*-----------------------------------------------------------------------------------*
 * File Name        : Paramedic.cs                                                  *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Represents a paramedic in the Emergency Management System,     *
 *                    inheriting from the Person class. Contains properties specific  *
 *                    to paramedics, such as the technical number, and implements    *
 *                    the TypePerson method to return details of the paramedic.      *
 *-----------------------------------------------------------------------------------*/

using EMS.enums;

namespace EMS.models.Persons
{
    public class Paramedic : Person
    {
        #region Properties        
        /// <summary>
        /// Gets or sets the technical number.
        /// </summary>
        /// <value>
        /// The technical number.
        /// </value>
        private string TechnicalNumber {  get; set; }
        #endregion

        #region Constructors                      
        /// <summary>
        /// Initializes a new instance of the <see cref="Paramedic"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Name">The name.</param>
        /// <param name="CitCard">The cit card.</param>
        /// <param name="Profession">The profession.</param>
        /// <param name="Status">The status.</param>
        /// <param name="Birthday">The birthday.</param>
        /// <param name="Email">The email.</param>
        /// <param name="Phone">The phone.</param>
        /// <param name="Address">The address.</param>
        /// <param name="TechnicalNumber">The technical number.</param>
        public Paramedic(int Id, string Name, string CitCard, Profession Profession, StatusPerson Status, DateOnly Birthday, string Email, string Phone, string Address, string TechnicalNumber)
          : base(Id, Name, CitCard, Profession, Status, Birthday, Email, Phone, Address)
        {
            this.TechnicalNumber = TechnicalNumber;
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
            return  $"ID: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"CitCard: {CitCard} \n" +
                    $"Profession: {Profession}\n" +
                    $"Status: {Status}\n" +
                    $"Birthday: {Birthday} \n" +
                    $"Age: {Age} \n" +
                    $"Email: {Email} \n" +
                    $"Phone: {Phone}  \n" +
                    $"Address: {Address}  \n" +
                    $"Technical Number: {TechnicalNumber}\n";
        }
        #endregion
    }
}

