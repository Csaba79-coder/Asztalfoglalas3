
namespace Asztalfoglalas3
{
    partial class FelvitelForm
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
            this.tbVendegNeve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numErkezesOra = new System.Windows.Forms.NumericUpDown();
            this.numLetszam = new System.Windows.Forms.NumericUpDown();
            this.dtpErkezesNapja = new System.Windows.Forms.DateTimePicker();
            this.cbTorzsVendegE = new System.Windows.Forms.CheckBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numErkezesOra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetszam)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVendegNeve
            // 
            this.tbVendegNeve.Location = new System.Drawing.Point(12, 42);
            this.tbVendegNeve.Name = "tbVendegNeve";
            this.tbVendegNeve.Size = new System.Drawing.Size(100, 20);
            this.tbVendegNeve.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Érkezés napja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Érkezés Ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Létszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendég neve:";
            // 
            // numErkezesOra
            // 
            this.numErkezesOra.Location = new System.Drawing.Point(12, 130);
            this.numErkezesOra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numErkezesOra.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numErkezesOra.Name = "numErkezesOra";
            this.numErkezesOra.Size = new System.Drawing.Size(100, 20);
            this.numErkezesOra.TabIndex = 5;
            this.numErkezesOra.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numLetszam
            // 
            this.numLetszam.Location = new System.Drawing.Point(12, 87);
            this.numLetszam.Name = "numLetszam";
            this.numLetszam.Size = new System.Drawing.Size(100, 20);
            this.numLetszam.TabIndex = 6;
            // 
            // dtpErkezesNapja
            // 
            this.dtpErkezesNapja.Location = new System.Drawing.Point(12, 183);
            this.dtpErkezesNapja.Name = "dtpErkezesNapja";
            this.dtpErkezesNapja.Size = new System.Drawing.Size(200, 20);
            this.dtpErkezesNapja.TabIndex = 7;
            // 
            // cbTorzsVendegE
            // 
            this.cbTorzsVendegE.AutoSize = true;
            this.cbTorzsVendegE.Location = new System.Drawing.Point(12, 222);
            this.cbTorzsVendegE.Name = "cbTorzsVendegE";
            this.cbTorzsVendegE.Size = new System.Drawing.Size(88, 17);
            this.cbTorzsVendegE.TabIndex = 8;
            this.cbTorzsVendegE.Text = "Törzsvendég";
            this.cbTorzsVendegE.UseVisualStyleBackColor = true;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(15, 245);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(97, 39);
            this.btnFelvitel.TabIndex = 9;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // FelvitelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 305);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.cbTorzsVendegE);
            this.Controls.Add(this.dtpErkezesNapja);
            this.Controls.Add(this.numLetszam);
            this.Controls.Add(this.numErkezesOra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVendegNeve);
            this.Name = "FelvitelForm";
            this.Text = "FelvitelForm";
            ((System.ComponentModel.ISupportInitialize)(this.numErkezesOra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVendegNeve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numErkezesOra;
        private System.Windows.Forms.NumericUpDown numLetszam;
        private System.Windows.Forms.DateTimePicker dtpErkezesNapja;
        private System.Windows.Forms.CheckBox cbTorzsVendegE;
        private System.Windows.Forms.Button btnFelvitel;
    }
}