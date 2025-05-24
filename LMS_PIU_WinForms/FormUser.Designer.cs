namespace LMS_PIU_WinForms
{
    partial class FormUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnImprumuta = new System.Windows.Forms.Button();
            this.btnReturneaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(62, 19);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(389, 20);
            this.txtCautare.TabIndex = 0;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(708, 201);
            this.dataGridViewBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cauta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.White;
            this.btnCauta.Location = new System.Drawing.Point(457, 12);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(99, 33);
            this.btnCauta.TabIndex = 5;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnImprumuta
            // 
            this.btnImprumuta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprumuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprumuta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprumuta.ForeColor = System.Drawing.Color.White;
            this.btnImprumuta.Location = new System.Drawing.Point(233, 258);
            this.btnImprumuta.Name = "btnImprumuta";
            this.btnImprumuta.Size = new System.Drawing.Size(126, 41);
            this.btnImprumuta.TabIndex = 6;
            this.btnImprumuta.Text = "Imprumuta";
            this.btnImprumuta.UseVisualStyleBackColor = false;
            this.btnImprumuta.Click += new System.EventHandler(this.btnImprumuta_Click);
            // 
            // btnReturneaza
            // 
            this.btnReturneaza.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReturneaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturneaza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturneaza.ForeColor = System.Drawing.Color.White;
            this.btnReturneaza.Location = new System.Drawing.Point(365, 258);
            this.btnReturneaza.Name = "btnReturneaza";
            this.btnReturneaza.Size = new System.Drawing.Size(126, 41);
            this.btnReturneaza.TabIndex = 7;
            this.btnReturneaza.Text = "Returneaza";
            this.btnReturneaza.UseVisualStyleBackColor = false;
            this.btnReturneaza.Click += new System.EventHandler(this.btnReturneaza_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 311);
            this.Controls.Add(this.btnReturneaza);
            this.Controls.Add(this.btnImprumuta);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.txtCautare);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnImprumuta;
        private System.Windows.Forms.Button btnReturneaza;
    }
}