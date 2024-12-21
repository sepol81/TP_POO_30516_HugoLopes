namespace EMS_AP
{
    partial class EventFormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox pictureBox1;
            panel4 = new Panel();
            buttonshearchingEvent = new Button();
            buttonDeleteEvent = new Button();
            buttonSaveEvente = new Button();
            textBoxCodEvent = new TextBox();
            label1 = new Label();
            button2 = new Button();
            buttonShowAllEventes = new Button();
            buttonShowmedicalEventes = new Button();
            dataGridViewEvents = new DataGridView();
            buttonShowCatastrpheEvents = new Button();
            buttonShowFireEvents = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.icons8_evento_64;
            pictureBox1.Location = new Point(101, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Controls.Add(buttonshearchingEvent);
            panel4.Controls.Add(buttonDeleteEvent);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(buttonSaveEvente);
            panel4.Controls.Add(textBoxCodEvent);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(1152, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 900);
            panel4.TabIndex = 22;
            // 
            // buttonshearchingEvent
            // 
            buttonshearchingEvent.BackColor = Color.DarkRed;
            buttonshearchingEvent.FlatAppearance.BorderSize = 0;
            buttonshearchingEvent.FlatStyle = FlatStyle.Flat;
            buttonshearchingEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonshearchingEvent.Location = new Point(2, 555);
            buttonshearchingEvent.Name = "buttonshearchingEvent";
            buttonshearchingEvent.Size = new Size(248, 75);
            buttonshearchingEvent.TabIndex = 29;
            buttonshearchingEvent.Text = "Procurar";
            buttonshearchingEvent.UseVisualStyleBackColor = false;
            buttonshearchingEvent.Click += buttonshearchingEvent_Click;
            // 
            // buttonDeleteEvent
            // 
            buttonDeleteEvent.FlatAppearance.BorderSize = 0;
            buttonDeleteEvent.FlatStyle = FlatStyle.Flat;
            buttonDeleteEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteEvent.Location = new Point(3, 713);
            buttonDeleteEvent.Name = "buttonDeleteEvent";
            buttonDeleteEvent.Size = new Size(248, 75);
            buttonDeleteEvent.TabIndex = 22;
            buttonDeleteEvent.Text = "Eliminar";
            buttonDeleteEvent.UseVisualStyleBackColor = true;
            buttonDeleteEvent.Click += buttonDeleteEvent_Click_1;
            // 
            // buttonSaveEvente
            // 
            buttonSaveEvente.FlatAppearance.BorderSize = 0;
            buttonSaveEvente.FlatStyle = FlatStyle.Flat;
            buttonSaveEvente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveEvente.Location = new Point(2, 634);
            buttonSaveEvente.Name = "buttonSaveEvente";
            buttonSaveEvente.Size = new Size(248, 75);
            buttonSaveEvente.TabIndex = 19;
            buttonSaveEvente.Text = "Gardar";
            buttonSaveEvente.UseVisualStyleBackColor = true;
            buttonSaveEvente.Click += buttonSaveEvente_Click;
            // 
            // textBoxCodEvent
            // 
            textBoxCodEvent.Location = new Point(47, 522);
            textBoxCodEvent.Name = "textBoxCodEvent";
            textBoxCodEvent.Size = new Size(153, 27);
            textBoxCodEvent.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 486);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 24;
            label1.Text = "Codigo da ocorrência";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 792);
            button2.Name = "button2";
            button2.Size = new Size(248, 75);
            button2.TabIndex = 20;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonShowAllEventes
            // 
            buttonShowAllEventes.BackColor = Color.DarkRed;
            buttonShowAllEventes.FlatAppearance.BorderSize = 0;
            buttonShowAllEventes.FlatStyle = FlatStyle.Flat;
            buttonShowAllEventes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowAllEventes.Location = new Point(5, 0);
            buttonShowAllEventes.Name = "buttonShowAllEventes";
            buttonShowAllEventes.Size = new Size(225, 75);
            buttonShowAllEventes.TabIndex = 24;
            buttonShowAllEventes.Text = "Listar todas as ocorrências";
            buttonShowAllEventes.UseVisualStyleBackColor = false;
            buttonShowAllEventes.Click += buttonShowAllEventes_Click;
            // 
            // buttonShowmedicalEventes
            // 
            buttonShowmedicalEventes.BackColor = Color.DarkRed;
            buttonShowmedicalEventes.FlatAppearance.BorderSize = 0;
            buttonShowmedicalEventes.FlatStyle = FlatStyle.Flat;
            buttonShowmedicalEventes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowmedicalEventes.Location = new Point(235, 0);
            buttonShowmedicalEventes.Name = "buttonShowmedicalEventes";
            buttonShowmedicalEventes.Size = new Size(225, 75);
            buttonShowmedicalEventes.TabIndex = 23;
            buttonShowmedicalEventes.Text = "Listar ocorrências Medicas";
            buttonShowmedicalEventes.UseVisualStyleBackColor = false;
            buttonShowmedicalEventes.Click += buttonShowmedicalEventes_Click;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.BackgroundColor = Color.DarkCyan;
            dataGridViewEvents.BorderStyle = BorderStyle.None;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(-4, 197);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.Size = new Size(1156, 703);
            dataGridViewEvents.TabIndex = 23;
            // 
            // buttonShowCatastrpheEvents
            // 
            buttonShowCatastrpheEvents.BackColor = Color.DarkRed;
            buttonShowCatastrpheEvents.FlatAppearance.BorderSize = 0;
            buttonShowCatastrpheEvents.FlatStyle = FlatStyle.Flat;
            buttonShowCatastrpheEvents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowCatastrpheEvents.Location = new Point(694, 0);
            buttonShowCatastrpheEvents.Name = "buttonShowCatastrpheEvents";
            buttonShowCatastrpheEvents.Size = new Size(225, 75);
            buttonShowCatastrpheEvents.TabIndex = 26;
            buttonShowCatastrpheEvents.Text = "Listar ocorrências catástrofe";
            buttonShowCatastrpheEvents.UseVisualStyleBackColor = false;
            buttonShowCatastrpheEvents.Click += buttonShowCatastrpheEvents_Click;
            // 
            // buttonShowFireEvents
            // 
            buttonShowFireEvents.BackColor = Color.DarkRed;
            buttonShowFireEvents.FlatAppearance.BorderSize = 0;
            buttonShowFireEvents.FlatStyle = FlatStyle.Flat;
            buttonShowFireEvents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowFireEvents.Location = new Point(464, 0);
            buttonShowFireEvents.Name = "buttonShowFireEvents";
            buttonShowFireEvents.Size = new Size(225, 75);
            buttonShowFireEvents.TabIndex = 27;
            buttonShowFireEvents.Text = "Listar ocorrências incêndios";
            buttonShowFireEvents.UseVisualStyleBackColor = false;
            buttonShowFireEvents.Click += buttonShowFireEvents_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 75);
            panel1.TabIndex = 28;
            // 
            // EventFormManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1400, 900);
            Controls.Add(buttonShowCatastrpheEvents);
            Controls.Add(buttonShowFireEvents);
            Controls.Add(buttonShowmedicalEventes);
            Controls.Add(buttonShowAllEventes);
            Controls.Add(dataGridViewEvents);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventFormManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventManager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button buttonDeleteEvent;
        private Button buttonSaveEvente;
        private Button button2;
        private Button buttonShowAllEventes;
        private Button buttonShowmedicalEventes;
        private DataGridView dataGridViewEvents;
        private Label label1;
        private TextBox textBoxCodEvent;
        private Button buttonShowCatastrpheEvents;
        private Button buttonShowFireEvents;
        private Panel panel1;
        private Button buttonshearchingEvent;
    }
}