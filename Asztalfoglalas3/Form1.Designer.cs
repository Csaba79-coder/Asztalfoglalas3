
namespace Asztalfoglalas3
{
    partial class Form1
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
            this.lbFoglalas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.tbErkezesnap = new System.Windows.Forms.TextBox();
            this.tbLetszam = new System.Windows.Forms.TextBox();
            this.tbVendegNeve = new System.Windows.Forms.TextBox();
            this.tbErkezesOra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTorzsVendegE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbFoglalas
            // 
            this.lbFoglalas.FormattingEnabled = true;
            this.lbFoglalas.Location = new System.Drawing.Point(15, 34);
            this.lbFoglalas.Name = "lbFoglalas";
            this.lbFoglalas.Size = new System.Drawing.Size(120, 199);
            this.lbFoglalas.TabIndex = 0;
            this.lbFoglalas.SelectedIndexChanged += new System.EventHandler(this.lbFoglalas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foglalások:";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(15, 253);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(120, 38);
            this.btnFelvitel.TabIndex = 2;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // tbErkezesnap
            // 
            this.tbErkezesnap.Location = new System.Drawing.Point(171, 177);
            this.tbErkezesnap.Name = "tbErkezesnap";
            this.tbErkezesnap.Size = new System.Drawing.Size(100, 20);
            this.tbErkezesnap.TabIndex = 3;
            // 
            // tbLetszam
            // 
            this.tbLetszam.Location = new System.Drawing.Point(171, 82);
            this.tbLetszam.Name = "tbLetszam";
            this.tbLetszam.Size = new System.Drawing.Size(100, 20);
            this.tbLetszam.TabIndex = 4;
            // 
            // tbVendegNeve
            // 
            this.tbVendegNeve.Location = new System.Drawing.Point(171, 34);
            this.tbVendegNeve.Name = "tbVendegNeve";
            this.tbVendegNeve.Size = new System.Drawing.Size(100, 20);
            this.tbVendegNeve.TabIndex = 5;
            // 
            // tbErkezesOra
            // 
            this.tbErkezesOra.Location = new System.Drawing.Point(171, 135);
            this.tbErkezesOra.Name = "tbErkezesOra";
            this.tbErkezesOra.Size = new System.Drawing.Size(100, 20);
            this.tbErkezesOra.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendég neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Létszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Érkezés ideje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Érkezés napja:";
            // 
            // cbTorzsVendegE
            // 
            this.cbTorzsVendegE.AutoSize = true;
            this.cbTorzsVendegE.Location = new System.Drawing.Point(171, 216);
            this.cbTorzsVendegE.Name = "cbTorzsVendegE";
            this.cbTorzsVendegE.Size = new System.Drawing.Size(88, 17);
            this.cbTorzsVendegE.TabIndex = 12;
            this.cbTorzsVendegE.Text = "Törzsvendég";
            this.cbTorzsVendegE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 316);
            this.Controls.Add(this.cbTorzsVendegE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbErkezesOra);
            this.Controls.Add(this.tbVendegNeve);
            this.Controls.Add(this.tbLetszam);
            this.Controls.Add(this.tbErkezesnap);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFoglalas);
            this.Name = "Form1";
            this.Text = "Asztalfoglalás alkalmazás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFoglalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.TextBox tbErkezesnap;
        private System.Windows.Forms.TextBox tbLetszam;
        private System.Windows.Forms.TextBox tbVendegNeve;
        private System.Windows.Forms.TextBox tbErkezesOra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbTorzsVendegE;
    }
}

