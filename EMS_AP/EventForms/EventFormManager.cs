/*-----------------------------------------------------------------------------------*
 * File Name        : EventForm.cs                                                  *
 * Author           : Hugo Lopes (@sepol81)                                          *
 * Creation Date    : 19/12/2024                                                     *
 * Description      : This file contains the EventForm class which manages event     *
 *                   creation, validation, and interaction with the event database.   *
 *-----------------------------------------------------------------------------------*/

using EMS.Data;
using EMS.enums;
using EMS.Interfaces;
using EMS.models.Events;
using EMS.services;

namespace EMS_AP
{
    public partial class EventFormManager : Form
    {
        private readonly DataBaseConnection _databaseConnection;
        private readonly IEventsManager _eventsManager;

        // Constructor to initialize the form and dependencies
        public EventFormManager(DataBaseConnection databaseConnection, IEventsManager eventsManager)
        {
            InitializeComponent();
            _eventsManager = eventsManager;
            _databaseConnection = databaseConnection;
            dataGridViewEvents.Visible = false;
        }

        private void EventFormManager_Load(object sender, EventArgs e)
        {
            // Initial load actions if needed
        }

        #region DataGridView Configuration

        /// <summary>
        /// Configures the data grid view for event display.
        /// </summary>
        private void ConfigureDataGridView()
        {
            dataGridViewEvents.Columns.Clear();
            dataGridViewEvents.Columns.Add("Id", "ID");
            dataGridViewEvents.Columns.Add("Type", "Event Type");
            dataGridViewEvents.Columns.Add("Address", "Address");
            dataGridViewEvents.Columns.Add("StartDate", "Start Date");
            dataGridViewEvents.Columns.Add("EndDate", "End Date");
            dataGridViewEvents.Columns.Add("Description", "Description");
            dataGridViewEvents.Columns.Add("Severity", "Severity Level");
            dataGridViewEvents.Columns.Add("Status", "Status");
        }

