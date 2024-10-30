/*-----------------------------------------------------------------------------------*
 * Nome do Ficheiro  : FireFighter.cs                                                *
 * Autor             : Hugo Lopes                                                    *
 * Data de Criação   : 26/10/2024                                                    *
 * Descrição         : Defines the Fire-Fighter class, representing a fireFighter   *  
 *                           in the Emergency Managemente System.                    *
 *-----------------------------------------------------------------------------------*/
using EMS.enums;
namespace EMS.models.Persons
{
    /// <summary>
    /// Represents a firefighter in the emergency management system.
    /// </summary>
    /// <seealso cref="Person" />

    public class FireFighter : Person
    {
        #region Properties
        public RankFireFighter Rank { get; set; }
        public int YearsOfExp { get; set; }
        public List<string> Certifications { get; set; }
        public List<string> Skills { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FireFighter"/> class.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Name">The name.</param>
        /// <param name="CitCard">The cit card.</param>
        /// <param name="Profession">The profession.</param>
        /// <param name="Status">The status.</param>
        /// <param name="Birthday">The birthday.</param>
        /// <param name="Age">The age.</param>
        /// <param name="Email">The email.</param>
        /// <param name="Phone">The phone.</param>
        /// <param name="Address">The address.</param>
        /// <param name="Rank">The rank.</param>
        /// <param name="YearsOfExp">The years of exp.</param>
        /// <param name="Certifications">The certifications.</param>
        /// <param name="Skills">The skills.</param>
        public FireFighter(int Id, string Name, string CitCard,Profession Profession, StatusPerson Status, DateOnly Birthday, int Age, string Email, string Phone, string Address,
            RankFireFighter Rank, int YearsOfExp, List<string> Certifications, List<string> Skills)
            : base(Id, Name, CitCard, Profession, Status, Birthday, Age, Email, Phone, Address)
        {
            this.Rank = Rank;
            this.YearsOfExp = YearsOfExp;
            this.Certifications = Certifications;
            this.Skills = Skills;

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
                    $"Profession: {Profession} \n" +
                    $"Status: {Status}\n" +
                    $"Birthday: {Birthday} \n" +
                    $"Age: {Age} \n" +
                    $"Email: {Email} \n" +
                    $"Phone: {Phone}  \n" +
                    $"Address: {Address}  \n" +
                    $"Rank: {Rank}\n" +
                    $"Years of exerience: {YearsOfExp}\n" +
                    $"Certifications: {string.Join(", ", Certifications)}\n" +
                    $"Special Skills: {string.Join(", ", Skills)}\n";
        }

        #endregion
    }
}
