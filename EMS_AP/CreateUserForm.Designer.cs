namespace EMS_AP
{
    partial class CreateUserForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCreateUser = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            EMS = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(1, 215);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Digite o user name";
            txtUsername.Size = new Size(418, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Digite a password";
            txtPassword.Size = new Size(418, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCreateUser
            // 
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Location = new Point(1, 345);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(418, 65);
            btnCreateUser.TabIndex = 2;
            btnCreateUser.Text = "Criar";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(1, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(418, 65);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Location = new Point(-1, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 56);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(419, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 616);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(96, 177);
            label1.Name = "label1";
            label1.Size = new Size(228, 17);
            label1.TabIndex = 10;
            label1.Text = "EMERGENCY MANAGEMENT SYSTEM";
            // 
            // EMS
            // 
            EMS.AutoSize = true;
            EMS.Font = new Font("MS Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMS.ForeColor = Color.DarkRed;
            EMS.Location = new Point(156, 117);
            EMS.Name = "EMS";
            EMS.Size = new Size(95, 47);
            EMS.TabIndex = 9;
            EMS.Text = "EMS";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(478, 612);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(EMS);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnCreateUser;
        private Button btnCancel;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label EMS;
    }
}
