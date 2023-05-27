namespace inventory_management_system
{
    partial class loading_form
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
            this.components = new System.ComponentModel.Container();
            this.loading_form_whole_panel = new System.Windows.Forms.Panel();
            this.loadind_dark_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copy_right_label = new System.Windows.Forms.Label();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.loading_icon_label = new System.Windows.Forms.Label();
            this.loading_form_whole_pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loading_form_whole_panel.SuspendLayout();
            this.loadind_dark_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_form_whole_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_form_whole_panel
            // 
            this.loading_form_whole_panel.Controls.Add(this.loadind_dark_panel);
            this.loading_form_whole_panel.Controls.Add(this.copy_right_label);
            this.loading_form_whole_panel.Controls.Add(this.logo_pictureBox);
            this.loading_form_whole_panel.Controls.Add(this.loading_icon_label);
            this.loading_form_whole_panel.Controls.Add(this.loading_form_whole_pictureBox);
            this.loading_form_whole_panel.Location = new System.Drawing.Point(0, 1);
            this.loading_form_whole_panel.Name = "loading_form_whole_panel";
            this.loading_form_whole_panel.Size = new System.Drawing.Size(942, 573);
            this.loading_form_whole_panel.TabIndex = 0;
            // 
            // loadind_dark_panel
            // 
            this.loadind_dark_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadind_dark_panel.Controls.Add(this.pictureBox1);
            this.loadind_dark_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadind_dark_panel.Location = new System.Drawing.Point(0, 554);
            this.loadind_dark_panel.Name = "loadind_dark_panel";
            this.loadind_dark_panel.Size = new System.Drawing.Size(942, 19);
            this.loadind_dark_panel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 20);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // copy_right_label
            // 
            this.copy_right_label.AutoSize = true;
            this.copy_right_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copy_right_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_right_label.ForeColor = System.Drawing.Color.White;
            this.copy_right_label.Location = new System.Drawing.Point(102, 484);
            this.copy_right_label.Name = "copy_right_label";
            this.copy_right_label.Size = new System.Drawing.Size(688, 17);
            this.copy_right_label.TabIndex = 3;
            this.copy_right_label.Text = "@ COPY RIGHT : TAIMOOR IMRAN BAIG | SHAYAN WARIS SIDDIQUI | SARIM BIN FAISAL | ZA" +
    "IN UN ABDIN\r\n";
            this.copy_right_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Image = global::inventory_management_system.Properties.Resources.logo;
            this.logo_pictureBox.Location = new System.Drawing.Point(105, 183);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(139, 116);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pictureBox.TabIndex = 2;
            this.logo_pictureBox.TabStop = false;
            // 
            // loading_icon_label
            // 
            this.loading_icon_label.AutoSize = true;
            this.loading_icon_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loading_icon_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_icon_label.ForeColor = System.Drawing.Color.White;
            this.loading_icon_label.Location = new System.Drawing.Point(241, 229);
            this.loading_icon_label.Name = "loading_icon_label";
            this.loading_icon_label.Size = new System.Drawing.Size(536, 32);
            this.loading_icon_label.TabIndex = 1;
            this.loading_icon_label.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // loading_form_whole_pictureBox
            // 
            this.loading_form_whole_pictureBox.Image = global::inventory_management_system.Properties.Resources.loading_page;
            this.loading_form_whole_pictureBox.Location = new System.Drawing.Point(0, -1);
            this.loading_form_whole_pictureBox.Name = "loading_form_whole_pictureBox";
            this.loading_form_whole_pictureBox.Size = new System.Drawing.Size(942, 573);
            this.loading_form_whole_pictureBox.TabIndex = 0;
            this.loading_form_whole_pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 573);
            this.Controls.Add(this.loading_form_whole_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loading_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loading_form";
            this.Load += new System.EventHandler(this.loading_form_Load);
            this.loading_form_whole_panel.ResumeLayout(false);
            this.loading_form_whole_panel.PerformLayout();
            this.loadind_dark_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_form_whole_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loading_form_whole_panel;
        private System.Windows.Forms.PictureBox loading_form_whole_pictureBox;
        private System.Windows.Forms.Label loading_icon_label;
        private System.Windows.Forms.Label copy_right_label;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel loadind_dark_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}