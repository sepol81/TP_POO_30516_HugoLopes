/*-----------------------------------------------------------------------------------*
 * File Name        : FireStationForm.cs                                             *
 * Author           : Hugo Lopes (@sepol81)                                          *
 * Creation Date    : 20/12/2024                                                     *
 * Description      : This file contains the FireStationForm class, which is a part   *
 *                   of the EMS application. It handles the interaction with various *
 *                   aspects of the fire station interface, including event handling,*
 *                   time display, and the integration of Waze for real-time mapping. *
 *-----------------------------------------------------------------------------------*/

using EMS.Data;
using EMS.services;
using EMS.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using EMS.enums;
using EMS.models.Events;

namespace EMS_AP
{
    // Main form for FireStation interface
    public partial class FireStationForm : Form
    {
        private Label labelTime;
        private System.Windows.Forms.Timer timer;
        private IEventsManager _eventsManager;
        private WebView2 webView;
        private readonly DataBaseConnection _databaseConnection;

        // Constructor to initialize components and dependencies
        public FireStationForm(IEventsManager eventsManager, DataBaseConnection databaseConnection)
        {
            InitializeComponent();
            InitializeComponenttimer();
            _eventsManager = eventsManager;
            _databaseConnection = databaseConnection;
        }

        #region Time Display and Timer Setup

        // Initializes the timer and the label for displaying time
        private void InitializeComponenttimer()
        {
            labelTime = new Label();
            timer = new System.Windows.Forms.Timer();

            // Set up the label to display current time
            labelTime.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTime.ForeColor = Color.Black;
            labelTime.Location = new Point(1000, 100);  // Set label position
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(200, 25);
            labelTime.TabIndex = 10;
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");  // Initial time display

            // Set up the timer to update every second
            timer.Interval = 1000;  // 1 second interval
            timer.Tick += (sender, e) =>
            {
                labelTime.Text = DateTime.Now.ToString("HH:mm:ss");  // Update time
            };
            timer.Start();

            // Add label to form controls
            Controls.Add(labelTime);
        }

        #endregion

        #region Button Click Events

        // Opens the Persons Form when clicked
        private void button2_Click(object sender, EventArgs e)
        {
            var Persons = new PersonsForm();
            Persons.ShowDialog();
        }

        // Opens the Event Form when clicked
        private void button1_Click(object sender, EventArgs e)
        {
            var Event = new EventForm(_databaseConnection, _eventsManager);
            Event.ShowDialog();
        }

        // Initializes WebView2 control with Waze URL
        private void FireStationForm_Load(object sender, EventArgs e)
        {
            // Set up WebView2 control to show Waze map
            webView = new WebView2
            {
                Dock = DockStyle.Fill, // Fills the panel
                Source = new Uri("https://www.waze.com/live-map") // URL for Waze live map
            };

            // Add WebView2 to the panel
            panel5.Controls.Add(webView);
        }

        // Exits the application
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Opens the Vehicles Form when clicked
        private void button3_Click(object sender, EventArgs e)
        {
            var Vehicles = new vehiclesForm();
            Vehicles.ShowDialog();
        }

        // Opens the Teams Form when clicked
        private void button4_Click(object sender, EventArgs e)
        {
            var Teams = new TeamsForm();
            Teams.ShowDialog();
        }

        // Opens the Equipments Form when clicked
        private void button5_Click(object sender, EventArgs e)
        {
            var Eqipements = new EqipementsForm();
            Eqipements.ShowDialog();
        }

        #endregion

        #region Paint Event

        // Placeholder for custom painting (currently unused)
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
