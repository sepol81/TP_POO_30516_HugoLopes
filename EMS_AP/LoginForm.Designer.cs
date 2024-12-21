namespace EMS_AP
{
    partial class LoginForm
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
            txt_password = new TextBox();
            txt_name = new TextBox();
            Button_Cancel = new Button();
            Button_Login = new Button();
            Button_CreateUser = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            EMS = new Label();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(1, 266);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Digite a Password";
            txt_password.Size = new Size(418, 27);
            txt_password.TabIndex = 3;
            txt_password.TextAlign = HorizontalAlignment.Center;
            txt_password.UseSystemPasswordChar = true;
            txt_password.Enter += txt_password_Enter;
            txt_password.Leave += txt_password_Leave;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(1, 215);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Digite o User Name";
            txt_name.Size = new Size(418, 27);
            txt_name.TabIndex = 2;
            txt_name.TextAlign = HorizontalAlignment.Center;
            txt_name.Enter += txt_name_Enter;
            txt_name.Leave += txt_name_Leave;
            // 
            // Button_Cancel
            // 
            Button_Cancel.BackColor = Color.Transparent;
            Button_Cancel.FlatAppearance.BorderSize = 0;
            Button_Cancel.FlatStyle = FlatStyle.Flat;
            Button_Cancel.Location = new Point(1, 414);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(418, 65);
            Button_Cancel.TabIndex = 1;
            Button_Cancel.Text = "Cancelar";
            Button_Cancel.UseVisualStyleBackColor = false;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.Transparent;
            Button_Login.FlatAppearance.BorderSize = 0;
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Location = new Point(1, 345);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(418, 65);
            Button_Login.TabIndex = 0;
            Button_Login.Text = "Entrar";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += Button_Login_Click;
            // 
            // Button_CreateUser
            // 
            Button_CreateUser.BackColor = Color.Transparent;
            Button_CreateUser.FlatAppearance.BorderSize = 0;
            Button_CreateUser.FlatStyle = FlatStyle.Flat;
            Button_CreateUser.Location = new Point(1, 483);
            Button_CreateUser.Name = "Button_CreateUser";
            Button_CreateUser.Size = new Size(418, 65);
            Button_CreateUser.TabIndex = 4;
            Button_CreateUser.Text = "Novo Utilizador";
            Button_CreateUser.UseVisualStyleBackColor = false;
            Button_CreateUser.Click += Button_CreateUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(419, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 616);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Location = new Point(-1, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 56);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(102, 177);
            label1.Name = "label1";
            label1.Size = new Size(228, 17);
            label1.TabIndex = 8;
            label1.Text = "EMERGENCY MANAGEMENT SYSTEM";
            // 
            // EMS
            // 
            EMS.AutoSize = true;
            EMS.Font = new Font("MS Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMS.ForeColor = Color.DarkRed;
            EMS.Location = new Point(162, 117);
            EMS.Name = "EMS";
            EMS.Size = new Size(95, 47);
            EMS.TabIndex = 7;
            EMS.Text = "EMS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(478, 612);
            Controls.Add(label1);
            Controls.Add(EMS);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Button_CreateUser);
            Controls.Add(Button_Cancel);
            Controls.Add(txt_password);
            Controls.Add(Button_Login);
            Controls.Add(txt_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_password;
        private TextBox txt_name;
        private Button Button_Cancel;
        private Button Button_Login;
        private Button Button_CreateUser;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label EMS;
    }
}