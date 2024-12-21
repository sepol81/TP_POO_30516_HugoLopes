/*-----------------------------------------------------------------------------------*
 * File Name        : EventForm.cs                                                  *
 * Author           : Hugo Lopes                                                     *
 * Creation Date    : 19/12/2024                                                     *
 * Description      : This file contains the EventForm class which manages event     *
 *                   creation, validation, and interaction with the event database.   *
 *-----------------------------------------------------------------------------------*/



using EMS.Data;
using EMS.Interfaces;
using EMS.models.Events;
using EMS.enums;

namespace EMS_AP
{
    public partial class EventForm : Form
    {
        private readonly DataBaseConnection _databaseConnection;
        private readonly IEventsManager _eventsManager;

        // Constructor
        public EventForm(DataBaseConnection databaseConnection, IEventsManager eventsManager)
        {
            InitializeComponent();
            _eventsManager = eventsManager;
            _databaseConnection = databaseConnection;
            InitializeForm();
        }

        // Initialize form settings
        private void InitializeForm()
        {
            ConfigureComboBoxes();
            ResetPanelsVisibility();
            comboBoxTypeEvent.SelectedIndexChanged += comboBoxTypeEvent_SelectedIndexChanged;
        }

        #region ComboBox Configuration

        /// <summary>
        /// Configures the ComboBoxes for event types, severity levels, and statuses.
        /// </summary>
        private void ConfigureComboBoxes()
        {
            comboBoxTypeEvent.DataSource = Enum.GetValues(typeof(TypeEvent));
            comboBoxSeverityLevel.DataSource = Enum.GetValues(typeof(EventSeverityLevel));
            comboBoxStatusEvent.DataSource = Enum.GetValues(typeof(StatusEvent));
            comboBoxTypeOfFire.DataSource = Enum.GetValues(typeof(TypeOfFire));
            comboBoxTypeOfEmerency.DataSource = Enum.GetValues(typeof(TypeOfEmergency));
            comboBoxTypeOfCatrastophe.DataSource = Enum.GetValues(typeof(TypeOfCatastrophe));

            ClearComboBoxSelections();
        }

        /// <summary>
        /// Clears the selections of all ComboBoxes.
        /// </summary>
        private void ClearComboBoxSelections()
        {
            comboBoxSeverityLevel.SelectedIndex = -1;
            comboBoxTypeEvent.SelectedIndex = -1;
            comboBoxStatusEvent.SelectedIndex = -1;
            comboBoxTypeOfFire.SelectedIndex = -1;
            comboBoxTypeOfCatrastophe.SelectedIndex = -1;
            comboBoxTypeOfEmerency.SelectedIndex = -1;
        }

        #endregion

        #region Event Type Selection

        /// <summary>
        /// Handles the event when the event type is selected.
        /// </summary>
        private void comboBoxTypeEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetPanelsVisibility();

            if (comboBoxTypeEvent.SelectedItem is TypeEvent selectedType)
            {
                switch (selectedType)
                {
                    case TypeEvent.Medical:
                        panelMedical.Visible = true;
                        break;
                    case TypeEvent.Incêndio:
                        panelFire.Visible = true;
                        break;
                    case TypeEvent.Catástrofe:
                        panelCatastrophe.Visible = true;
                        break;
                }
            }
        }

        #endregion

        #region Validation and Event Creation

        /// <summary>
        /// Validates all inputs and creates an Event object if valid.
        /// </summary>
        /// <param name="event">The created Event object if validation succeeds.</param>
        /// <returns>True if inputs are valid, false otherwise.</returns>
        private bool ValidateInputs(out Event @event)
        {
            @event = null;

            if (!ValidateCommonInputs(out var typeEvent, out var address, out var startEventDate, out var endEventDate, out var description, out var severityLevel, out var statusEvent))
                return false;

            switch (typeEvent)
            {
                case TypeEvent.Medical:
                    return ValidateMedicalEventInputs(out @event, address, startEventDate, endEventDate, description, severityLevel, statusEvent);
                case TypeEvent.Incêndio:
                    return ValidateFireEventInputs(out @event, address, startEventDate, endEventDate, description, severityLevel, statusEvent);
                case TypeEvent.Catástrofe:
                    return ValidateCatastropheEventInputs(out @event, address, startEventDate, endEventDate, description, severityLevel, statusEvent);
                default:
                    MessageBox.Show("Tipo de Ocorrência invalido.");
                    return false;
            }
        }

