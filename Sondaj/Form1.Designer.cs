namespace Sondaj
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
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocalitatea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkProEuropa = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lstSondaje = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(140, 167);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(121, 20);
            this.txtVarsta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varsta";
            // 
            // cmbLocalitatea
            // 
            this.cmbLocalitatea.FormattingEnabled = true;
            this.cmbLocalitatea.Items.AddRange(new object[] {
            "Selecteaza o localitate",
            "Suceava",
            "Radauti",
            "Plm"});
            this.cmbLocalitatea.Location = new System.Drawing.Point(140, 193);
            this.cmbLocalitatea.Name = "cmbLocalitatea";
            this.cmbLocalitatea.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalitatea.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localitate";
            // 
            // chkProEuropa
            // 
            this.chkProEuropa.AutoSize = true;
            this.chkProEuropa.Location = new System.Drawing.Point(140, 220);
            this.chkProEuropa.Name = "chkProEuropa";
            this.chkProEuropa.Size = new System.Drawing.Size(40, 17);
            this.chkProEuropa.TabIndex = 4;
            this.chkProEuropa.Text = "Da";
            this.chkProEuropa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ProEuropa";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(86, 243);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(167, 243);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 7;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // lstSondaje
            // 
            this.lstSondaje.FormattingEnabled = true;
            this.lstSondaje.Location = new System.Drawing.Point(406, 167);
            this.lstSondaje.Name = "lstSondaje";
            this.lstSondaje.Size = new System.Drawing.Size(281, 95);
            this.lstSondaje.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSondaje);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkProEuropa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLocalitatea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVarsta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocalitatea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkProEuropa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.ListBox lstSondaje;
    }
}

