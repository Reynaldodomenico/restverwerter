
namespace GUI
{
    partial class RecipeOffer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecipePicturebox = new System.Windows.Forms.PictureBox();
            this.Zutaten_Label = new System.Windows.Forms.Label();
            this.Cook_Duration_Label = new System.Windows.Forms.Label();
            this.TitleRecipe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fitting_Recipes_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecipePicturebox
            // 
            this.RecipePicturebox.Location = new System.Drawing.Point(0, 0);
            this.RecipePicturebox.Name = "RecipePicturebox";
            this.RecipePicturebox.Size = new System.Drawing.Size(178, 110);
            this.RecipePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RecipePicturebox.TabIndex = 0;
            this.RecipePicturebox.TabStop = false;
            // 
            // Zutaten_Label
            // 
            this.Zutaten_Label.Location = new System.Drawing.Point(8, 32);
            this.Zutaten_Label.Name = "Zutaten_Label";
            this.Zutaten_Label.Size = new System.Drawing.Size(497, 54);
            this.Zutaten_Label.TabIndex = 4;
            this.Zutaten_Label.Text = "Zutatenliste";
            // 
            // Cook_Duration_Label
            // 
            this.Cook_Duration_Label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cook_Duration_Label.ForeColor = System.Drawing.Color.Maroon;
            this.Cook_Duration_Label.Location = new System.Drawing.Point(8, 86);
            this.Cook_Duration_Label.Name = "Cook_Duration_Label";
            this.Cook_Duration_Label.Size = new System.Drawing.Size(221, 24);
            this.Cook_Duration_Label.TabIndex = 3;
            this.Cook_Duration_Label.Text = "Kochzeit";
            // 
            // TitleRecipe
            // 
            this.TitleRecipe.AutoEllipsis = true;
            this.TitleRecipe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleRecipe.Location = new System.Drawing.Point(8, 4);
            this.TitleRecipe.Name = "TitleRecipe";
            this.TitleRecipe.Size = new System.Drawing.Size(511, 28);
            this.TitleRecipe.TabIndex = 1;
            this.TitleRecipe.Text = "TitelRecipe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Fitting_Recipes_Label);
            this.panel1.Controls.Add(this.TitleRecipe);
            this.panel1.Controls.Add(this.Cook_Duration_Label);
            this.panel1.Controls.Add(this.Zutaten_Label);
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 110);
            this.panel1.TabIndex = 5;
            // 
            // Fitting_Recipes_Label
            // 
            this.Fitting_Recipes_Label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fitting_Recipes_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.Fitting_Recipes_Label.Location = new System.Drawing.Point(257, 86);
            this.Fitting_Recipes_Label.Name = "Fitting_Recipes_Label";
            this.Fitting_Recipes_Label.Size = new System.Drawing.Size(221, 24);
            this.Fitting_Recipes_Label.TabIndex = 5;
            this.Fitting_Recipes_Label.Text = "Passende Zutaten";
            // 
            // RecipeOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RecipePicturebox);
            this.Name = "RecipeOffer";
            this.Size = new System.Drawing.Size(699, 110);
            ((System.ComponentModel.ISupportInitialize)(this.RecipePicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RecipePicturebox;
        private System.Windows.Forms.Label Zutaten_Label;
        private System.Windows.Forms.Label Cook_Duration_Label;
        private System.Windows.Forms.Label TitleRecipe;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Fitting_Recipes_Label;
    }
}
