
namespace GUI
{
    partial class SelfInputForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.DeleteAll_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Indigo;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(25, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 319);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelfInputTextbox_KeyDown);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Btn.ForeColor = System.Drawing.Color.Indigo;
            this.Add_Btn.Location = new System.Drawing.Point(222, 76);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(129, 34);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "Hinzufügen";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Btn.ForeColor = System.Drawing.Color.Indigo;
            this.Delete_Btn.Location = new System.Drawing.Point(222, 120);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(129, 34);
            this.Delete_Btn.TabIndex = 3;
            this.Delete_Btn.Text = "Entfernen";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // DeleteAll_Btn
            // 
            this.DeleteAll_Btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAll_Btn.ForeColor = System.Drawing.Color.Indigo;
            this.DeleteAll_Btn.Location = new System.Drawing.Point(222, 160);
            this.DeleteAll_Btn.Name = "DeleteAll_Btn";
            this.DeleteAll_Btn.Size = new System.Drawing.Size(129, 34);
            this.DeleteAll_Btn.TabIndex = 4;
            this.DeleteAll_Btn.Text = "Alle Entfernen";
            this.DeleteAll_Btn.UseVisualStyleBackColor = true;
            this.DeleteAll_Btn.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geben Sie Ihre dauerhaft vorhandene Zutat ein";
            // 
            // SelfInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(542, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAll_Btn);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.MinimumSize = new System.Drawing.Size(504, 463);
            this.Name = "SelfInputForm";
            this.Text = "Selbsteingabe";
            this.Load += new System.EventHandler(this.SelfInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button DeleteAll_Btn;
        private System.Windows.Forms.Label label1;
    }
}