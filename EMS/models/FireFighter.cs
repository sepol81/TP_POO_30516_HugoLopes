using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.models
{
    /// <summary>
    /// 
    /// </summary>
    public class FireFighter : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireFighter"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="citCard">The cit card.</param>
        /// <param name="birthday">The birthday.</param>
        /// <param name="age">The age.</param>
        /// <param name="email">The email.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="address">The address.</param>
       public FireFighter(int Id, string Name, string CitCard, DateTime Birthday, int Age, string Email, string Phone, string Address)
            : base(Id, Name, CitCard, Birthday, Age, Email, Phone, Address) { }

    public override string TypePerson()
        {
            return $"ID: {Id}\n" +
                     $"Name: {Name}\n" +
                     $"CitCard: {CitCard} \n" +
                     $"Birthday: {Birthday} \n" +
                     $"Age: {Age} \n" +
                     $"Email: {Email} \n" +
                     $"Phone: {Phone}  \n" +
                     $"Address: {Address}  \n";
        }

        
    }
}
