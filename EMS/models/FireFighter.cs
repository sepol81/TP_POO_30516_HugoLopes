
/*-----------------------------------------------------------------------------------*
 * Nome do Ficheiro  : FireFighter.cs                                                *
 * Autor             : Hugo Lopes                                                    *
 * Data de Criação   : 26/10/2024                                                    *
 * Descrição         : Defines the Fire-Fighter class, representing a fireFighter   *  
 *                           in the Emergency Managemente System.                    *
 *-----------------------------------------------------------------------------------*/
namespace EMS.models
{
    /// <summary>
    /// Represents a firefighter in the emergency response system.
    /// </summary>
    /// <seealso cref="EMS.models.Person" />
    public class FireFighter : Person
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="FireFighter"/> class.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="CitCard"></param>
        /// <param name="Birthday"></param>
        /// <param name="Age"></param>
        /// <param name="Email"></param>
        /// <param name="Phone"></param>
        /// <param name="Address"></param>
        public FireFighter(int Id, string Name, string CitCard,string Status, DateTime Birthday, int Age, string Email, string Phone, string Address)
            : base(Id, Name, CitCard, Status, Birthday, Age, Email, Phone, Address) { }
        #endregion

        #region Methods
        /// <summary>
        /// Abstract method that must be implemented by any subclass.
        /// It defines the type of person (doctor, nurse, firefighter).
        /// </summary>
        /// <returns>
        /// A string representing the specific type of person.
        /// </returns>
        public override string TypePerson()
        {
            return  $"FireFighter\n"+
                    $"ID: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"CitCard: {CitCard} \n" +
                    $"Birthday: {Birthday} \n" +
                    $"Age: {Age} \n" +
                    $"Email: {Email} \n" +
                    $"Phone: {Phone}  \n" +
                    $"Address: {Address}  \n";
        }

        #endregion
    }
}
