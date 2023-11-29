namespace ProyectoBases.Forms
{
    partial class PlanillasCanceladas
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
            this.TablaPagosP = new System.Windows.Forms.DataGridView();
            this.imprimirBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdPagoText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPagosP)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaPagosP
            // 
            this.TablaPagosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPagosP.Location = new System.Drawing.Point(3, 80);
            this.TablaPagosP.Name = "TablaPagosP";
            this.TablaPagosP.RowHeadersWidth = 51;
            this.TablaPagosP.RowTemplate.Height = 24;
            this.TablaPagosP.Size = new System.Drawing.Size(736, 338);
            this.TablaPagosP.TabIndex = 81;
            this.TablaPagosP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPagosP_CellContentClick);
            // 
            // imprimirBTN
            // 
            this.imprimirBTN.Location = new System.Drawing.Point(837, 272);
            this.imprimirBTN.Name = "imprimirBTN";
            this.imprimirBTN.Size = new System.Drawing.Size(118, 62);
            this.imprimirBTN.TabIndex = 82;
            this.imprimirBTN.Text = "imprimir comprobante";
            this.imprimirBTN.UseVisualStyleBackColor = true;
            this.imprimirBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "PLANILLAS CANCELADAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Indique el ID Pago que desea imprimir: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdPagoText
            // 
            this.IdPagoText.Location = new System.Drawing.Point(837, 205);
            this.IdPagoText.Name = "IdPagoText";
            this.IdPagoText.Size = new System.Drawing.Size(118, 26);
            this.IdPagoText.TabIndex = 85;
            this.IdPagoText.TextChanged += new System.EventHandler(this.IdPagoText_TextChanged);
            // 
            // PlanillasCanceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 461);
            this.Controls.Add(this.IdPagoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imprimirBTN);
            this.Controls.Add(this.TablaPagosP);
            this.Name = "PlanillasCanceladas";
            this.Text = "PlanillasCanceladas";
            this.Load += new System.EventHandler(this.PlanillasCanceladas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPagosP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaPagosP;
        private System.Windows.Forms.Button imprimirBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdPagoText;
    }
}