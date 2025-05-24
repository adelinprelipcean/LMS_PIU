namespace Eveniment
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
            this.rbConferinta = new System.Windows.Forms.RadioButton();
            this.rbAniversare = new System.Windows.Forms.RadioButton();
            this.rbNunta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.dgvEvenimente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rbConferinta
            // 
            this.rbConferinta.AutoSize = true;
            this.rbConferinta.Location = new System.Drawing.Point(94, 10);
            this.rbConferinta.Name = "rbConferinta";
            this.rbConferinta.Size = new System.Drawing.Size(72, 17);
            this.rbConferinta.TabIndex = 0;
            this.rbConferinta.TabStop = true;
            this.rbConferinta.Text = "conferinta";
            this.rbConferinta.UseVisualStyleBackColor = true;
            // 
            // rbAniversare
            // 
            this.rbAniversare.AutoSize = true;
            this.rbAniversare.Location = new System.Drawing.Point(94, 33);
            this.rbAniversare.Name = "rbAniversare";
            this.rbAniversare.Size = new System.Drawing.Size(74, 17);
            this.rbAniversare.TabIndex = 1;
            this.rbAniversare.TabStop = true;
            this.rbAniversare.Text = "aniversare";
            this.rbAniversare.UseVisualStyleBackColor = true;
            // 
            // rbNunta
            // 
            this.rbNunta.AutoSize = true;
            this.rbNunta.Location = new System.Drawing.Point(94, 56);
            this.rbNunta.Name = "rbNunta";
            this.rbNunta.Size = new System.Drawing.Size(52, 17);
            this.rbNunta.TabIndex = 2;
            this.rbNunta.TabStop = true;
            this.rbNunta.Text = "nunta";
            this.rbNunta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip Eveniment";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(94, 79);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data";
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(94, 105);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(200, 20);
            this.txtLocatie.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Locatie";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(71, 146);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(152, 146);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 9;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            // 
            // dgvEvenimente
            // 
            this.dgvEvenimente.FormattingEnabled = true;
            this.dgvEvenimente.Location = new System.Drawing.Point(300, 12);
            this.dgvEvenimente.Name = "dgvEvenimente";
            this.dgvEvenimente.Size = new System.Drawing.Size(488, 160);
            this.dgvEvenimente.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 201);
            this.Controls.Add(this.dgvEvenimente);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNunta);
            this.Controls.Add(this.rbAniversare);
            this.Controls.Add(this.rbConferinta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbConferinta;
        private System.Windows.Forms.RadioButton rbAniversare;
        private System.Windows.Forms.RadioButton rbNunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.ListBox dgvEvenimente;
    }
}

