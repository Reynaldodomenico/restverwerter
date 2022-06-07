
namespace GUI
{
    partial class ListRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRecipe));
            this.Panel_Steuerelemente = new System.Windows.Forms.Panel();
            this.Page_Label = new System.Windows.Forms.Label();
            this.PreviousSide_Label = new System.Windows.Forms.Label();
            this.NextSide_Label = new System.Windows.Forms.Label();
            this.ovalPictureBox2 = new GUI.OvalPictureBox();
            this.ovalPictureBox1 = new GUI.OvalPictureBox();
            this.No_Recipe_Found_Label = new System.Windows.Forms.Label();
            this.roundedButton3 = new GUI.RoundedButton();
            this.ovalPictureBox3 = new GUI.OvalPictureBox();
            this.ovalPictureBox4 = new GUI.OvalPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Steuerelemente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Steuerelemente
            // 
            this.Panel_Steuerelemente.Controls.Add(this.Page_Label);
            this.Panel_Steuerelemente.Controls.Add(this.PreviousSide_Label);
            this.Panel_Steuerelemente.Controls.Add(this.NextSide_Label);
            this.Panel_Steuerelemente.Controls.Add(this.ovalPictureBox2);
            this.Panel_Steuerelemente.Controls.Add(this.ovalPictureBox1);
            this.Panel_Steuerelemente.Controls.Add(this.No_Recipe_Found_Label);
            this.Panel_Steuerelemente.Controls.Add(this.roundedButton3);
            this.Panel_Steuerelemente.Controls.Add(this.ovalPictureBox3);
            this.Panel_Steuerelemente.Controls.Add(this.ovalPictureBox4);
            this.Panel_Steuerelemente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Steuerelemente.Location = new System.Drawing.Point(0, 601);
            this.Panel_Steuerelemente.Name = "Panel_Steuerelemente";
            this.Panel_Steuerelemente.Size = new System.Drawing.Size(724, 103);
            this.Panel_Steuerelemente.TabIndex = 1;
            // 
            // Page_Label
            // 
            this.Page_Label.AutoSize = true;
            this.Page_Label.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Page_Label.Location = new System.Drawing.Point(114, 40);
            this.Page_Label.Name = "Page_Label";
            this.Page_Label.Size = new System.Drawing.Size(82, 31);
            this.Page_Label.TabIndex = 67;
            this.Page_Label.Text = "Seite 1";
            // 
            // PreviousSide_Label
            // 
            this.PreviousSide_Label.AutoSize = true;
            this.PreviousSide_Label.Location = new System.Drawing.Point(28, 79);
            this.PreviousSide_Label.Name = "PreviousSide_Label";
            this.PreviousSide_Label.Size = new System.Drawing.Size(85, 15);
            this.PreviousSide_Label.TabIndex = 66;
            this.PreviousSide_Label.Text = "Vorherige Seite";
            // 
            // NextSide_Label
            // 
            this.NextSide_Label.AutoSize = true;
            this.NextSide_Label.Location = new System.Drawing.Point(193, 79);
            this.NextSide_Label.Name = "NextSide_Label";
            this.NextSide_Label.Size = new System.Drawing.Size(78, 15);
            this.NextSide_Label.TabIndex = 65;
            this.NextSide_Label.Text = "Nächste Seite";
            // 
            // ovalPictureBox2
            // 
            this.ovalPictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ovalPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox2.Image")));
            this.ovalPictureBox2.Location = new System.Drawing.Point(209, 35);
            this.ovalPictureBox2.Name = "ovalPictureBox2";
            this.ovalPictureBox2.Size = new System.Drawing.Size(48, 44);
            this.ovalPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox2.TabIndex = 64;
            this.ovalPictureBox2.TabStop = false;
            this.ovalPictureBox2.Click += new System.EventHandler(this.Next_Side_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ovalPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox1.Image")));
            this.ovalPictureBox1.Location = new System.Drawing.Point(49, 35);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(48, 44);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox1.TabIndex = 63;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.Click += new System.EventHandler(this.Previous_Side_Click);
            // 
            // No_Recipe_Found_Label
            // 
            this.No_Recipe_Found_Label.AutoSize = true;
            this.No_Recipe_Found_Label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.No_Recipe_Found_Label.Location = new System.Drawing.Point(25, 35);
            this.No_Recipe_Found_Label.Name = "No_Recipe_Found_Label";
            this.No_Recipe_Found_Label.Size = new System.Drawing.Size(23, 30);
            this.No_Recipe_Found_Label.TabIndex = 62;
            this.No_Recipe_Found_Label.Text = "L";
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.PeachPuff;
            this.roundedButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton3.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.roundedButton3.ForeColor = System.Drawing.Color.Crimson;
            this.roundedButton3.Location = new System.Drawing.Point(532, 21);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(167, 58);
            this.roundedButton3.TabIndex = 61;
            this.roundedButton3.Text = "Schließen";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.Close_ListRecipe_Click);
            // 
            // ovalPictureBox3
            // 
            this.ovalPictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox3.Image")));
            this.ovalPictureBox3.Location = new System.Drawing.Point(209, 35);
            this.ovalPictureBox3.Name = "ovalPictureBox3";
            this.ovalPictureBox3.Size = new System.Drawing.Size(48, 44);
            this.ovalPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox3.TabIndex = 68;
            this.ovalPictureBox3.TabStop = false;
            // 
            // ovalPictureBox4
            // 
            this.ovalPictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox4.Image")));
            this.ovalPictureBox4.Location = new System.Drawing.Point(49, 35);
            this.ovalPictureBox4.Name = "ovalPictureBox4";
            this.ovalPictureBox4.Size = new System.Drawing.Size(48, 44);
            this.ovalPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox4.TabIndex = 69;
            this.ovalPictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.flowLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 604);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(724, 604);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // ListRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Steuerelemente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListRecipe";
            this.Text = "Rezeptliste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListRecipe_FormClosed);
            this.Load += new System.EventHandler(this.ListRecipe_Load);
            this.Panel_Steuerelemente.ResumeLayout(false);
            this.Panel_Steuerelemente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Steuerelemente;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private RoundedButton roundedButton3;
        private System.Windows.Forms.Label No_Recipe_Found_Label;
        private System.Windows.Forms.Label Page_Label;
        private System.Windows.Forms.Label PreviousSide_Label;
        private System.Windows.Forms.Label NextSide_Label;
        private OvalPictureBox ovalPictureBox2;
        private OvalPictureBox ovalPictureBox1;
        private OvalPictureBox ovalPictureBox3;
        private OvalPictureBox ovalPictureBox4;
    }
}