/*-----------------------------------------------------------------------------------*
 * File Name        : TeamsManager.cs                                                *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 26/10/2024                                                     *
 * Description      : Class for managing a collection of teams within the EMS,       *
 *                    providing methods to add, remove, update, and retrieve teams.  *
 *-----------------------------------------------------------------------------------*/



namespace EMS.models.Teams
{
    public class TeamsManager
    {

        #region Properties        
        /// <summary>
        /// The teams
        /// </summary>
        private List<Team> teams;
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsManager"/> class.
        /// </summary>
        public TeamsManager()
        {
            teams = new List<Team>();
        }
        #endregion

        #region Methods       
        /// <summary>
        /// Adds the team.
        /// </summary>
        /// <param name="team">The team.</param>
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        /// <summary>
        /// Removes the team.
        /// </summary>
        /// <param name="team">The team.</param>
        public void RemoveTeam(Team team) { }


        /// <summary>
        /// Updates the team.
        /// </summary>
        /// <param name="team">The team.</param>
        public void UpdateTeam(Team team) { }


        /// <summary>
        /// Gets all teams.
        /// </summary>
        /// <returns></returns>
        public List<Team> GetAllTeams()
        {
            return teams;
        }
        #endregion
    }
}

