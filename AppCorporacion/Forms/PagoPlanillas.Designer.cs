namespace AppCorporacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plantaCB = new System.Windows.Forms.ComboBox();
            this.idEmpleadoText = new System.Windows.Forms.TextBox();
            this.planillaLabel = new System.Windows.Forms.Label();
            this.pagarBTN = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.idPlanillaCB = new System.Windows.Forms.TextBox();
            this.idPlanilla = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planta";
            // 
            // plantaCB
            // 
            this.plantaCB.FormattingEnabled = true;
            this.plantaCB.Items.AddRange(new object[] {
            "Planta1",
            "Planta2",
            "Planta3"});
            this.plantaCB.Location = new System.Drawing.Point(602, 232);
            this.plantaCB.Name = "plantaCB";
            this.plantaCB.Size = new System.Drawing.Size(136, 28);
            this.plantaCB.TabIndex = 63;
            // 
            // idEmpleadoText
            // 
            this.idEmpleadoText.Location = new System.Drawing.Point(602, 187);
            this.idEmpleadoText.Name = "idEmpleadoText";
            this.idEmpleadoText.Size = new System.Drawing.Size(168, 26);
            this.idEmpleadoText.TabIndex = 71;
            // 
            // planillaLabel
            // 
            this.planillaLabel.AutoSize = true;
            this.planillaLabel.Location = new System.Drawing.Point(334, 59);
            this.planillaLabel.Name = "planillaLabel";
            this.planillaLabel.Size = new System.Drawing.Size(172, 20);
            this.planillaLabel.TabIndex = 72;
            this.planillaLabel.Text = "PAGO DE PLANILLAS";
            // 
            // pagarBTN
            // 
            this.pagarBTN.Location = new System.Drawing.Point(597, 324);
            this.pagarBTN.Name = "pagarBTN";
            this.pagarBTN.Size = new System.Drawing.Size(149, 43);
            this.pagarBTN.TabIndex = 73;
            this.pagarBTN.Text = "Pagar";
            this.pagarBTN.UseVisualStyleBackColor = true;
            this.pagarBTN.Click += new System.EventHandler(this.pagarBTN_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(442, 324);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(149, 43);
            this.volver.TabIndex = 74;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // idPlanillaCB
            // 
            this.idPlanillaCB.Location = new System.Drawing.Point(602, 139);
            this.idPlanillaCB.Name = "idPlanillaCB";
            this.idPlanillaCB.Size = new System.Drawing.Size(168, 26);
            this.idPlanillaCB.TabIndex = 76;
            // 
            // idPlanilla
            // 
            this.idPlanilla.AutoSize = true;
            this.idPlanilla.Location = new System.Drawing.Point(438, 139);
            this.idPlanilla.Name = "idPlanilla";
            this.idPlanilla.Size = new System.Drawing.Size(79, 20);
            this.idPlanilla.TabIndex = 75;
            this.idPlanilla.Text = "ID Planilla";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 77;
            // 
            // PagoPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.idPlanillaCB);
            this.Controls.Add(this.idPlanilla);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.pagarBTN);
            this.Controls.Add(this.planillaLabel);
            this.Controls.Add(this.idEmpleadoText);
            this.Controls.Add(this.plantaCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PagoPlanillas";
            this.Text = "PagoPlanillas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox plantaCB;
        private System.Windows.Forms.TextBox idEmpleadoText;
        private System.Windows.Forms.Label planillaLabel;
        private System.Windows.Forms.Button pagarBTN;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.TextBox idPlanillaCB;
        private System.Windows.Forms.Label idPlanilla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}