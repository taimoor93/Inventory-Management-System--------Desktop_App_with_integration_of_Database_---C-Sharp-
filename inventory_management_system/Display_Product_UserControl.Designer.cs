namespace inventory_management_system
{
    partial class Display_Product_UserControl
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
            this.display_product_panel = new System.Windows.Forms.Panel();
            this.admin_form_product_search_button = new System.Windows.Forms.Button();
            this.admin_product_search_textBox = new System.Windows.Forms.TextBox();
            this.admin_product_search_label = new System.Windows.Forms.Label();
            this.admin_product_logo_panel = new System.Windows.Forms.Panel();
            this.admin_form_exit_button = new System.Windows.Forms.Button();
            this.admin_product_logo_label = new System.Windows.Forms.Label();
            this.admin_product_dataGridView = new System.Windows.Forms.DataGridView();
            this.display_product_panel.SuspendLayout();
            this.admin_product_logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_product_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // display_product_panel
            // 
            this.display_product_panel.BackColor = System.Drawing.SystemColors.Control;
            this.display_product_panel.Controls.Add(this.admin_form_product_search_button);
            this.display_product_panel.Controls.Add(this.admin_product_search_textBox);
            this.display_product_panel.Controls.Add(this.admin_product_search_label);
            this.display_product_panel.Controls.Add(this.admin_product_logo_panel);
            this.display_product_panel.Controls.Add(this.admin_product_dataGridView);
            this.display_product_panel.Location = new System.Drawing.Point(0, 0);
            this.display_product_panel.Name = "display_product_panel";
            this.display_product_panel.Size = new System.Drawing.Size(1161, 745);
            this.display_product_panel.TabIndex = 2;
            this.display_product_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.display_product_panel_Paint);
            // 
            // admin_form_product_search_button
            // 
            this.admin_form_product_search_button.Location = new System.Drawing.Point(809, 109);
            this.admin_form_product_search_button.Name = "admin_form_product_search_button";
            this.admin_form_product_search_button.Size = new System.Drawing.Size(29, 22);
            this.admin_form_product_search_button.TabIndex = 15;
            this.admin_form_product_search_button.UseVisualStyleBackColor = true;
            this.admin_form_product_search_button.Click += new System.EventHandler(this.admin_form_product_search_button_Click);
            // 
            // admin_product_search_textBox
            // 
            this.admin_product_search_textBox.Location = new System.Drawing.Point(416, 109);
            this.admin_product_search_textBox.Name = "admin_product_search_textBox";
            this.admin_product_search_textBox.Size = new System.Drawing.Size(377, 22);
            this.admin_product_search_textBox.TabIndex = 2;
            this.admin_product_search_textBox.TextChanged += new System.EventHandler(this.admin_product_search_textBox_TextChanged);
            // 
            // admin_product_search_label
            // 
            this.admin_product_search_label.AutoSize = true;
            this.admin_product_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_product_search_label.Location = new System.Drawing.Point(329, 113);
            this.admin_product_search_label.Name = "admin_product_search_label";
            this.admin_product_search_label.Size = new System.Drawing.Size(70, 18);
            this.admin_product_search_label.TabIndex = 1;
            this.admin_product_search_label.Text = "SEARCH";
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
            // admin_product_logo_label
            // 
            this.admin_product_logo_label.AutoSize = true;
            this.admin_product_logo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_product_logo_label.ForeColor = System.Drawing.Color.White;
            this.admin_product_logo_label.Location = new System.Drawing.Point(22, 33);
            this.admin_product_logo_label.Name = "admin_product_logo_label";
            this.admin_product_logo_label.Size = new System.Drawing.Size(206, 20);
            this.admin_product_logo_label.TabIndex = 0;
            this.admin_product_logo_label.Text = "PRODUCT -> DISPLAY";
            // 
            // admin_product_dataGridView
            // 
            this.admin_product_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_product_dataGridView.Location = new System.Drawing.Point(144, 156);
            this.admin_product_dataGridView.Name = "admin_product_dataGridView";
            this.admin_product_dataGridView.RowTemplate.Height = 24;
            this.admin_product_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.admin_product_dataGridView.Size = new System.Drawing.Size(858, 563);
            this.admin_product_dataGridView.TabIndex = 3;
            // 
            // Display_Product_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.display_product_panel);
            this.Name = "Display_Product_UserControl";
            this.Size = new System.Drawing.Size(1161, 745);
            this.display_product_panel.ResumeLayout(false);
            this.display_product_panel.PerformLayout();
            this.admin_product_logo_panel.ResumeLayout(false);
            this.admin_product_logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_product_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel display_product_panel;
        private System.Windows.Forms.Button admin_form_product_search_button;
        private System.Windows.Forms.TextBox admin_product_search_textBox;
        private System.Windows.Forms.Label admin_product_search_label;
        private System.Windows.Forms.Panel admin_product_logo_panel;
        private System.Windows.Forms.Button admin_form_exit_button;
        private System.Windows.Forms.Label admin_product_logo_label;
        private System.Windows.Forms.DataGridView admin_product_dataGridView;
    }
}
