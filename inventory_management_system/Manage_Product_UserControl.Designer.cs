namespace inventory_management_system
{
    partial class Manage_Product_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.admin_product_panel = new System.Windows.Forms.Panel();
            this.admin_form_product_search_button = new System.Windows.Forms.Button();
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.rate_textBox = new System.Windows.Forms.TextBox();
            this.admin_product_delete_button = new System.Windows.Forms.Button();
            this.admin_product_search_textBox = new System.Windows.Forms.TextBox();
            this.rate_label = new System.Windows.Forms.Label();
            this.admin_product_update_button = new System.Windows.Forms.Button();
            this.brand_name_textBox = new System.Windows.Forms.TextBox();
            this.admin_product_search_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.product_name_textBox = new System.Windows.Forms.TextBox();
            this.admin_product_logo_panel = new System.Windows.Forms.Panel();
            this.admin_product_logo_label = new System.Windows.Forms.Label();
            this.brand_name_label = new System.Windows.Forms.Label();
            this.bar_code_textBox = new System.Windows.Forms.TextBox();
            this.admin_product_dataGridView = new System.Windows.Forms.DataGridView();
            this.product_name_label = new System.Windows.Forms.Label();
            this.admin_product_add_button = new System.Windows.Forms.Button();
            this.bar_code_label = new System.Windows.Forms.Label();
            this.admin_form_exit_button = new System.Windows.Forms.Button();
            this.admin_product_panel.SuspendLayout();
            this.admin_product_logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_product_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_product_panel
            // 
            this.admin_product_panel.BackColor = System.Drawing.SystemColors.Control;
            this.admin_product_panel.Controls.Add(this.admin_form_product_search_button);
            this.admin_product_panel.Controls.Add(this.quantity_textBox);
            this.admin_product_panel.Controls.Add(this.rate_textBox);
            this.admin_product_panel.Controls.Add(this.admin_product_delete_button);
            this.admin_product_panel.Controls.Add(this.admin_product_search_textBox);
            this.admin_product_panel.Controls.Add(this.rate_label);
            this.admin_product_panel.Controls.Add(this.admin_product_update_button);
            this.admin_product_panel.Controls.Add(this.brand_name_textBox);
            this.admin_product_panel.Controls.Add(this.admin_product_search_label);
            this.admin_product_panel.Controls.Add(this.quantity_label);
            this.admin_product_panel.Controls.Add(this.product_name_textBox);
            this.admin_product_panel.Controls.Add(this.admin_product_logo_panel);
            this.admin_product_panel.Controls.Add(this.brand_name_label);
            this.admin_product_panel.Controls.Add(this.bar_code_textBox);
            this.admin_product_panel.Controls.Add(this.admin_product_dataGridView);
            this.admin_product_panel.Controls.Add(this.product_name_label);
            this.admin_product_panel.Controls.Add(this.admin_product_add_button);
            this.admin_product_panel.Controls.Add(this.bar_code_label);
            this.admin_product_panel.Location = new System.Drawing.Point(0, 0);
            this.admin_product_panel.Name = "admin_product_panel";
            this.admin_product_panel.Size = new System.Drawing.Size(1161, 745);
            this.admin_product_panel.TabIndex = 1;
            this.admin_product_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_product_panel_Paint);
            // 
            // admin_form_product_search_button
            // 
            this.admin_form_product_search_button.Location = new System.Drawing.Point(1028, 109);
            this.admin_form_product_search_button.Name = "admin_form_product_search_button";
            this.admin_form_product_search_button.Size = new System.Drawing.Size(29, 22);
            this.admin_form_product_search_button.TabIndex = 15;
            this.admin_form_product_search_button.UseVisualStyleBackColor = true;
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.Location = new System.Drawing.Point(130, 419);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(244, 22);
            this.quantity_textBox.TabIndex = 14;
            // 
            // rate_textBox
            // 
            this.rate_textBox.Location = new System.Drawing.Point(130, 472);
            this.rate_textBox.Name = "rate_textBox";
            this.rate_textBox.Size = new System.Drawing.Size(244, 22);
            this.rate_textBox.TabIndex = 12;
            // 
            // admin_product_delete_button
            // 
            this.admin_product_delete_button.BackColor = System.Drawing.Color.Teal;
            this.admin_product_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_product_delete_button.ForeColor = System.Drawing.Color.White;
            this.admin_product_delete_button.Location = new System.Drawing.Point(252, 565);
            this.admin_product_delete_button.Name = "admin_product_delete_button";
            this.admin_product_delete_button.Size = new System.Drawing.Size(117, 32);
            this.admin_product_delete_button.TabIndex = 5;
            this.admin_product_delete_button.Text = "DELETE";
            this.admin_product_delete_button.UseVisualStyleBackColor = false;
            this.admin_product_delete_button.Click += new System.EventHandler(this.admin_product_delete_button_Click);
            // 
            // admin_product_search_textBox
            // 
            this.admin_product_search_textBox.Location = new System.Drawing.Point(645, 109);
            this.admin_product_search_textBox.Name = "admin_product_search_textBox";
            this.admin_product_search_textBox.Size = new System.Drawing.Size(377, 22);
            this.admin_product_search_textBox.TabIndex = 2;
            // 
            // rate_label
            // 
            this.rate_label.AutoSize = true;
            this.rate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_label.Location = new System.Drawing.Point(6, 477);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(45, 17);
            this.rate_label.TabIndex = 5;
            this.rate_label.Text = "RATE";
            // 
            // admin_product_update_button
            // 
            this.admin_product_update_button.BackColor = System.Drawing.Color.Teal;
            this.admin_product_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_product_update_button.ForeColor = System.Drawing.Color.White;
            this.admin_product_update_button.Location = new System.Drawing.Point(136, 565);
            this.admin_product_update_button.Name = "admin_product_update_button";
            this.admin_product_update_button.Size = new System.Drawing.Size(110, 32);
            this.admin_product_update_button.TabIndex = 6;
            this.admin_product_update_button.Text = "UPDATE";
            this.admin_product_update_button.UseVisualStyleBackColor = false;
            this.admin_product_update_button.Click += new System.EventHandler(this.admin_product_update_button_Click);
            // 
            // brand_name_textBox
            // 
            this.brand_name_textBox.Location = new System.Drawing.Point(130, 365);
            this.brand_name_textBox.Name = "brand_name_textBox";
            this.brand_name_textBox.Size = new System.Drawing.Size(244, 22);
            this.brand_name_textBox.TabIndex = 11;
            // 
            // admin_product_search_label
            // 
            this.admin_product_search_label.AutoSize = true;
            this.admin_product_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_product_search_label.Location = new System.Drawing.Point(553, 113);
            this.admin_product_search_label.Name = "admin_product_search_label";
            this.admin_product_search_label.Size = new System.Drawing.Size(70, 18);
            this.admin_product_search_label.TabIndex = 1;
            this.admin_product_search_label.Text = "SEARCH";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.Location = new System.Drawing.Point(6, 424);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(78, 17);
            this.quantity_label.TabIndex = 4;
            this.quantity_label.Text = "QUANTITY";
            // 
            // product_name_textBox
            // 
            this.product_name_textBox.Location = new System.Drawing.Point(130, 315);
            this.product_name_textBox.Name = "product_name_textBox";
            this.product_name_textBox.Size = new System.Drawing.Size(244, 22);
            this.product_name_textBox.TabIndex = 10;
            // 
            // admin_product_logo_panel
            // 
            this.admin_product_logo_panel.BackColor = System.Drawing.Color.Teal;
            this.admin_product_logo_panel.Controls.Add(this.admin_form_exit_button);
            this.admin_product_logo_panel.Controls.Add(this.admin_product_logo_label);
            this.admin_product_logo_panel.Location = new System.Drawing.Point(0, -2);
            this.admin_product_logo_panel.Name = "admin_product_logo_panel";
            this.admin_product_logo_panel.Size = new System.Drawing.Size(1161, 90);
            this.admin_product_logo_panel.TabIndex = 0;
            // 
            // admin_product_logo_label
            // 
            this.admin_product_logo_label.AutoSize = true;
            this.admin_product_logo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_product_logo_label.ForeColor = System.Drawing.Color.White;
            this.admin_product_logo_label.Location = new System.Drawing.Point(22, 33);
            this.admin_product_logo_label.Name = "admin_product_logo_label";
            this.admin_product_logo_label.Size = new System.Drawing.Size(207, 20);
            this.admin_product_logo_label.TabIndex = 0;
            this.admin_product_logo_label.Text = "PRODUCT -> MANAGE";
            // 
            // brand_name_label
            // 
            this.brand_name_label.AutoSize = true;
            this.brand_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_name_label.Location = new System.Drawing.Point(3, 370);
            this.brand_name_label.Name = "brand_name_label";
            this.brand_name_label.Size = new System.Drawing.Size(99, 17);
            this.brand_name_label.TabIndex = 3;
            this.brand_name_label.Text = "BRAND NAME";
            // 
            // bar_code_textBox
            // 
            this.bar_code_textBox.Location = new System.Drawing.Point(130, 265);
            this.bar_code_textBox.Name = "bar_code_textBox";
            this.bar_code_textBox.Size = new System.Drawing.Size(244, 22);
            this.bar_code_textBox.TabIndex = 9;
            // 
            // admin_product_dataGridView
            // 
            this.admin_product_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_product_dataGridView.Location = new System.Drawing.Point(381, 156);
            this.admin_product_dataGridView.Name = "admin_product_dataGridView";
            this.admin_product_dataGridView.RowTemplate.Height = 24;
            this.admin_product_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.admin_product_dataGridView.Size = new System.Drawing.Size(763, 563);
            this.admin_product_dataGridView.TabIndex = 3;
            this.admin_product_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_product_dataGridView_CellContentClick);
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_label.Location = new System.Drawing.Point(6, 320);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(119, 17);
            this.product_name_label.TabIndex = 2;
            this.product_name_label.Text = "PRODUCT NAME";
            // 
            // admin_product_add_button
            // 
            this.admin_product_add_button.BackColor = System.Drawing.Color.Teal;
            this.admin_product_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_product_add_button.ForeColor = System.Drawing.Color.White;
            this.admin_product_add_button.Location = new System.Drawing.Point(9, 565);
            this.admin_product_add_button.Name = "admin_product_add_button";
            this.admin_product_add_button.Size = new System.Drawing.Size(121, 32);
            this.admin_product_add_button.TabIndex = 4;
            this.admin_product_add_button.Text = "INSERT";
            this.admin_product_add_button.UseVisualStyleBackColor = false;
            this.admin_product_add_button.Click += new System.EventHandler(this.admin_product_add_button_Click);
            // 
            // bar_code_label
            // 
            this.bar_code_label.AutoSize = true;
            this.bar_code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_code_label.Location = new System.Drawing.Point(6, 270);
            this.bar_code_label.Name = "bar_code_label";
            this.bar_code_label.Size = new System.Drawing.Size(79, 17);
            this.bar_code_label.TabIndex = 1;
            this.bar_code_label.Text = "BAR CODE";
            // 
            // admin_form_exit_button
            // 
            this.admin_form_exit_button.BackColor = System.Drawing.Color.Red;
            this.admin_form_exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.admin_form_exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.admin_form_exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_form_exit_button.ForeColor = System.Drawing.Color.White;
            this.admin_form_exit_button.Location = new System.Drawing.Point(1131, 3);
            this.admin_form_exit_button.Name = "admin_form_exit_button";
            this.admin_form_exit_button.Size = new System.Drawing.Size(22, 23);
            this.admin_form_exit_button.TabIndex = 11;
            this.admin_form_exit_button.Text = "X";
            this.admin_form_exit_button.UseVisualStyleBackColor = false;
            this.admin_form_exit_button.Click += new System.EventHandler(this.admin_form_exit_button_Click);
            // 
            // Manage_Product_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.admin_product_panel);
            this.Name = "Manage_Product_UserControl";
            this.Size = new System.Drawing.Size(1161, 745);
            this.admin_product_panel.ResumeLayout(false);
            this.admin_product_panel.PerformLayout();
            this.admin_product_logo_panel.ResumeLayout(false);
            this.admin_product_logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_product_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admin_product_panel;
        private System.Windows.Forms.Button admin_form_product_search_button;
        private System.Windows.Forms.TextBox quantity_textBox;
        private System.Windows.Forms.TextBox rate_textBox;
        private System.Windows.Forms.Button admin_product_delete_button;
        private System.Windows.Forms.TextBox admin_product_search_textBox;
        private System.Windows.Forms.Label rate_label;
        private System.Windows.Forms.Button admin_product_update_button;
        private System.Windows.Forms.TextBox brand_name_textBox;
        private System.Windows.Forms.Label admin_product_search_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox product_name_textBox;
        private System.Windows.Forms.Panel admin_product_logo_panel;
        private System.Windows.Forms.Label admin_product_logo_label;
        private System.Windows.Forms.Label brand_name_label;
        private System.Windows.Forms.TextBox bar_code_textBox;
        private System.Windows.Forms.DataGridView admin_product_dataGridView;
        private System.Windows.Forms.Label product_name_label;
        private System.Windows.Forms.Button admin_product_add_button;
        private System.Windows.Forms.Label bar_code_label;
        private System.Windows.Forms.Button admin_form_exit_button;
    }
}
