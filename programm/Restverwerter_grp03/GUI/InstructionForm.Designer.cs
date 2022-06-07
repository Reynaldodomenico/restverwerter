
namespace GUI
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.RecipeImage = new System.Windows.Forms.PictureBox();
            this.RecipeListLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.Instruction = new System.Windows.Forms.TextBox();
            this.DietLabel = new System.Windows.Forms.Label();
            this.ovalPictureBox1 = new GUI.OvalPictureBox();
            this.ovalPictureBox2 = new GUI.OvalPictureBox();
            this.RecipeListbox = new System.Windows.Forms.ListBox();
            this.Like_Clicked = new GUI.OvalPictureBox();
            this.Dislike_Clicked = new GUI.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Like_Clicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dislike_Clicked)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeImage
            // 
            this.RecipeImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecipeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecipeImage.Location = new System.Drawing.Point(297, 8);
            this.RecipeImage.Name = "RecipeImage";
            this.RecipeImage.Size = new System.Drawing.Size(454, 319);
            this.RecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecipeImage.TabIndex = 0;
            this.RecipeImage.TabStop = false;
            // 
            // RecipeListLabel
            // 
            this.RecipeListLabel.AutoSize = true;
            this.RecipeListLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecipeListLabel.Location = new System.Drawing.Point(12, 20);
            this.RecipeListLabel.Name = "RecipeListLabel";
            this.RecipeListLabel.Size = new System.Drawing.Size(83, 28);
            this.RecipeListLabel.TabIndex = 5;
            this.RecipeListLabel.Text = "Zutaten:";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionLabel.Location = new System.Drawing.Point(297, 330);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(101, 28);
            this.InstructionLabel.TabIndex = 6;
            this.InstructionLabel.Text = "Anleitung:";
            // 
            // Instruction
            // 
            this.Instruction.AcceptsReturn = true;
            this.Instruction.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instruction.HideSelection = false;
            this.Instruction.Location = new System.Drawing.Point(299, 361);
            this.Instruction.Multiline = true;
            this.Instruction.Name = "Instruction";
            this.Instruction.ReadOnly = true;
            this.Instruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Instruction.Size = new System.Drawing.Size(454, 395);
            this.Instruction.TabIndex = 1;
            this.Instruction.TabStop = false;
            // 
            // DietLabel
            // 
            this.DietLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DietLabel.CausesValidation = false;
            this.DietLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DietLabel.Location = new System.Drawing.Point(583, 330);
            this.DietLabel.Name = "DietLabel";
            this.DietLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DietLabel.Size = new System.Drawing.Size(168, 28);
            this.DietLabel.TabIndex = 8;
            this.DietLabel.Text = "DietValue";
            this.DietLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::GUI.Properties.Resources.Like_nottransparent;
            this.ovalPictureBox1.Location = new System.Drawing.Point(29, 642);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(105, 98);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 9;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.Click += new System.EventHandler(this.Like_Click);
            // 
            // ovalPictureBox2
            // 
            this.ovalPictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox2.Image")));
            this.ovalPictureBox2.Location = new System.Drawing.Point(162, 642);
            this.ovalPictureBox2.Name = "ovalPictureBox2";
            this.ovalPictureBox2.Size = new System.Drawing.Size(105, 98);
            this.ovalPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox2.TabIndex = 10;
            this.ovalPictureBox2.TabStop = false;
            this.ovalPictureBox2.Click += new System.EventHandler(this.DisLike_Click);
            // 
            // RecipeListbox
            // 
            this.RecipeListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecipeListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RecipeListbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecipeListbox.FormattingEnabled = true;
            this.RecipeListbox.HorizontalScrollbar = true;
            this.RecipeListbox.ItemHeight = 21;
            this.RecipeListbox.Location = new System.Drawing.Point(23, 51);
            this.RecipeListbox.Name = "RecipeListbox";
            this.RecipeListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RecipeListbox.Size = new System.Drawing.Size(251, 527);
            this.RecipeListbox.TabIndex = 12;
            // 
            // Like_Clicked
            // 
            this.Like_Clicked.BackColor = System.Drawing.Color.DarkGray;
            this.Like_Clicked.Image = ((System.Drawing.Image)(resources.GetObject("Like_Clicked.Image")));
            this.Like_Clicked.Location = new System.Drawing.Point(14, 626);
            this.Like_Clicked.Name = "Like_Clicked";
            this.Like_Clicked.Size = new System.Drawing.Size(135, 131);
            this.Like_Clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Like_Clicked.TabIndex = 13;
            this.Like_Clicked.TabStop = false;
            this.Like_Clicked.Click += new System.EventHandler(this.Like_Clicked_Click);
            // 
            // Dislike_Clicked
            // 
            this.Dislike_Clicked.BackColor = System.Drawing.Color.DarkGray;
            this.Dislike_Clicked.Image = ((System.Drawing.Image)(resources.GetObject("Dislike_Clicked.Image")));
            this.Dislike_Clicked.Location = new System.Drawing.Point(143, 625);
            this.Dislike_Clicked.Name = "Dislike_Clicked";
            this.Dislike_Clicked.Size = new System.Drawing.Size(140, 131);
            this.Dislike_Clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dislike_Clicked.TabIndex = 14;
            this.Dislike_Clicked.TabStop = false;
            this.Dislike_Clicked.Click += new System.EventHandler(this.Dislike_Clicked_Click);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(763, 776);
            this.Controls.Add(this.Dislike_Clicked);
            this.Controls.Add(this.Like_Clicked);
            this.Controls.Add(this.RecipeListbox);
            this.Controls.Add(this.ovalPictureBox2);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.DietLabel);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.RecipeListLabel);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.RecipeImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(779, 815);
            this.MinimumSize = new System.Drawing.Size(779, 815);
            this.Name = "InstructionForm";
            this.Text = "RecipeName";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstructionForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstructionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Like_Clicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dislike_Clicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RecipeImage;
        private System.Windows.Forms.Label RecipeListLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox Instruction;
        private System.Windows.Forms.Label DietLabel;
        private OvalPictureBox ovalPictureBox1;
        private OvalPictureBox ovalPictureBox2;
        private System.Windows.Forms.ListBox RecipeListbox;
        private OvalPictureBox Like_Clicked;
        private OvalPictureBox Dislike_Clicked;
    }
}