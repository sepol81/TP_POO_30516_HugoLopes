/*-----------------------------------------------------------------------------------*
 * File Name         : CalAge.cs                                                     *
 * Author            : Hugo Lopes                                                    *
 * Creation Date     : 26/10/2024                                                    *
 * Description       : Contains methods for calculating age based on a given date.   *
 *-----------------------------------------------------------------------------------*/

namespace Utils
{
    public class CalAge
    {
        #region Public Methods
        /// <summary>
        /// Calculate Age base on date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int Age(DateOnly date)
            {
                DateOnly today = DateOnly.FromDateTime(DateTime.Now);
                int age = today.Year - date.Year;
                if (date > today.AddYears(-age)) age--;
                return age;
            }
            #endregion
      
    }
}
