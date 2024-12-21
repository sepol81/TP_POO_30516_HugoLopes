namespace EMS_AP
{
    partial class FireStationForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireStationForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Exit_button = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            EMS = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(5, 198);
            button1.Name = "button1";
            button1.Size = new Size(248, 74);
            button1.TabIndex = 0;
            button1.Text = "Ocorrências";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(5, 278);
            button2.Name = "button2";
            button2.Size = new Size(248, 75);
            button2.TabIndex = 1;
            button2.Text = "Profissionais";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(4, 359);
            button3.Name = "button3";
            button3.Size = new Size(248, 75);
            button3.TabIndex = 2;
            button3.Text = "Viaturas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.icons8_equipo_32;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 440);
            button4.Name = "button4";
            button4.Size = new Size(248, 75);
            button4.TabIndex = 3;
            button4.Text = "Equipas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 520);
            button5.Name = "button5";
            button5.Size = new Size(248, 75);
            button5.TabIndex = 4;
            button5.Text = "Equipamentos";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.DarkRed;
            Exit_button.FlatAppearance.BorderSize = 0;
            Exit_button.FlatStyle = FlatStyle.Flat;
            Exit_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit_button.ForeColor = Color.Black;
            Exit_button.Image = Properties.Resources.icons8_apagar_32;
            Exit_button.ImageAlign = ContentAlignment.MiddleLeft;
            Exit_button.Location = new Point(-2, 609);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(247, 74);
            Exit_button.TabIndex = 5;
            Exit_button.Text = "Sair";
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += button6_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(1, 244);
            button6.Name = "button6";
            button6.Size = new Size(248, 74);
            button6.TabIndex = 9;
            button6.Text = "Equipamento disponiveis";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(248, 74);
            button7.TabIndex = 10;
            button7.Text = "Ocorrências a decorrer";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(-2, 81);
            button8.Name = "button8";
            button8.Size = new Size(248, 74);
            button8.TabIndex = 11;
            button8.Text = "Profissionais disponiveis";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(1, 162);
            button9.Name = "button9";
            button9.Size = new Size(248, 74);
            button9.TabIndex = 12;
            button9.Text = "Viaturas disponiveis";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(1, 324);
            button10.Name = "button10";
            button10.Size = new Size(248, 74);
            button10.TabIndex = 13;
            button10.Text = "Equipas disponiveis";
            button10.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(EMS);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 1234);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1404, 92);
            panel2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(228, 17);
            label1.TabIndex = 6;
            label1.Text = "EMERGENCY MANAGEMENT SYSTEM";
            // 
            // EMS
            // 
            EMS.AutoSize = true;
            EMS.Font = new Font("MS Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMS.ForeColor = Color.DarkRed;
            EMS.Location = new Point(72, 111);
            EMS.Name = "EMS";
            EMS.Size = new Size(95, 47);
            EMS.TabIndex = 5;
            EMS.Text = "EMS";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(259, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(1145, 99);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.DarkRed;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(Exit_button);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button9);
            panel4.Location = new Point(1156, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 1129);
            panel4.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.Location = new Point(259, 186);
            panel5.Name = "panel5";
            panel5.Size = new Size(898, 714);
            panel5.TabIndex = 20;
            panel5.Paint += panel5_Paint;
            // 
            // FireStationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FireStationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FireStationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button Exit_button;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label EMS;
        private Label label1;
    }
}
