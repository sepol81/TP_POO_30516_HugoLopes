/*-----------------------------------------------------------------------------------*
 * File Name        : LoginForm.cs                                                   *
 * Author           : Hugo Lopes (@sepol81)                                          *
 * Creation Date    : 20/12/2024                                                     *
 * Description      : This file contains the LoginForm class for the EMS application. *
 *                   It handles user login and authentication, form interactions,    *
 *                   and provides functionality for opening the user creation form.  *
 *-----------------------------------------------------------------------------------*/

using System;
using EMS.services;
using System.Windows.Forms;
using EMS.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using EMS.Services;
using System.Runtime.CompilerServices;
using EMS.Interfaces;

namespace EMS_AP
{
    // Main login form for EMS application
    public partial class LoginForm : Form
    {
        private readonly DataBaseConnection _databaseConnection;
        private readonly ICreateUser _createUser;
        private readonly IAuthServ _authService;
        private readonly IEventsManager _eventsManager;

        // Constructor to initialize dependencies and components
        public LoginForm(IAuthServ authServ, ICreateUser createUser, DataBaseConnection databaseConnection, IEventsManager eventsManager)
        {
            _databaseConnection = databaseConnection ?? throw new ArgumentNullException(nameof(databaseConnection));
            _createUser = createUser;
            _authService = authServ;
            _eventsManager = eventsManager;
            InitializeComponent();
        }

       
        #region Button Click Events

        // Handles login button click event
        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text;
            string password = txt_password.Text;

            try
            {
                // Authenticate the user using the authentication service
                var user = _authService.Authenticate(username, password);

                if (user != null)
                {
                    // Hide login form and show the FireStation form
                    this.Hide();
                    FireStationForm fireStationForm = new FireStationForm(_eventsManager, _databaseConnection);
                    fireStationForm.Show();
                }
                else
                {
                    MessageBox.Show("Nome do utilisador ou passsword errado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        // Handles cancel button click event
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handles user creation button click event
        private void Button_CreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Show user creation form
                CreateUserForm createUserForm = new CreateUserForm(_createUser, _databaseConnection);
                createUserForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário de criação do utilisador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region TextBox Focus Events

        // Changes background color when entering username field
        private void txt_name_Enter(object sender, EventArgs e)
        {
            txt_name.BackColor = Color.LightBlue;
        }

        // Resets background color when leaving username field
        private void txt_name_Leave(object sender, EventArgs e)
        {
            txt_name.BackColor = Color.White;
        }

        // Changes background color when entering password field
        private void txt_password_Enter(object sender, EventArgs e)
        {
            txt_password.BackColor = Color.LightBlue;
        }

        // Resets background color when leaving password field
        private void txt_password_Leave(object sender, EventArgs e)
        {
            txt_password.BackColor = Color.White;
        }

        #endregion

       
    }
}
