/*-----------------------------------------------------------------------------------*
 * File Name        : PersonsManager.cs                                              *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Manages the collection of persons within the Emergency         *
 *                    Management System. This class provides methods to add, remove, *
 *                    and update person records.                                     *
 *-----------------------------------------------------------------------------------*/


namespace EMS.models.Persons
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonsManager
    {
        #region Properties
        /// <summary>
        /// The persons
        /// </summary>
        private List<Person> persons;
        #endregion

        #region Construters        
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonsManager"/> class.
        /// </summary>
        public PersonsManager()
        {
            persons = new List<Person>();
           
        }
        #endregion

        #region Methods
        public void AddPersons(Person person){}
       
                
        public void RemovePersons(Person person){}
       
        
        public void UpdatePersons(Person person){}

        public void GetAllPersons(Person person){}
        #endregion
    }
}
