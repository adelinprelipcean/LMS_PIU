namespace SubiectPIU_Student
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cmbOras = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grpProgram = new System.Windows.Forms.GroupBox();
            this.rbCalculatoare = new System.Windows.Forms.RadioButton();
            this.rbAutomatica = new System.Windows.Forms.RadioButton();
            this.rbElectronica = new System.Windows.Forms.RadioButton();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.grpProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(87, 63);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(129, 20);
            this.txtNume.TabIndex = 0;
            // 
            // cmbOras
            // 
            this.cmbOras.FormattingEnabled = true;
            this.cmbOras.Items.AddRange(new object[] {
            "Selecteaza orasul...",
            "Suceava",
            "Botoșani",
            "Piatra Neamț"});
            this.cmbOras.Location = new System.Drawing.Point(87, 89);
            this.cmbOras.Name = "cmbOras";
            this.cmbOras.Size = new System.Drawing.Size(129, 21);
            this.cmbOras.TabIndex = 1;
            this.cmbOras.SelectedIndexChanged += new System.EventHandler(this.cmbOras_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(87, 116);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(205, 20);
            this.dtpData.TabIndex = 2;
            // 
            // grpProgram
            // 
            this.grpProgram.Controls.Add(this.rbElectronica);
            this.grpProgram.Controls.Add(this.rbAutomatica);
            this.grpProgram.Controls.Add(this.rbCalculatoare);
            this.grpProgram.Location = new System.Drawing.Point(87, 143);
            this.grpProgram.Name = "grpProgram";
            this.grpProgram.Size = new System.Drawing.Size(200, 100);
            this.grpProgram.TabIndex = 3;
            this.grpProgram.TabStop = false;
            this.grpProgram.Text = "Program Studii";
            // 
            // rbCalculatoare
            // 
            this.rbCalculatoare.AutoSize = true;
            this.rbCalculatoare.Location = new System.Drawing.Point(6, 19);
            this.rbCalculatoare.Name = "rbCalculatoare";
            this.rbCalculatoare.Size = new System.Drawing.Size(84, 17);
            this.rbCalculatoare.TabIndex = 0;
            this.rbCalculatoare.TabStop = true;
            this.rbCalculatoare.Text = "Calculatoare";
            this.rbCalculatoare.UseVisualStyleBackColor = true;
            // 
            // rbAutomatica
            // 
            this.rbAutomatica.AutoSize = true;
            this.rbAutomatica.Location = new System.Drawing.Point(6, 42);
            this.rbAutomatica.Name = "rbAutomatica";
            this.rbAutomatica.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatica.TabIndex = 1;
            this.rbAutomatica.TabStop = true;
            this.rbAutomatica.Text = "Automatica";
            this.rbAutomatica.UseVisualStyleBackColor = true;
            // 
            // rbElectronica
            // 
            this.rbElectronica.AutoSize = true;
            this.rbElectronica.Location = new System.Drawing.Point(6, 65);
            this.rbElectronica.Name = "rbElectronica";
            this.rbElectronica.Size = new System.Drawing.Size(78, 17);
            this.rbElectronica.TabIndex = 2;
            this.rbElectronica.TabStop = true;
            this.rbElectronica.Text = "Electronica";
            this.rbElectronica.UseVisualStyleBackColor = true;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(411, 63);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(320, 238);
            this.lstAfisare.TabIndex = 4;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(93, 285);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(99, 23);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga student";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(93, 314);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(99, 23);
            this.btnAfiseaza.TabIndex = 6;
            this.btnAfiseaza.Text = "Afisare toti";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Location = new System.Drawing.Point(93, 343);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(99, 23);
            this.btnFiltrare.TabIndex = 7;
            this.btnFiltrare.Text = "Filtrare după oraș";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.grpProgram);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbOras);
            this.Controls.Add(this.txtNume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProgram.ResumeLayout(false);
            this.grpProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox cmbOras;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox grpProgram;
        private System.Windows.Forms.RadioButton rbElectronica;
        private System.Windows.Forms.RadioButton rbAutomatica;
        private System.Windows.Forms.RadioButton rbCalculatoare;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnFiltrare;
    }
}