        /// <summary>
        /// Configures the columns for read-only or editable states based on the column name.
        /// </summary>
        private void ConfigureDataGridViewColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewEvents.Columns)
            {
                if (column.Name == "Id" || column.Name == "Event Type" || column.Name == "Address" || column.Name == "Start Date"
                    || column.Name == "End Date" || column.Name == "Description" || column.Name == "Severity Level"
                    || column.Name == "Status")
                {
                    column.ReadOnly = true;
                }
                else
                {
                    column.ReadOnly = false;
                }
            }
        }

        #endregion

        #region Event Display

        /// <summary>
        /// Handles the Click event to show all events.
        /// </summary>
        private void buttonShowAllEventes_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            dataGridViewEvents.Rows.Clear();

            try
            {
                if (_databaseConnection == null)
                {
                    MessageBox.Show("Não foi possível conectar á base de dados.");
                    return;
                }

                IEnumerable<Event> events = _eventsManager.GetAllEvents();

                foreach (var @event in events)
                {
                    if (@event == null)
                    {
                        MessageBox.Show("Nenhuma occorência encontrada!");
                        continue;
                    }

                    dataGridViewEvents.Rows.Add(
                        @event.Id.ToString(),
                        @event.Type.ToString(),
                        @event.Address,
                        @event.StartEventDate.ToString("g"),
                        @event.EndEventDate.ToString("g"),
                        @event.Description,
                        @event.SeverityLevel.ToString(),
                        @event.Status.ToString()
                    );
                    dataGridViewEvents.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erro ao carregar as ocorrências: {ex.Message}\nDetalhes: {ex.StackTrace}"); }
        }

        /// <summary>
        /// Handles the Click event to show medical events.
        /// </summary>
        private void buttonShowmedicalEventes_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            dataGridViewEvents.Rows.Clear();

            try
            {
                if (_databaseConnection == null)
                {
                    MessageBox.Show("Não foi possível conectar ao banco de dados.");
                    return;
                }

                IEnumerable<MedicalEvent> events = _eventsManager.GetAllMedicalEvents();
                dataGridViewEvents.Columns.Add("NumberOfVictims", "Number of Victims");
                dataGridViewEvents.Columns.Add("TypeOfEmergency", "Type of Emergency");

                foreach (var @event in events)
                {
                    if (@event == null)
                    {
                        MessageBox.Show("Nenhuma ocorrência medical encontrada");
                        continue;
                    }

                    dataGridViewEvents.Columns.Add("TypeOfFire", "Type of Fire");
                    dataGridViewEvents.Columns.Add("FireIntensity", "Fire Intensity");
                    dataGridViewEvents.Columns.Add("AffectedArea", "Affected Area");

                    dataGridViewEvents.Rows.Add(
                        @event.Id.ToString(),
                        @event.Type.ToString(),
                        @event.Address,
                        @event.StartEventDate.ToString("g"),
                        @event.EndEventDate.ToString("g"),
                        @event.Description,
                        @event.SeverityLevel.ToString(),
                        @event.Status.ToString(),
                        @event.NumberOfVictims.ToString(),
                        @event.TypeOfEmergency.ToString()
                    );
                }
                dataGridViewEvents.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as ocorrências: {ex.Message}\nDetails: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Handles the Click event to show fire events.
        /// </summary>
        private void buttonShowFireEvents_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            dataGridViewEvents.Rows.Clear();

            try
            {
                if (_databaseConnection == null)
                {
                    MessageBox.Show("Não foi possível conectar-se ao banco de dados.");
                    return;
                }
                IEnumerable<FireEvent> events = _eventsManager.GetAllFireEvents();
                dataGridViewEvents.Columns.Add("TypeOfFire", "Type of Fire");
                dataGridViewEvents.Columns.Add("FireIntensity", "Fire Intensity");
                dataGridViewEvents.Columns.Add("AffectedArea", "Affected Area");

                foreach (var @event in events)
                {
                    if (@event == null)
                    {
                        MessageBox.Show("Nenhuma ocorrência de incêndio encontrada");
                        continue;
                    }

                    dataGridViewEvents.Rows.Add(
                        @event.Id.ToString(),
                        @event.Type.ToString(),
                        @event.Address,
                        @event.StartEventDate.ToString("g"),
                        @event.EndEventDate.ToString("g"),
                        @event.Description,
                        @event.SeverityLevel.ToString(),
                        @event.Status.ToString(),
                        @event.TypeOfFire.ToString(),
                        @event.FireIntensity.ToString(),
                        @event.AffectedArea.ToString()
                    );
                }
                dataGridViewEvents.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as ocorrências: {ex.Message}\nDetails: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Handles the Click event to show catastrophe events.
        /// </summary>
        private void buttonShowCatastrpheEvents_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            dataGridViewEvents.Rows.Clear();

            try
            {
                if (_databaseConnection == null)
                {
                    MessageBox.Show("Could not connect to the database.");
                    return;
                }
                IEnumerable<CatastropheEvent> events = _eventsManager.GetAllCatastropheEvents();
                dataGridViewEvents.Columns.Add("AffectedArea", "Affected Area");
                dataGridViewEvents.Columns.Add("TypeCat", "Catastrophe Type");
                dataGridViewEvents.Columns.Add("NumberOfVictims", "Number of Victims");

                foreach (var @event in events)
                {
                    if (@event == null)
                    {
                        MessageBox.Show("No catastrophe events found");
                        continue;
                    }

                    dataGridViewEvents.Rows.Add(
                        @event.Id.ToString(),
                        @event.Type.ToString(),
                        @event.Address,
                        @event.StartEventDate.ToString("g"),
                        @event.EndEventDate.ToString("g"),
                        @event.Description,
                        @event.SeverityLevel.ToString(),
                        @event.Status.ToString(),
                        @event.AffectedArea.ToString(),
                        @event.TypeCat.ToString(),
                        @event.NumberOfVictims.ToString()
                    );

                    dataGridViewEvents.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}\nDetalhes: {ex.StackTrace}");
            }
        }

        #endregion

        #region Event Handling and CRUD Operations

        /// <summary>
        /// Handles the search event by event ID.
        /// </summary>
        private void buttonshearchingEvent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCodEvent.Text, out int id))
            {
                try
                {
                    var eventResult = _eventsManager.GetEventById(id);

                    if (eventResult != null)
                    {
                        ConfigureDataGridView();
                        dataGridViewEvents.Rows.Clear();

                        dataGridViewEvents.Rows.Add(
                            eventResult.Id.ToString(),
                            eventResult.Type.ToString(),
                            eventResult.Address,
                            eventResult.StartEventDate.ToString("g"),
                            eventResult.EndEventDate.ToString("g"),
                            eventResult.Description,
                            eventResult.SeverityLevel.ToString(),
                            eventResult.Status.ToString()
                        );

                        dataGridViewEvents.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show($"Ocorrência não encontrada pelo ID {id}.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro á procura de ocorrências: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Insira um ID para pesquisa.");
            }
        }

        #endregion

        #region Save and Delete Operations

        /// <summary>
        /// Handles the event saving process.
        /// </summary>
        private void buttonSaveEvente_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewEvents.Rows)
                {
                    if (row.IsNewRow || row.Cells["Id"].Value == null)
                        continue;

                    int id = int.Parse(row.Cells["Id"].Value.ToString());
                    string type = row.Cells["Type"].Value?.ToString();
                    string address = row.Cells["Address"].Value?.ToString();
                    DateTime startDate = DateTime.Parse(row.Cells["StartDate"].Value?.ToString());
                    DateTime endDate = DateTime.Parse(row.Cells["EndDate"].Value?.ToString());
                    string description = row.Cells["Description"].Value?.ToString();
                    string severity = row.Cells["Severity"].Value?.ToString();
                    string status = row.Cells["Status"].Value?.ToString();

                    var existingEvent = _eventsManager.GetEventById(id);

                    if (existingEvent != null)
                    {
                        existingEvent.Type = (TypeEvent)Enum.Parse(typeof(TypeEvent), type);
                        existingEvent.Address = address;
                        existingEvent.StartEventDate = startDate;
                        existingEvent.EndEventDate = endDate;
                        existingEvent.Description = description;
                        existingEvent.SeverityLevel = (EventSeverityLevel)Enum.Parse(typeof(EventSeverityLevel), severity);
                        existingEvent.Status = (StatusEvent)Enum.Parse(typeof(StatusEvent), status);

                        _eventsManager.UpdateEvent(existingEvent);
                    }
                }

                MessageBox.Show("Alterações guadadas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar alterações: {ex.Message}\nDetalhes: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Handles the event deletion process.
        /// </summary>
        private void buttonDeleteEvent_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEvents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("selecione a ocorrência a eliminar.");
                    return;
                }

                var selectedRow = dataGridViewEvents.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value == null)
                {
                    MessageBox.Show("Ocorrência não encontrada.");
                    return;
                }

                int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());

                var confirmation = MessageBox.Show(
                    $"Tem certeza que deseja eliminar o evento com ID {id}?","Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    _eventsManager.RemoveEvent(id);
                    dataGridViewEvents.Rows.Remove(selectedRow);

                    MessageBox.Show("Ocorrência eliminada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar ocorrêcia: {ex.Message}\nDetalhes: {ex.StackTrace}");
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
