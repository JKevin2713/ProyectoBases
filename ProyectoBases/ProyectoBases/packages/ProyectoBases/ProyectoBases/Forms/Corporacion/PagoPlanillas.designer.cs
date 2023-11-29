namespace ProyectoBases
{
    partial class PagoPlanillas
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
            this.planillaLabel = new System.Windows.Forms.Label();
            this.pagarBTN = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.idPlanillaText = new System.Windows.Forms.TextBox();
            this.fechaPagoPlanilla = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TablaPagosP = new System.Windows.Forms.DataGridView();
            this.idPlanilla = new System.Windows.Forms.Label();
            this.ImportarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPagosP)).BeginInit();
            this.SuspendLayout();
            // 
            // planillaLabel
            // 
            this.planillaLabel.AutoSize = true;
            this.planillaLabel.Location = new System.Drawing.Point(535, 30);
            this.planillaLabel.Name = "planillaLabel";
            this.planillaLabel.Size = new System.Drawing.Size(172, 20);
            this.planillaLabel.TabIndex = 72;
            this.planillaLabel.Text = "PAGO DE PLANILLAS";
            // 
            // pagarBTN
            // 
            this.pagarBTN.Location = new System.Drawing.Point(927, 381);
            this.pagarBTN.Name = "pagarBTN";
            this.pagarBTN.Size = new System.Drawing.Size(149, 43);
            this.pagarBTN.TabIndex = 73;
            this.pagarBTN.Text = "Pagar";
            this.pagarBTN.UseVisualStyleBackColor = true;
            this.pagarBTN.Click += new System.EventHandler(this.pagarBTN_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(772, 381);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(149, 43);
            this.volver.TabIndex = 74;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // idPlanillaText
            // 
            this.idPlanillaText.Location = new System.Drawing.Point(908, 156);
            this.idPlanillaText.Name = "idPlanillaText";
            this.idPlanillaText.Size = new System.Drawing.Size(168, 26);
            this.idPlanillaText.TabIndex = 76;
            // 
            // fechaPagoPlanilla
            // 
            this.fechaPagoPlanilla.Location = new System.Drawing.Point(908, 211);
            this.fechaPagoPlanilla.MinDate = new System.DateTime(2023, 11, 26, 0, 0, 0, 0);
            this.fechaPagoPlanilla.Name = "fechaPagoPlanilla";
            this.fechaPagoPlanilla.Size = new System.Drawing.Size(168, 26);
            this.fechaPagoPlanilla.TabIndex = 78;
            this.fechaPagoPlanilla.ValueChanged += new System.EventHandler(this.fechaPagoPlanilla_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Fecha de pago";
            // 
            // TablaPagosP
            // 
            this.TablaPagosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPagosP.Location = new System.Drawing.Point(2, 112);
            this.TablaPagosP.Name = "TablaPagosP";
            this.TablaPagosP.RowHeadersWidth = 51;
            this.TablaPagosP.RowTemplate.Height = 24;
            this.TablaPagosP.Size = new System.Drawing.Size(736, 338);
            this.TablaPagosP.TabIndex = 80;
            this.TablaPagosP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla1_CellContentClick);
            // 
            // idPlanilla
            // 
            this.idPlanilla.AutoSize = true;
            this.idPlanilla.Location = new System.Drawing.Point(744, 156);
            this.idPlanilla.Name = "idPlanilla";
            this.idPlanilla.Size = new System.Drawing.Size(79, 20);
            this.idPlanilla.TabIndex = 75;
            this.idPlanilla.Text = "ID Planilla";
            // 
            // ImportarBTN
            // 
            this.ImportarBTN.Location = new System.Drawing.Point(847, 83);
            this.ImportarBTN.Name = "ImportarBTN";
            this.ImportarBTN.Size = new System.Drawing.Size(152, 45);
            this.ImportarBTN.TabIndex = 81;
            this.ImportarBTN.Text = "Importar planillas";
            this.ImportarBTN.UseVisualStyleBackColor = true;
            this.ImportarBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagoPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 462);
            this.Controls.Add(this.ImportarBTN);
            this.Controls.Add(this.TablaPagosP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaPagoPlanilla);
            this.Controls.Add(this.idPlanillaText);
            this.Controls.Add(this.idPlanilla);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.pagarBTN);
            this.Controls.Add(this.planillaLabel);
            this.Name = "PagoPlanillas";
            this.Text = "PagoPlanillas";
            this.Load += new System.EventHandler(this.PagoPlanillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPagosP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label planillaLabel;
        private System.Windows.Forms.Button pagarBTN;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.TextBox idPlanillaText;
        private System.Windows.Forms.DateTimePicker fechaPagoPlanilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TablaPagosP;
        private System.Windows.Forms.Label idPlanilla;
        private System.Windows.Forms.Button ImportarBTN;
    }
}