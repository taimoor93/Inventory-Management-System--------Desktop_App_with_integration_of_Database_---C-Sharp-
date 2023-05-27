namespace inventory_management_system
{
    partial class Login_Form
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
            this.login_form_whole_panel = new System.Windows.Forms.Panel();
            this.login_form_login_button = new System.Windows.Forms.Button();
            this.login_form_password_textBox = new System.Windows.Forms.TextBox();
            this.login_form_username_textBox = new System.Windows.Forms.TextBox();
            this.login_form_password_label = new System.Windows.Forms.Label();
            this.login_form_username_label = new System.Windows.Forms.Label();
            this.login_logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.admin_form_exit_button = new System.Windows.Forms.Button();
            this.login_form_upper_panel = new System.Windows.Forms.Panel();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.logo_label = new System.Windows.Forms.Label();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.login_form_whole_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo_pictureBox)).BeginInit();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // login_form_whole_panel
            // 
            this.login_form_whole_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_form_whole_panel.Controls.Add(this.login_form_login_button);
            this.login_form_whole_panel.Controls.Add(this.login_form_password_textBox);
            this.login_form_whole_panel.Controls.Add(this.login_form_username_textBox);
            this.login_form_whole_panel.Controls.Add(this.login_form_password_label);
            this.login_form_whole_panel.Controls.Add(this.login_form_username_label);
            this.login_form_whole_panel.Controls.Add(this.login_logo_pictureBox);
            this.login_form_whole_panel.Controls.Add(this.admin_form_exit_button);
            this.login_form_whole_panel.Controls.Add(this.login_form_upper_panel);
            this.login_form_whole_panel.Controls.Add(this.logo_panel);
            this.login_form_whole_panel.Location = new System.Drawing.Point(0, 0);
            this.login_form_whole_panel.Name = "login_form_whole_panel";
            this.login_form_whole_panel.Size = new System.Drawing.Size(942, 573);
            this.login_form_whole_panel.TabIndex = 0;
            // 
            // login_form_login_button
            // 
            this.login_form_login_button.BackColor = System.Drawing.Color.Teal;
            this.login_form_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_form_login_button.ForeColor = System.Drawing.Color.White;
            this.login_form_login_button.Location = new System.Drawing.Point(502, 432);
            this.login_form_login_button.Name = "login_form_login_button";
            this.login_form_login_button.Size = new System.Drawing.Size(198, 32);
            this.login_form_login_button.TabIndex = 16;
            this.login_form_login_button.Text = "LOGIN";
            this.login_form_login_button.UseVisualStyleBackColor = false;
            this.login_form_login_button.Click += new System.EventHandler(this.login_form_login_button_Click);
            // 
            // login_form_password_textBox
            // 
            this.login_form_password_textBox.Location = new System.Drawing.Point(555, 345);
            this.login_form_password_textBox.Name = "login_form_password_textBox";
            this.login_form_password_textBox.Size = new System.Drawing.Size(276, 22);
            this.login_form_password_textBox.TabIndex = 15;
            this.login_form_password_textBox.UseSystemPasswordChar = true;
            // 
            // login_form_username_textBox
            // 
            this.login_form_username_textBox.Location = new System.Drawing.Point(555, 270);
            this.login_form_username_textBox.Name = "login_form_username_textBox";
            this.login_form_username_textBox.Size = new System.Drawing.Size(276, 22);
            this.login_form_username_textBox.TabIndex = 14;
            // 
            // login_form_password_label
            // 
            this.login_form_password_label.AutoSize = true;
            this.login_form_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_form_password_label.ForeColor = System.Drawing.Color.White;
            this.login_form_password_label.Location = new System.Drawing.Point(418, 347);
            this.login_form_password_label.Name = "login_form_password_label";
            this.login_form_password_label.Size = new System.Drawing.Size(107, 20);
            this.login_form_password_label.TabIndex = 13;
            this.login_form_password_label.Text = "PASSWORD";
            // 
            // login_form_username_label
            // 
            this.login_form_username_label.AutoSize = true;
            this.login_form_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_form_username_label.ForeColor = System.Drawing.Color.White;
            this.login_form_username_label.Location = new System.Drawing.Point(418, 272);
            this.login_form_username_label.Name = "login_form_username_label";
            this.login_form_username_label.Size = new System.Drawing.Size(103, 20);
            this.login_form_username_label.TabIndex = 12;
            this.login_form_username_label.Text = "USERNAME";
            // 
            // login_logo_pictureBox
            // 
            this.login_logo_pictureBox.Image = global::inventory_management_system.Properties.Resources.login;
            this.login_logo_pictureBox.Location = new System.Drawing.Point(79, 205);
            this.login_logo_pictureBox.Name = "login_logo_pictureBox";
            this.login_logo_pictureBox.Size = new System.Drawing.Size(266, 273);
            this.login_logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_logo_pictureBox.TabIndex = 11;
            this.login_logo_pictureBox.TabStop = false;
            // 
            // admin_form_exit_button
            // 
            this.admin_form_exit_button.BackColor = System.Drawing.Color.Red;
            this.admin_form_exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.admin_form_exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.admin_form_exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_form_exit_button.ForeColor = System.Drawing.Color.White;
            this.admin_form_exit_button.Location = new System.Drawing.Point(920, 13);
            this.admin_form_exit_button.Name = "admin_form_exit_button";
            this.admin_form_exit_button.Size = new System.Drawing.Size(22, 23);
            this.admin_form_exit_button.TabIndex = 10;
            this.admin_form_exit_button.Text = "X";
            this.admin_form_exit_button.UseVisualStyleBackColor = false;
            this.admin_form_exit_button.Click += new System.EventHandler(this.admin_form_exit_button_Click);
            // 
            // login_form_upper_panel
            // 
            this.login_form_upper_panel.BackColor = System.Drawing.Color.Teal;
            this.login_form_upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_form_upper_panel.Location = new System.Drawing.Point(0, 0);
            this.login_form_upper_panel.Name = "login_form_upper_panel";
            this.login_form_upper_panel.Size = new System.Drawing.Size(942, 12);
            this.login_form_upper_panel.TabIndex = 4;
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logo_panel.Controls.Add(this.logo_label);
            this.logo_panel.Controls.Add(this.logo_pictureBox);
            this.logo_panel.Location = new System.Drawing.Point(3, 13);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(603, 103);
            this.logo_panel.TabIndex = 3;
            // 
            // logo_label
            // 
            this.logo_label.AutoSize = true;
            this.logo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_label.ForeColor = System.Drawing.Color.White;
            this.logo_label.Location = new System.Drawing.Point(114, 36);
            this.logo_label.Name = "logo_label";
            this.logo_label.Size = new System.Drawing.Size(465, 29);
            this.logo_label.TabIndex = 1;
            this.logo_label.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Image = global::inventory_management_system.Properties.Resources.logo;
            this.logo_pictureBox.Location = new System.Drawing.Point(2, 0);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(129, 103);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pictureBox.TabIndex = 0;
            this.logo_pictureBox.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 573);
            this.Controls.Add(this.login_form_whole_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.login_form_whole_panel.ResumeLayout(false);
            this.login_form_whole_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo_pictureBox)).EndInit();
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_form_whole_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Panel login_form_upper_panel;
        private System.Windows.Forms.Button admin_form_exit_button;
        private System.Windows.Forms.PictureBox login_logo_pictureBox;
        private System.Windows.Forms.TextBox login_form_password_textBox;
        private System.Windows.Forms.TextBox login_form_username_textBox;
        private System.Windows.Forms.Label login_form_password_label;
        private System.Windows.Forms.Label login_form_username_label;
        private System.Windows.Forms.Button login_form_login_button;
    }
}