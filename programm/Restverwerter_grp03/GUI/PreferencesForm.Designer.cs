
namespace GUI
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioButton_Omnivor = new System.Windows.Forms.RadioButton();
            this.RadioButton_Vegetarisch = new System.Windows.Forms.RadioButton();
            this.RadioButton_Vegan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2_Entfernen = new System.Windows.Forms.Button();
            this.DeleteAll_IngredientsAvailable_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.Location = new System.Drawing.Point(593, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox2_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(593, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auf welche Lebensmittel reagierst du allergisch? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(36, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wähle die Diät aus, die zu deinem Ernährungsstil passt.";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(593, 114);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 298);
            this.listBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(593, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Allergien";
            // 
            // RadioButton_Omnivor
            // 
            this.RadioButton_Omnivor.AutoSize = true;
            this.RadioButton_Omnivor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButton_Omnivor.Location = new System.Drawing.Point(36, 53);
            this.RadioButton_Omnivor.Name = "RadioButton_Omnivor";
            this.RadioButton_Omnivor.Size = new System.Drawing.Size(110, 29);
            this.RadioButton_Omnivor.TabIndex = 14;
            this.RadioButton_Omnivor.TabStop = true;
            this.RadioButton_Omnivor.Text = "Mischkost";
            this.RadioButton_Omnivor.UseVisualStyleBackColor = true;
            this.RadioButton_Omnivor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioButton_Vegetarisch
            // 
            this.RadioButton_Vegetarisch.AutoSize = true;
            this.RadioButton_Vegetarisch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButton_Vegetarisch.Location = new System.Drawing.Point(36, 88);
            this.RadioButton_Vegetarisch.Name = "RadioButton_Vegetarisch";
            this.RadioButton_Vegetarisch.Size = new System.Drawing.Size(120, 29);
            this.RadioButton_Vegetarisch.TabIndex = 15;
            this.RadioButton_Vegetarisch.TabStop = true;
            this.RadioButton_Vegetarisch.Text = "Vegetarisch";
            this.RadioButton_Vegetarisch.UseVisualStyleBackColor = true;
            this.RadioButton_Vegetarisch.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioButton_Vegan
            // 
            this.RadioButton_Vegan.AutoSize = true;
            this.RadioButton_Vegan.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButton_Vegan.Location = new System.Drawing.Point(36, 123);
            this.RadioButton_Vegan.Name = "RadioButton_Vegan";
            this.RadioButton_Vegan.Size = new System.Drawing.Size(79, 29);
            this.RadioButton_Vegan.TabIndex = 16;
            this.RadioButton_Vegan.TabStop = true;
            this.RadioButton_Vegan.Text = "Vegan";
            this.RadioButton_Vegan.UseVisualStyleBackColor = true;
            this.RadioButton_Vegan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(784, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 52;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn2_Entfernen
            // 
            this.btn2_Entfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2_Entfernen.BackColor = System.Drawing.Color.PaleGreen;
            this.btn2_Entfernen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2_Entfernen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn2_Entfernen.Location = new System.Drawing.Point(784, 155);
            this.btn2_Entfernen.Name = "btn2_Entfernen";
            this.btn2_Entfernen.Size = new System.Drawing.Size(137, 35);
            this.btn2_Entfernen.TabIndex = 67;
            this.btn2_Entfernen.Text = "Entfernen";
            this.btn2_Entfernen.UseVisualStyleBackColor = false;
            this.btn2_Entfernen.Click += new System.EventHandler(this.btn2_Entfernen_Click_1);
            // 
            // DeleteAll_IngredientsAvailable_Btn
            // 
            this.DeleteAll_IngredientsAvailable_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAll_IngredientsAvailable_Btn.BackColor = System.Drawing.Color.PaleGreen;
            this.DeleteAll_IngredientsAvailable_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAll_IngredientsAvailable_Btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.DeleteAll_IngredientsAvailable_Btn.Location = new System.Drawing.Point(784, 196);
            this.DeleteAll_IngredientsAvailable_Btn.Name = "DeleteAll_IngredientsAvailable_Btn";
            this.DeleteAll_IngredientsAvailable_Btn.Size = new System.Drawing.Size(137, 35);
            this.DeleteAll_IngredientsAvailable_Btn.TabIndex = 72;
            this.DeleteAll_IngredientsAvailable_Btn.Text = "Alle Entfernen";
            this.DeleteAll_IngredientsAvailable_Btn.UseVisualStyleBackColor = false;
            this.DeleteAll_IngredientsAvailable_Btn.Click += new System.EventHandler(this.DeleteAll_Allergies_Btn_Click);
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.DeleteAll_IngredientsAvailable_Btn);
            this.Controls.Add(this.btn2_Entfernen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadioButton_Vegan);
            this.Controls.Add(this.RadioButton_Vegetarisch);
            this.Controls.Add(this.RadioButton_Omnivor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1046, 640);
            this.MinimumSize = new System.Drawing.Size(1046, 640);
            this.Name = "PreferencesForm";
            this.Text = "Präferenzen";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2_Entfernen;
        private System.Windows.Forms.Button DeleteAll_IngredientsAvailable_Btn;
        public System.Windows.Forms.RadioButton RadioButton_Omnivor;
        public System.Windows.Forms.RadioButton RadioButton_Vegetarisch;
        public System.Windows.Forms.RadioButton RadioButton_Vegan;
        public System.Windows.Forms.ListBox listBox2;
    }
}