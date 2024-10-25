


using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace EMS.models
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Person
    {
        #region Private Properties
        private int id { get; set; }
        private string name { get; set; }
        private string citCard { get; set; }
        private DateTime birthday { get; set; }
        private int age { get; set; }
        private string email { get; set; }
        private string phone { get; set; }
        private string address { get; set; }



        #endregion

        #region Public Properties        
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string CitCard
        {
            get => citCard;
            set => citCard = value;
        }

        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }

        #endregion

        #region Constructors         
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="citCard">The cart cid.</param>
        /// <param name="birthday">The birthday.</param>
        /// <param name="age">The age.</param>
        /// <param name="email">The email.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="address">The address.</param>
        public Person(int id, string name, string citCard, DateTime birthday, int age, string email, string phone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.CitCard = citCard;
            this.Birthday = birthday;
            this.Age = age;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;

        }


        #endregion  
        
        #region Abstract Method
        /// <summary>
        /// Abstract method that must be implemented by any subclass.
        /// It defines the type of person (doctor, nurse, firefighter).
        /// </summary>
        /// <returns>A string representing the specific type of person.</returns>
        public abstract string TypePerson();
        #endregion;


    }
}