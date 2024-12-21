

namespace EMS_AP
{
    partial class EventForm
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
            Description = new TextBox();
            textBoxAddress = new TextBox();
            comboBoxTypeEvent = new ComboBox();
            comboBoxSeverityLevel = new ComboBox();
            comboBoxStatusEvent = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxDateTimeStart = new TextBox();
            textBoxDateTimeEnd = new TextBox();
            panelMedical = new Panel();
            comboBoxTypeOfEmerency = new ComboBox();
            textBoxNunberOfVictimsMedical = new TextBox();
            label9 = new Label();
            label8 = new Label();
            panelFire = new Panel();
            textBoxFireIntensity = new TextBox();
            textBoxFireAffectedArea = new TextBox();
            label12 = new Label();
            label11 = new Label();
            TypeOfFire = new Label();
            comboBoxTypeOfFire = new ComboBox();
            panelCatastrophe = new Panel();
            textBoxAfectedArea = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            comboBoxTypeOfCatrastophe = new ComboBox();
            textBoxNumberOfVictims = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMedical.SuspendLayout();
            panelFire.SuspendLayout();
            panelCatastrophe.SuspendLayout();
            panel4.SuspendLayout();
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
            // Description
            // 
            Description.Location = new Point(299, 182);
            Description.Name = "Description";
            Description.Size = new Size(599, 27);
            Description.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(299, 250);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(599, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // comboBoxTypeEvent
            // 
            comboBoxTypeEvent.FormattingEnabled = true;
            comboBoxTypeEvent.Location = new Point(299, 120);
            comboBoxTypeEvent.Name = "comboBoxTypeEvent";
            comboBoxTypeEvent.Size = new Size(151, 28);
            comboBoxTypeEvent.TabIndex = 4;
            comboBoxTypeEvent.SelectedIndexChanged += comboBoxTypeEvent_SelectedIndexChanged;
            // 
            // comboBoxSeverityLevel
            // 
            comboBoxSeverityLevel.FormattingEnabled = true;
            comboBoxSeverityLevel.Location = new Point(714, 326);
            comboBoxSeverityLevel.Name = "comboBoxSeverityLevel";
            comboBoxSeverityLevel.Size = new Size(184, 28);
            comboBoxSeverityLevel.TabIndex = 5;
            // 
            // comboBoxStatusEvent
            // 
            comboBoxStatusEvent.FormattingEnabled = true;
            comboBoxStatusEvent.Location = new Point(714, 393);
            comboBoxStatusEvent.Name = "comboBoxStatusEvent";
            comboBoxStatusEvent.Size = new Size(184, 28);
            comboBoxStatusEvent.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 120);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 7;
            label1.Text = "Tipo de Ocorrência";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 182);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 250);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Morada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 326);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 10;
            label4.Text = "Data e hora do ínicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 401);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 11;
            label5.Text = "Data e hora do fim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 334);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 12;
            label6.Text = "Nivel de urgência";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 404);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 13;
            label7.Text = "Estado da ocorrência";
            // 
            // textBoxDateTimeStart
            // 
            textBoxDateTimeStart.Location = new Point(299, 326);
            textBoxDateTimeStart.Name = "textBoxDateTimeStart";
            textBoxDateTimeStart.Size = new Size(210, 27);
            textBoxDateTimeStart.TabIndex = 14;
            // 
            // textBoxDateTimeEnd
            // 
            textBoxDateTimeEnd.Location = new Point(299, 401);
            textBoxDateTimeEnd.Name = "textBoxDateTimeEnd";
            textBoxDateTimeEnd.Size = new Size(210, 27);
            textBoxDateTimeEnd.TabIndex = 15;
            // 
            // panelMedical
            // 
            panelMedical.Controls.Add(comboBoxTypeOfEmerency);
            panelMedical.Controls.Add(textBoxNunberOfVictimsMedical);
            panelMedical.Controls.Add(label9);
            panelMedical.Controls.Add(label8);
            panelMedical.Location = new Point(135, 482);
            panelMedical.Name = "panelMedical";
            panelMedical.Size = new Size(395, 135);
            panelMedical.TabIndex = 16;
            // 
            // comboBoxTypeOfEmerency
            // 
            comboBoxTypeOfEmerency.FormattingEnabled = true;
            comboBoxTypeOfEmerency.Location = new Point(164, 83);
            comboBoxTypeOfEmerency.Name = "comboBoxTypeOfEmerency";
            comboBoxTypeOfEmerency.Size = new Size(210, 28);
            comboBoxTypeOfEmerency.TabIndex = 3;
            // 
            // textBoxNunberOfVictimsMedical
            // 
            textBoxNunberOfVictimsMedical.Location = new Point(164, 7);
            textBoxNunberOfVictimsMedical.Name = "textBoxNunberOfVictimsMedical";
            textBoxNunberOfVictimsMedical.Size = new Size(210, 27);
            textBoxNunberOfVictimsMedical.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 86);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 1;
            label9.Text = "Tipo de emergência";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 10);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 0;
            label8.Text = "Número de vitimas";
            // 
            // panelFire
            // 
            panelFire.Controls.Add(textBoxFireIntensity);
            panelFire.Controls.Add(textBoxFireAffectedArea);
            panelFire.Controls.Add(label12);
            panelFire.Controls.Add(label11);
            panelFire.Controls.Add(TypeOfFire);
            panelFire.Controls.Add(comboBoxTypeOfFire);
            panelFire.Location = new Point(555, 482);
            panelFire.Name = "panelFire";
            panelFire.Size = new Size(395, 210);
            panelFire.TabIndex = 17;
            // 
            // textBoxFireIntensity
            // 
            textBoxFireIntensity.Location = new Point(164, 86);
            textBoxFireIntensity.Name = "textBoxFireIntensity";
            textBoxFireIntensity.Size = new Size(179, 27);
            textBoxFireIntensity.TabIndex = 5;
            // 
            // textBoxFireAffectedArea
            // 
            textBoxFireAffectedArea.Location = new Point(164, 159);
            textBoxFireAffectedArea.Name = "textBoxFireAffectedArea";
            textBoxFireAffectedArea.Size = new Size(179, 27);
            textBoxFireAffectedArea.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 155);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 3;
            label12.Text = "Área afetada";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 86);
            label11.Name = "label11";
            label11.Size = new Size(144, 20);
            label11.TabIndex = 2;
            label11.Text = "Intensidade do fogo";
            // 
            // TypeOfFire
            // 
            TypeOfFire.AutoSize = true;
            TypeOfFire.Location = new Point(0, 18);
            TypeOfFire.Name = "TypeOfFire";
            TypeOfFire.Size = new Size(98, 20);
            TypeOfFire.TabIndex = 1;
            TypeOfFire.Text = "Tipo de Fogo";
            // 
            // comboBoxTypeOfFire
            // 
            comboBoxTypeOfFire.FormattingEnabled = true;
            comboBoxTypeOfFire.Location = new Point(164, 10);
            comboBoxTypeOfFire.Name = "comboBoxTypeOfFire";
            comboBoxTypeOfFire.Size = new Size(179, 28);
            comboBoxTypeOfFire.TabIndex = 0;
            // 
            // panelCatastrophe
            // 
            panelCatastrophe.Controls.Add(textBoxAfectedArea);
            panelCatastrophe.Controls.Add(label14);
            panelCatastrophe.Controls.Add(label13);
            panelCatastrophe.Controls.Add(label10);
            panelCatastrophe.Controls.Add(comboBoxTypeOfCatrastophe);
            panelCatastrophe.Controls.Add(textBoxNumberOfVictims);
            panelCatastrophe.Location = new Point(135, 641);
            panelCatastrophe.Name = "panelCatastrophe";
            panelCatastrophe.Size = new Size(395, 208);
            panelCatastrophe.TabIndex = 18;
            // 
            // textBoxAfectedArea
            // 
            textBoxAfectedArea.Location = new Point(164, 161);
            textBoxAfectedArea.Name = "textBoxAfectedArea";
            textBoxAfectedArea.Size = new Size(210, 27);
            textBoxAfectedArea.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(0, 161);
            label14.Name = "label14";
            label14.Size = new Size(95, 20);
            label14.TabIndex = 8;
            label14.Text = "Área afetada";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 92);
            label13.Name = "label13";
            label13.Size = new Size(139, 20);
            label13.TabIndex = 7;
            label13.Text = "Número de vítimas ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 21);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 6;
            label10.Text = "Tipo de catástrofe";
            // 
            // comboBoxTypeOfCatrastophe
            // 
            comboBoxTypeOfCatrastophe.FormattingEnabled = true;
            comboBoxTypeOfCatrastophe.Location = new Point(164, 21);
            comboBoxTypeOfCatrastophe.Name = "comboBoxTypeOfCatrastophe";
            comboBoxTypeOfCatrastophe.Size = new Size(210, 28);
            comboBoxTypeOfCatrastophe.TabIndex = 5;
            // 
            // textBoxNumberOfVictims
            // 
            textBoxNumberOfVictims.Location = new Point(164, 92);
            textBoxNumberOfVictims.Name = "textBoxNumberOfVictims";
            textBoxNumberOfVictims.Size = new Size(210, 27);
            textBoxNumberOfVictims.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 641);
            button1.Name = "button1";
            button1.Size = new Size(248, 75);
            button1.TabIndex = 19;
            button1.Text = "Gardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 802);
            button2.Name = "button2";
            button2.Size = new Size(248, 75);
            button2.TabIndex = 20;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(1152, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 900);
            panel4.TabIndex = 21;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 722);
            button3.Name = "button3";
            button3.Size = new Size(248, 75);
            button3.TabIndex = 22;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1400, 900);
            Controls.Add(panelCatastrophe);
            Controls.Add(panelFire);
            Controls.Add(panelMedical);
            Controls.Add(textBoxDateTimeEnd);
            Controls.Add(textBoxDateTimeStart);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxStatusEvent);
            Controls.Add(comboBoxSeverityLevel);
            Controls.Add(comboBoxTypeEvent);
            Controls.Add(textBoxAddress);
            Controls.Add(Description);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMedical.ResumeLayout(false);
            panelMedical.PerformLayout();
            panelFire.ResumeLayout(false);
            panelFire.PerformLayout();
            panelCatastrophe.ResumeLayout(false);
            panelCatastrophe.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }







        #endregion

        private TextBox Description;
        private TextBox textBoxAddress;
        private ComboBox comboBoxTypeEvent;
        private ComboBox comboBoxSeverityLevel;
        private ComboBox comboBoxStatusEvent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxDateTimeStart;
        private TextBox textBoxDateTimeEnd;
        private Panel panelMedical;
        private Panel panelFire;
        private Panel panelCatastrophe;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox textBoxNunberOfVictimsMedical;
        private Label label9;
        private Label label8;
        private ComboBox comboBoxTypeOfEmerency;
        private TextBox textBoxFireIntensity;
        private TextBox textBoxFireAffectedArea;
        private Label label12;
        private Label label11;
        private Label TypeOfFire;
        private ComboBox comboBoxTypeOfFire;
        private Label label14;
        private Label label13;
        private Label label10;
        private ComboBox comboBoxTypeOfCatrastophe;
        private TextBox textBoxNumberOfVictims;
        private TextBox textBoxAfectedArea;
        private Button button3;
    }
}