        /// <summary>
        /// Validates common inputs for all event types.
        /// </summary>
        private bool ValidateCommonInputs(out TypeEvent typeEvent, out string address, out DateTime startEventDate, out DateTime endEventDate, out string description, out EventSeverityLevel severityLevel, out StatusEvent statusEvent)
        {
            address = textBoxAddress.Text.Trim();
            description = Description.Text.Trim();

            if (comboBoxTypeEvent.SelectedItem == null ||
                string.IsNullOrWhiteSpace(address) ||
                !DateTime.TryParse(textBoxDateTimeStart.Text, out startEventDate) ||
                !DateTime.TryParse(textBoxDateTimeEnd.Text, out endEventDate) ||
                string.IsNullOrWhiteSpace(description) ||
                comboBoxSeverityLevel.SelectedItem == null ||
                comboBoxStatusEvent.SelectedItem == null)
            {
                MessageBox.Show("Por favor preencha todos os campos obrigatórios.");
                typeEvent = default;
                address = default;
                startEventDate = default;
                endEventDate = default;
                description = default;
                severityLevel = default;
                statusEvent = default;

                return false;
            }

            typeEvent = (TypeEvent)comboBoxTypeEvent.SelectedItem;
            severityLevel = (EventSeverityLevel)comboBoxSeverityLevel.SelectedItem;
            statusEvent = (StatusEvent)comboBoxStatusEvent.SelectedItem;

            return true;
        }

        /// <summary>
        /// Validates inputs specific to medical events.
        /// </summary>
        private bool ValidateMedicalEventInputs(out Event @event, string address, DateTime startEventDate, DateTime endEventDate, string description, EventSeverityLevel severityLevel, StatusEvent statusEvent)
        {
            @event = null;

            if (string.IsNullOrWhiteSpace(textBoxNunberOfVictimsMedical.Text) ||
                !int.TryParse(textBoxNunberOfVictimsMedical.Text, out var numberOfVictims) ||
                comboBoxTypeOfEmerency.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos de emergência médica.");
                return false;
            }

            var typeOfEmergency = (TypeOfEmergency)comboBoxTypeOfEmerency.SelectedItem;

            @event = new MedicalEvent(TypeEvent.Medical, address, startEventDate, endEventDate, description, severityLevel, statusEvent, numberOfVictims, typeOfEmergency);

            return true;
        }

        /// <summary>
        /// Validates inputs specific to fire events.
        /// </summary>
        private bool ValidateFireEventInputs(out Event @event, string address, DateTime startEventDate, DateTime endEventDate, string description, EventSeverityLevel severityLevel, StatusEvent statusEvent)
        {
            @event = null;

            if (comboBoxTypeOfFire.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxFireIntensity.Text) ||
                !double.TryParse(textBoxFireAffectedArea.Text, out var affectedArea))
            {
                MessageBox.Show("Por favor preencha todos os campos relacionados ao fogo.");
                return false;
            }

            var typeOfFire = (TypeOfFire)comboBoxTypeOfFire.SelectedValue;
            var fireIntensity = textBoxFireIntensity.Text;

            @event = new FireEvent(TypeEvent.Incêndio, address, startEventDate, endEventDate, description, severityLevel, statusEvent, typeOfFire, fireIntensity, affectedArea);

            return true;
        }

        /// <summary>
        /// Validates inputs specific to catastrophe events.
        /// </summary>
        private bool ValidateCatastropheEventInputs(out Event @event, string address, DateTime startEventDate, DateTime endEventDate, string description, EventSeverityLevel severityLevel, StatusEvent statusEvent)
        {
            @event = null;

            if (!double.TryParse(textBoxAfectedArea.Text, out var affectedArea) ||
                comboBoxTypeOfCatrastophe.SelectedItem == null ||
                !int.TryParse(textBoxNumberOfVictims.Text, out var numberOfVictims))
            {
                MessageBox.Show("Preencha todos os campos relacionados a catástrofes.");
                return false;
            }

            var typeOfCatrastophe = (TypeOfCatastrophe)comboBoxTypeOfCatrastophe.SelectedValue;

            @event = new CatastropheEvent(TypeEvent.Catástrofe, address, startEventDate, endEventDate, description, severityLevel, statusEvent, affectedArea, typeOfCatrastophe, numberOfVictims);

            return true;
        }

        #endregion

        #region Save Event

        /// <summary>
        /// Saves the created event to the database and closes the form.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out Event @event))
                return;

            try
            {
                _eventsManager.AddEvent(@event);
                MessageBox.Show("Ocorrência criada com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar ocorrência: {ex.Message}");
            }
        }

        #endregion

        #region Show Event Manager

        /// <summary>
        /// Opens the event manager form.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            var EventManager = new EventFormManager(_databaseConnection, _eventsManager);
            EventManager.ShowDialog();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Resets the visibility of all event-specific panels.
        /// </summary>
        private void ResetPanelsVisibility()
        {
            panelMedical.Visible = false;
            panelFire.Visible = false;
            panelCatastrophe.Visible = false;
        }

        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
