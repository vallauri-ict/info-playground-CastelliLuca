
namespace TriggerTestAssieme
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAggiornamenti = new System.Windows.Forms.DataGridView();
            this.dgvCancellazioni = new System.Windows.Forms.DataGridView();
            this.btnFunction1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAggiornamenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancellazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAggiornamenti
            // 
            this.dgvAggiornamenti.AllowUserToAddRows = false;
            this.dgvAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAggiornamenti.Location = new System.Drawing.Point(12, 13);
            this.dgvAggiornamenti.Name = "dgvAggiornamenti";
            this.dgvAggiornamenti.Size = new System.Drawing.Size(323, 196);
            this.dgvAggiornamenti.TabIndex = 0;
            // 
            // dgvCancellazioni
            // 
            this.dgvCancellazioni.AllowUserToAddRows = false;
            this.dgvCancellazioni.AllowUserToDeleteRows = false;
            this.dgvCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancellazioni.Location = new System.Drawing.Point(12, 242);
            this.dgvCancellazioni.Name = "dgvCancellazioni";
            this.dgvCancellazioni.RowHeadersVisible = false;
            this.dgvCancellazioni.Size = new System.Drawing.Size(323, 196);
            this.dgvCancellazioni.TabIndex = 2;
            // 
            // btnFunction1
            // 
            this.btnFunction1.Location = new System.Drawing.Point(363, 13);
            this.btnFunction1.Name = "btnFunction1";
            this.btnFunction1.Size = new System.Drawing.Size(159, 23);
            this.btnFunction1.TabIndex = 3;
            this.btnFunction1.Text = "Carica";
            this.btnFunction1.UseVisualStyleBackColor = true;
            this.btnFunction1.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btnFunction1);
            this.Controls.Add(this.dgvCancellazioni);
            this.Controls.Add(this.dgvAggiornamenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAggiornamenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancellazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAggiornamenti;
        private System.Windows.Forms.DataGridView dgvCancellazioni;
        private System.Windows.Forms.Button btnFunction1;
    }
}

