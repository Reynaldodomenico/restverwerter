
namespace GUI
{
    partial class RecipeFilterForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Hinzufügen_Vorräte = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.RecipeSearchBtn = new GUI.RoundedButton();
            this.btn_Entfernen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Hinzufügen_Basiszutaten = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_Entfernen2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteAll_BaseIngredients_Btn = new System.Windows.Forms.Button();
            this.DeleteAll_IngredientsAvailable_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.Location = new System.Drawing.Point(562, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 23);
            this.textBox2.TabIndex = 17;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_Vorräte_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(562, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Welche Lebensmittel möchtest du verwenden?";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(44, 137);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 319);
            this.listBox1.TabIndex = 50;
            // 
            // Btn_Hinzufügen_Vorräte
            // 
            this.Btn_Hinzufügen_Vorräte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Hinzufügen_Vorräte.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_Hinzufügen_Vorräte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Hinzufügen_Vorräte.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Hinzufügen_Vorräte.Location = new System.Drawing.Point(753, 133);
            this.Btn_Hinzufügen_Vorräte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Hinzufügen_Vorräte.Name = "Btn_Hinzufügen_Vorräte";
            this.Btn_Hinzufügen_Vorräte.Size = new System.Drawing.Size(133, 37);
            this.Btn_Hinzufügen_Vorräte.TabIndex = 51;
            this.Btn_Hinzufügen_Vorräte.Text = "Hinzufügen";
            this.Btn_Hinzufügen_Vorräte.UseVisualStyleBackColor = false;
            this.Btn_Hinzufügen_Vorräte.Click += new System.EventHandler(this.Btn_Hinzufügen_Vorräte_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Teal;
            this.label19.Location = new System.Drawing.Point(562, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 25);
            this.label19.TabIndex = 52;
            this.label19.Text = "Lebensmittel:";
            // 
            // RecipeSearchBtn
            // 
            this.RecipeSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeSearchBtn.AutoSize = true;
            this.RecipeSearchBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RecipeSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RecipeSearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.RecipeSearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.RecipeSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecipeSearchBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RecipeSearchBtn.ForeColor = System.Drawing.Color.Teal;
            this.RecipeSearchBtn.Location = new System.Drawing.Point(803, 398);
            this.RecipeSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeSearchBtn.Name = "RecipeSearchBtn";
            this.RecipeSearchBtn.Size = new System.Drawing.Size(204, 58);
            this.RecipeSearchBtn.TabIndex = 59;
            this.RecipeSearchBtn.Text = "Rezepte suchen";
            this.RecipeSearchBtn.UseVisualStyleBackColor = false;
            this.RecipeSearchBtn.Click += new System.EventHandler(this.RecipeSearchBtn_Click);
            // 
            // btn_Entfernen
            // 
            this.btn_Entfernen.BackColor = System.Drawing.Color.Khaki;
            this.btn_Entfernen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Entfernen.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Entfernen.Location = new System.Drawing.Point(232, 178);
            this.btn_Entfernen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Entfernen.Name = "btn_Entfernen";
            this.btn_Entfernen.Size = new System.Drawing.Size(133, 37);
            this.btn_Entfernen.TabIndex = 60;
            this.btn_Entfernen.Text = "Entfernen";
            this.btn_Entfernen.UseVisualStyleBackColor = false;
            this.btn_Entfernen.Click += new System.EventHandler(this.Btn_Entfernen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 63;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(44, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 23);
            this.textBox1.TabIndex = 62;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_BaseIngredients_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Auf welches Lebensmittel hast du besonders Lust?";
            // 
            // Btn_Hinzufügen_Basiszutaten
            // 
            this.Btn_Hinzufügen_Basiszutaten.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Hinzufügen_Basiszutaten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Hinzufügen_Basiszutaten.ForeColor = System.Drawing.Color.DarkOrange;
            this.Btn_Hinzufügen_Basiszutaten.Location = new System.Drawing.Point(232, 137);
            this.Btn_Hinzufügen_Basiszutaten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Hinzufügen_Basiszutaten.Name = "Btn_Hinzufügen_Basiszutaten";
            this.Btn_Hinzufügen_Basiszutaten.Size = new System.Drawing.Size(133, 37);
            this.Btn_Hinzufügen_Basiszutaten.TabIndex = 64;
            this.Btn_Hinzufügen_Basiszutaten.Text = "Hinzufügen";
            this.Btn_Hinzufügen_Basiszutaten.UseVisualStyleBackColor = false;
            this.Btn_Hinzufügen_Basiszutaten.Click += new System.EventHandler(this.Btn_Hinzufügen_Basiszutaten_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.Teal;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(562, 137);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 319);
            this.listBox2.TabIndex = 65;
            // 
            // btn_Entfernen2
            // 
            this.btn_Entfernen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Entfernen2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Entfernen2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Entfernen2.ForeColor = System.Drawing.Color.Teal;
            this.btn_Entfernen2.Location = new System.Drawing.Point(753, 174);
            this.btn_Entfernen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Entfernen2.Name = "btn_Entfernen2";
            this.btn_Entfernen2.Size = new System.Drawing.Size(133, 37);
            this.btn_Entfernen2.TabIndex = 66;
            this.btn_Entfernen2.Text = "Entfernen";
            this.btn_Entfernen2.UseVisualStyleBackColor = false;
            this.btn_Entfernen2.Click += new System.EventHandler(this.Btn_Entfernen2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Basiszutaten";
            // 
            // DeleteAll_BaseIngredients_Btn
            // 
            this.DeleteAll_BaseIngredients_Btn.BackColor = System.Drawing.Color.Khaki;
            this.DeleteAll_BaseIngredients_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAll_BaseIngredients_Btn.ForeColor = System.Drawing.Color.DarkOrange;
            this.DeleteAll_BaseIngredients_Btn.Location = new System.Drawing.Point(232, 219);
            this.DeleteAll_BaseIngredients_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteAll_BaseIngredients_Btn.Name = "DeleteAll_BaseIngredients_Btn";
            this.DeleteAll_BaseIngredients_Btn.Size = new System.Drawing.Size(133, 37);
            this.DeleteAll_BaseIngredients_Btn.TabIndex = 70;
            this.DeleteAll_BaseIngredients_Btn.Text = "Alle Entfernen";
            this.DeleteAll_BaseIngredients_Btn.UseVisualStyleBackColor = false;
            this.DeleteAll_BaseIngredients_Btn.Click += new System.EventHandler(this.DeleteAll_BaseIngredients_Btn_Click);
            // 
            // DeleteAll_IngredientsAvailable_Btn
            // 
            this.DeleteAll_IngredientsAvailable_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAll_IngredientsAvailable_Btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DeleteAll_IngredientsAvailable_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAll_IngredientsAvailable_Btn.ForeColor = System.Drawing.Color.Teal;
            this.DeleteAll_IngredientsAvailable_Btn.Location = new System.Drawing.Point(753, 215);
            this.DeleteAll_IngredientsAvailable_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteAll_IngredientsAvailable_Btn.Name = "DeleteAll_IngredientsAvailable_Btn";
            this.DeleteAll_IngredientsAvailable_Btn.Size = new System.Drawing.Size(133, 37);
            this.DeleteAll_IngredientsAvailable_Btn.TabIndex = 71;
            this.DeleteAll_IngredientsAvailable_Btn.Text = "Alle Entfernen";
            this.DeleteAll_IngredientsAvailable_Btn.UseVisualStyleBackColor = false;
            this.DeleteAll_IngredientsAvailable_Btn.Click += new System.EventHandler(this.DeleteAll_IngredientsAvailable_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::GUI.Properties.Resources.pexels_valeria_boltneva_1199960;
            this.pictureBox1.Location = new System.Drawing.Point(0, 493);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // RecipeFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteAll_IngredientsAvailable_Btn);
            this.Controls.Add(this.DeleteAll_BaseIngredients_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Entfernen2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Btn_Hinzufügen_Basiszutaten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Entfernen);
            this.Controls.Add(this.RecipeSearchBtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Btn_Hinzufügen_Vorräte);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1046, 640);
            this.MinimumSize = new System.Drawing.Size(1046, 640);
            this.Name = "RecipeFilterForm";
            this.Text = "RezepteFilter";
            this.Load += new System.EventHandler(this.RecipeFilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Hinzufügen_Vorräte;
        private System.Windows.Forms.Label label19;
        private RoundedButton RecipeSearchBtn;
        private System.Windows.Forms.Button btn_Entfernen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Hinzufügen_Basiszutaten;
        private System.Windows.Forms.Button btn_Entfernen2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteAll_BaseIngredients_Btn;
        private System.Windows.Forms.Button DeleteAll_IngredientsAvailable_Btn;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
    }
}