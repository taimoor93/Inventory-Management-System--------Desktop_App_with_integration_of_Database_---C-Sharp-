namespace inventory_management_system
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.admin_form_whole_panel = new System.Windows.Forms.Panel();
            this.dashboard_UserControl = new inventory_management_system.Dashboard_UserControl();
            this.display_Product_UserControl = new inventory_management_system.Display_Product_UserControl();
            this.manage_Product_UserControl = new inventory_management_system.Manage_Product_UserControl();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.admin_product_button = new System.Windows.Forms.Button();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.logo_label = new System.Windows.Forms.Label();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.Admin_form_menu_bar_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.product_dropdown_panel = new System.Windows.Forms.Panel();
            this.manage_product_button = new System.Windows.Forms.Button();
            this.display_button = new System.Windows.Forms.Button();
            this.admin_form_whole_panel.SuspendLayout();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.Admin_form_menu_bar_flowLayoutPanel.SuspendLayout();
            this.product_dropdown_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_form_whole_panel
            // 
            this.admin_form_whole_panel.Controls.Add(this.dashboard_UserControl);
            this.admin_form_whole_panel.Controls.Add(this.display_Product_UserControl);
            this.admin_form_whole_panel.Controls.Add(this.manage_Product_UserControl);
            this.admin_form_whole_panel.Location = new System.Drawing.Point(2, 1);
            this.admin_form_whole_panel.Name = "admin_form_whole_panel";
            this.admin_form_whole_panel.Size = new System.Drawing.Size(1559, 746);
            this.admin_form_whole_panel.TabIndex = 0;
            this.admin_form_whole_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_form_whole_panel_Paint);
            // 
            // dashboard_UserControl
            // 
            this.dashboard_UserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard_UserControl.BackgroundImage")));
            this.dashboard_UserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard_UserControl.Location = new System.Drawing.Point(400, -1);
            this.dashboard_UserControl.Name = "dashboard_UserControl";
            this.dashboard_UserControl.Size = new System.Drawing.Size(1161, 745);
            this.dashboard_UserControl.TabIndex = 2;
            // 
            // display_Product_UserControl
            // 
            this.display_Product_UserControl.Location = new System.Drawing.Point(400, 0);
            this.display_Product_UserControl.Name = "display_Product_UserControl";
            this.display_Product_UserControl.Size = new System.Drawing.Size(1156, 745);
            this.display_Product_UserControl.TabIndex = 1;
            // 
            // manage_Product_UserControl
            // 
            this.manage_Product_UserControl.Location = new System.Drawing.Point(401, 0);
            this.manage_Product_UserControl.Name = "manage_Product_UserControl";
            this.manage_Product_UserControl.Size = new System.Drawing.Size(1169, 745);
            this.manage_Product_UserControl.TabIndex = 0;
            // 
            // dashboard_button
            // 
            this.dashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboard_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboard_button.FlatAppearance.BorderSize = 0;
            this.dashboard_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.dashboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.ForeColor = System.Drawing.Color.White;
            this.dashboard_button.Location = new System.Drawing.Point(3, 96);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(400, 62);
            this.dashboard_button.TabIndex = 4;
            this.dashboard_button.Text = "DASHBOARD";
            this.dashboard_button.UseVisualStyleBackColor = false;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // admin_product_button
            // 
            this.admin_product_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_product_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_product_button.FlatAppearance.BorderSize = 0;
            this.admin_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.admin_product_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_product_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_product_button.ForeColor = System.Drawing.Color.White;
            this.admin_product_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_product_button.Location = new System.Drawing.Point(0, 0);
            this.admin_product_button.Name = "admin_product_button";
            this.admin_product_button.Size = new System.Drawing.Size(404, 62);
            this.admin_product_button.TabIndex = 1;
            this.admin_product_button.Text = "PRODUCT";
            this.admin_product_button.UseVisualStyleBackColor = false;
            this.admin_product_button.Click += new System.EventHandler(this.admin_product_button_Click);
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logo_panel.Controls.Add(this.logo_label);
            this.logo_panel.Controls.Add(this.logo_pictureBox);
            this.logo_panel.Location = new System.Drawing.Point(3, 3);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(400, 87);
            this.logo_panel.TabIndex = 2;
            // 
            // logo_label
            // 
            this.logo_label.AutoSize = true;
            this.logo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_label.ForeColor = System.Drawing.Color.White;
            this.logo_label.Location = new System.Drawing.Point(79, 32);
            this.logo_label.Name = "logo_label";
            this.logo_label.Size = new System.Drawing.Size(296, 18);
            this.logo_label.TabIndex = 1;
            this.logo_label.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Image = global::inventory_management_system.Properties.Resources.logo;
            this.logo_pictureBox.Location = new System.Drawing.Point(1, 0);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(96, 85);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pictureBox.TabIndex = 0;
            this.logo_pictureBox.TabStop = false;
            // 
            // Admin_form_menu_bar_flowLayoutPanel
            // 
            this.Admin_form_menu_bar_flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Admin_form_menu_bar_flowLayoutPanel.Controls.Add(this.logo_panel);
            this.Admin_form_menu_bar_flowLayoutPanel.Controls.Add(this.dashboard_button);
            this.Admin_form_menu_bar_flowLayoutPanel.Controls.Add(this.product_dropdown_panel);
            this.Admin_form_menu_bar_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Admin_form_menu_bar_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Admin_form_menu_bar_flowLayoutPanel.Name = "Admin_form_menu_bar_flowLayoutPanel";
            this.Admin_form_menu_bar_flowLayoutPanel.Size = new System.Drawing.Size(404, 746);
            this.Admin_form_menu_bar_flowLayoutPanel.TabIndex = 1;
            // 
            // product_dropdown_panel
            // 
            this.product_dropdown_panel.Controls.Add(this.manage_product_button);
            this.product_dropdown_panel.Controls.Add(this.display_button);
            this.product_dropdown_panel.Controls.Add(this.admin_product_button);
            this.product_dropdown_panel.Location = new System.Drawing.Point(3, 164);
            this.product_dropdown_panel.MaximumSize = new System.Drawing.Size(404, 190);
            this.product_dropdown_panel.MinimumSize = new System.Drawing.Size(404, 62);
            this.product_dropdown_panel.Name = "product_dropdown_panel";
            this.product_dropdown_panel.Size = new System.Drawing.Size(404, 62);
            this.product_dropdown_panel.TabIndex = 8;
            // 
            // manage_product_button
            // 
            this.manage_product_button.BackColor = System.Drawing.Color.Gray;
            this.manage_product_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manage_product_button.FlatAppearance.BorderSize = 0;
            this.manage_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.manage_product_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_product_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_product_button.ForeColor = System.Drawing.Color.White;
            this.manage_product_button.Location = new System.Drawing.Point(-4, 122);
            this.manage_product_button.Name = "manage_product_button";
            this.manage_product_button.Size = new System.Drawing.Size(404, 62);
            this.manage_product_button.TabIndex = 9;
            this.manage_product_button.Text = "MANAGE";
            this.manage_product_button.UseVisualStyleBackColor = false;
            this.manage_product_button.Click += new System.EventHandler(this.manage_product_button_Click);
            // 
            // display_button
            // 
            this.display_button.BackColor = System.Drawing.Color.Gray;
            this.display_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.display_button.FlatAppearance.BorderSize = 0;
            this.display_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_button.ForeColor = System.Drawing.Color.White;
            this.display_button.Location = new System.Drawing.Point(-4, 62);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(404, 62);
            this.display_button.TabIndex = 9;
            this.display_button.Text = "DISPLAY";
            this.display_button.UseVisualStyleBackColor = false;
            this.display_button.Click += new System.EventHandler(this.display_button_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 746);
            this.Controls.Add(this.Admin_form_menu_bar_flowLayoutPanel);
            this.Controls.Add(this.admin_form_whole_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.admin_form_whole_panel.ResumeLayout(false);
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.Admin_form_menu_bar_flowLayoutPanel.ResumeLayout(false);
            this.product_dropdown_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admin_form_whole_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button admin_product_button;
        private System.Windows.Forms.FlowLayoutPanel Admin_form_menu_bar_flowLayoutPanel;
        private System.Windows.Forms.Button manage_product_button;
        private System.Windows.Forms.Panel product_dropdown_panel;
        private System.Windows.Forms.Button display_button;
        private Manage_Product_UserControl manage_Product_UserControl;
        private Display_Product_UserControl display_Product_UserControl;
        private Dashboard_UserControl dashboard_UserControl;
    }
}