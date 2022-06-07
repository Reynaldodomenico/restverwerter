
namespace GUI
{
    partial class StartPage
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Recipes = new System.Windows.Forms.Button();
            this.Btn_Preferences = new System.Windows.Forms.Button();
            this.Btn_Regitrate = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_StartPage = new System.Windows.Forms.Panel();
            this.PictureBox_Startpage = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_StartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Startpage)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.Btn_Recipes);
            this.MenuPanel.Controls.Add(this.Btn_Preferences);
            this.MenuPanel.Controls.Add(this.Btn_Regitrate);
            this.MenuPanel.Controls.Add(this.Btn_Login);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1046, 83);
            this.MenuPanel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(874, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 83);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vorräte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Stock_Btn_Click);
            // 
            // Btn_Recipes
            // 
            this.Btn_Recipes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_Recipes.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Recipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Btn_Recipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Recipes.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Recipes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_Recipes.Location = new System.Drawing.Point(702, 0);
            this.Btn_Recipes.Name = "Btn_Recipes";
            this.Btn_Recipes.Size = new System.Drawing.Size(172, 83);
            this.Btn_Recipes.TabIndex = 4;
            this.Btn_Recipes.Text = "Rezepte suchen";
            this.Btn_Recipes.UseVisualStyleBackColor = false;
            this.Btn_Recipes.Click += new System.EventHandler(this.Btn_Recipes_Click);
            // 
            // Btn_Preferences
            // 
            this.Btn_Preferences.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_Preferences.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Preferences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.Btn_Preferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Preferences.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Preferences.ForeColor = System.Drawing.Color.DarkGreen;
            this.Btn_Preferences.Location = new System.Drawing.Point(530, 0);
            this.Btn_Preferences.Name = "Btn_Preferences";
            this.Btn_Preferences.Size = new System.Drawing.Size(172, 83);
            this.Btn_Preferences.TabIndex = 3;
            this.Btn_Preferences.Text = "Präferenzen";
            this.Btn_Preferences.UseVisualStyleBackColor = false;
            this.Btn_Preferences.Click += new System.EventHandler(this.Btn_Preferences_Click);
            // 
            // Btn_Regitrate
            // 
            this.Btn_Regitrate.BackColor = System.Drawing.Color.Bisque;
            this.Btn_Regitrate.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Regitrate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.Btn_Regitrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regitrate.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Regitrate.ForeColor = System.Drawing.Color.Crimson;
            this.Btn_Regitrate.Location = new System.Drawing.Point(358, 0);
            this.Btn_Regitrate.Name = "Btn_Regitrate";
            this.Btn_Regitrate.Size = new System.Drawing.Size(172, 83);
            this.Btn_Regitrate.TabIndex = 2;
            this.Btn_Regitrate.Text = "Registrieren";
            this.Btn_Regitrate.UseVisualStyleBackColor = false;
            this.Btn_Regitrate.Click += new System.EventHandler(this.Btn_Regitrate_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Login.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Btn_Login.Location = new System.Drawing.Point(186, 0);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(172, 83);
            this.Btn_Login.TabIndex = 1;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 83);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Image_2021_07_10_18_39_23;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Logo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_StartPage
            // 
            this.Panel_StartPage.Controls.Add(this.PictureBox_Startpage);
            this.Panel_StartPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_StartPage.Location = new System.Drawing.Point(0, 83);
            this.Panel_StartPage.Name = "Panel_StartPage";
            this.Panel_StartPage.Size = new System.Drawing.Size(1046, 640);
            this.Panel_StartPage.TabIndex = 14;
            // 
            // PictureBox_Startpage
            // 
            this.PictureBox_Startpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Startpage.Image = global::GUI.Properties.Resources._1;
            this.PictureBox_Startpage.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Startpage.MaximumSize = new System.Drawing.Size(1046, 640);
            this.PictureBox_Startpage.MinimumSize = new System.Drawing.Size(1046, 640);
            this.PictureBox_Startpage.Name = "PictureBox_Startpage";
            this.PictureBox_Startpage.Size = new System.Drawing.Size(1046, 640);
            this.PictureBox_Startpage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Startpage.TabIndex = 0;
            this.PictureBox_Startpage.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1046, 723);
            this.Controls.Add(this.Panel_StartPage);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(1062, 762);
            this.MinimumSize = new System.Drawing.Size(1062, 762);
            this.Name = "StartPage";
            this.Text = "Ever Fruitful";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartPage_FormClosing);
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_StartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Startpage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Recipes;
        private System.Windows.Forms.Button Btn_Preferences;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel_StartPage;
        private System.Windows.Forms.PictureBox PictureBox_Startpage;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Btn_Login;
        public System.Windows.Forms.Button Btn_Regitrate;
    }
}