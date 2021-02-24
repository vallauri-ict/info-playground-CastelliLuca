
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
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvDriverCountry = new System.Windows.Forms.DataGridView();
            this.btnFunction1 = new System.Windows.Forms.Button();
            this.btnFunction2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(12, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(323, 196);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsDeletedDriver);
            // 
            // dgvDriverCountry
            // 
            this.dgvDriverCountry.AllowUserToAddRows = false;
            this.dgvDriverCountry.AllowUserToDeleteRows = false;
            this.dgvDriverCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverCountry.Location = new System.Drawing.Point(12, 242);
            this.dgvDriverCountry.Name = "dgvDriverCountry";
            this.dgvDriverCountry.RowHeadersVisible = false;
            this.dgvDriverCountry.Size = new System.Drawing.Size(323, 196);
            this.dgvDriverCountry.TabIndex = 2;
            // 
            // btnFunction1
            // 
            this.btnFunction1.Location = new System.Drawing.Point(363, 13);
            this.btnFunction1.Name = "btnFunction1";
            this.btnFunction1.Size = new System.Drawing.Size(159, 23);
            this.btnFunction1.TabIndex = 3;
            this.btnFunction1.Text = "Function 1";
            this.btnFunction1.UseVisualStyleBackColor = true;
            this.btnFunction1.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // btnFunction2
            // 
            this.btnFunction2.Location = new System.Drawing.Point(363, 68);
            this.btnFunction2.Name = "btnFunction2";
            this.btnFunction2.Size = new System.Drawing.Size(159, 23);
            this.btnFunction2.TabIndex = 4;
            this.btnFunction2.Text = "Function 2";
            this.btnFunction2.UseVisualStyleBackColor = true;
            this.btnFunction2.Click += new System.EventHandler(this.btnFunction2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btnFunction2);
            this.Controls.Add(this.btnFunction1);
            this.Controls.Add(this.dgvDriverCountry);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvDriverCountry;
        private System.Windows.Forms.Button btnFunction1;
        private System.Windows.Forms.Button btnFunction2;
    }
}

