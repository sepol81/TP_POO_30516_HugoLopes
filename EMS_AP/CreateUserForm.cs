/*-----------------------------------------------------------------------------------*
 * File Name        : CreateUserForm.cs                                             *
 * Author           : Hugo Lopes (@sepol81)                                          *
 * Creation Date    : 20/12/2024                                                     *
 * Description      : This file contains the CreateUserForm class, which handles     *
 *                   the creation of new users through a form, including validation *
 *                   and interaction with the database.                             *
 *-----------------------------------------------------------------------------------*/

using System;
using EMS.services;
using EMS.Data;
using EMS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_AP
{
    // Main form for creating users
    public partial class CreateUserForm : Form
    {
        private readonly ICreateUser _createUser;
        private readonly DataBaseConnection _databaseConnection;

        // Constructor for initializing form components and dependencies
        public CreateUserForm(ICreateUser createUser, DataBaseConnection databaseConnection)
        {
            InitializeComponent();
            _createUser = createUser;
            _databaseConnection = databaseConnection;
        }

        #region Button Click Events

        // Event handler for the 'Create User' button click
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text?.Trim();
            var password = txtPassword.Text?.Trim();

            // Validate that both fields are filled out
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Attempt to create the user
                _createUser.CreateUserx(username, password);
                MessageBox.Show("Utilisador criado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtUsername.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                // Display any errors that occur during user creation
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the 'Cancel' button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        #endregion
                
    }
}
