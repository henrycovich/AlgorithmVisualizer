
namespace Algorithm_Visualizer_2
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
            this.pnlSort = new System.Windows.Forms.PictureBox();
            this.cboAlg = new System.Windows.Forms.ComboBox();
            this.lblElementi = new System.Windows.Forms.Label();
            this.tbElementi = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdGenera = new System.Windows.Forms.Button();
            this.CmdOrdina = new System.Windows.Forms.Button();
            this.CmdEsci = new System.Windows.Forms.Button();
            this.CmdSalva = new System.Windows.Forms.Button();
            this.CmdRiprendi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbElementi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSort
            // 
            this.pnlSort.BackColor = System.Drawing.Color.White;
            this.pnlSort.Location = new System.Drawing.Point(12, 12);
            this.pnlSort.Name = "pnlSort";
            this.pnlSort.Size = new System.Drawing.Size(776, 292);
            this.pnlSort.TabIndex = 0;
            this.pnlSort.TabStop = false;
            // 
            // cboAlg
            // 
            this.cboAlg.FormattingEnabled = true;
            this.cboAlg.Items.AddRange(new object[] {
            "",
            "Bubble Sort",
            "Heap Sort",
            "Insertion Sort",
            "Merge Sort",
            "Quick Sort",
            "Selection Sort"});
            this.cboAlg.Location = new System.Drawing.Point(12, 310);
            this.cboAlg.Name = "cboAlg";
            this.cboAlg.Size = new System.Drawing.Size(370, 24);
            this.cboAlg.TabIndex = 1;
            // 
            // lblElementi
            // 
            this.lblElementi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementi.Location = new System.Drawing.Point(30, 376);
            this.lblElementi.Name = "lblElementi";
            this.lblElementi.Size = new System.Drawing.Size(174, 45);
            this.lblElementi.TabIndex = 3;
            this.lblElementi.Text = "Numero di elementi:";
            // 
            // tbElementi
            // 
            this.tbElementi.Location = new System.Drawing.Point(211, 376);
            this.tbElementi.Margin = new System.Windows.Forms.Padding(4);
            this.tbElementi.Maximum = 250;
            this.tbElementi.Minimum = 10;
            this.tbElementi.Name = "tbElementi";
            this.tbElementi.Size = new System.Drawing.Size(160, 56);
            this.tbElementi.SmallChange = 10;
            this.tbElementi.TabIndex = 9;
            this.tbElementi.TickFrequency = 10;
            this.tbElementi.Value = 20;
            this.tbElementi.Scroll += new System.EventHandler(this.tbElementi_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 15;
            // 
            // CmdGenera
            // 
            this.CmdGenera.Location = new System.Drawing.Point(491, 310);
            this.CmdGenera.Name = "CmdGenera";
            this.CmdGenera.Size = new System.Drawing.Size(95, 35);
            this.CmdGenera.TabIndex = 16;
            this.CmdGenera.Text = "GENERA";
            this.CmdGenera.UseVisualStyleBackColor = true;
            this.CmdGenera.Click += new System.EventHandler(this.CmdGenera_Click);
            // 
            // CmdOrdina
            // 
            this.CmdOrdina.Location = new System.Drawing.Point(693, 310);
            this.CmdOrdina.Name = "CmdOrdina";
            this.CmdOrdina.Size = new System.Drawing.Size(95, 35);
            this.CmdOrdina.TabIndex = 17;
            this.CmdOrdina.Text = "ORDINA";
            this.CmdOrdina.UseVisualStyleBackColor = true;
            this.CmdOrdina.Click += new System.EventHandler(this.CmdOrdina_Click);
            // 
            // CmdEsci
            // 
            this.CmdEsci.Location = new System.Drawing.Point(693, 460);
            this.CmdEsci.Name = "CmdEsci";
            this.CmdEsci.Size = new System.Drawing.Size(95, 35);
            this.CmdEsci.TabIndex = 18;
            this.CmdEsci.Text = "ESCI";
            this.CmdEsci.UseVisualStyleBackColor = true;
            this.CmdEsci.Click += new System.EventHandler(this.CmdEsci_Click);
            // 
            // CmdSalva
            // 
            this.CmdSalva.Location = new System.Drawing.Point(693, 376);
            this.CmdSalva.Name = "CmdSalva";
            this.CmdSalva.Size = new System.Drawing.Size(95, 35);
            this.CmdSalva.TabIndex = 20;
            this.CmdSalva.Text = "SALVA";
            this.CmdSalva.UseVisualStyleBackColor = true;
            this.CmdSalva.Click += new System.EventHandler(this.CmdSalva_Click);
            // 
            // CmdRiprendi
            // 
            this.CmdRiprendi.Location = new System.Drawing.Point(491, 376);
            this.CmdRiprendi.Name = "CmdRiprendi";
            this.CmdRiprendi.Size = new System.Drawing.Size(95, 35);
            this.CmdRiprendi.TabIndex = 21;
            this.CmdRiprendi.Text = "RIPRENDI";
            this.CmdRiprendi.UseVisualStyleBackColor = true;
            this.CmdRiprendi.Click += new System.EventHandler(this.CmdRiprendi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.CmdRiprendi);
            this.Controls.Add(this.CmdSalva);
            this.Controls.Add(this.CmdEsci);
            this.Controls.Add(this.CmdOrdina);
            this.Controls.Add(this.CmdGenera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbElementi);
            this.Controls.Add(this.lblElementi);
            this.Controls.Add(this.cboAlg);
            this.Controls.Add(this.pnlSort);
            this.Name = "Form1";
            this.Text = "Algorithm Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pnlSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbElementi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pnlSort;
        private System.Windows.Forms.ComboBox cboAlg;
        private System.Windows.Forms.Label lblElementi;
        private System.Windows.Forms.TrackBar tbElementi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdGenera;
        private System.Windows.Forms.Button CmdOrdina;
        private System.Windows.Forms.Button CmdEsci;
        private System.Windows.Forms.Button CmdSalva;
        private System.Windows.Forms.Button CmdRiprendi;
    }
}

