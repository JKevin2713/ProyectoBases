namespace ProyectoBases
{
    partial class Corporacion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pagoPlanillasBTN = new System.Windows.Forms.Button();
            this.calculoAguinaldo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verPlanillasBTN = new System.Windows.Forms.Button();
            this.verPlanillas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GuayaboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CentralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaRomanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosBTN = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultas = new System.Windows.Forms.Button();
            this.verPlanillas.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "CORPORACION";
            // 
            // pagoPlanillasBTN
            // 
            this.pagoPlanillasBTN.Location = new System.Drawing.Point(468, 144);
            this.pagoPlanillasBTN.Name = "pagoPlanillasBTN";
            this.pagoPlanillasBTN.Size = new System.Drawing.Size(195, 79);
            this.pagoPlanillasBTN.TabIndex = 12;
            this.pagoPlanillasBTN.Text = "Pagar planillas";
            this.pagoPlanillasBTN.UseVisualStyleBackColor = true;
            this.pagoPlanillasBTN.Click += new System.EventHandler(this.pagoPlanillasBTN_Click);
            // 
            // calculoAguinaldo
            // 
            this.calculoAguinaldo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.calculoAguinaldo.Name = "calculoAguinaldo";
            this.calculoAguinaldo.Size = new System.Drawing.Size(61, 4);
            // 
            // verPlanillasBTN
            // 
            this.verPlanillasBTN.ContextMenuStrip = this.verPlanillas;
            this.verPlanillasBTN.Location = new System.Drawing.Point(468, 251);
            this.verPlanillasBTN.Name = "verPlanillasBTN";
            this.verPlanillasBTN.Size = new System.Drawing.Size(195, 79);
            this.verPlanillasBTN.TabIndex = 10;
            this.verPlanillasBTN.Text = "Imprimir planillas";
            this.verPlanillasBTN.UseVisualStyleBackColor = true;
            this.verPlanillasBTN.Click += new System.EventHandler(this.verPlanillasBTN_Click);
            // 
            // verPlanillas
            // 
            this.verPlanillas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.verPlanillas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuayaboToolStripMenuItem,
            this.CentralToolStripMenuItem,
            this.LaRomanaToolStripMenuItem});
            this.verPlanillas.Name = "contextMenuStrip1";
            this.verPlanillas.Size = new System.Drawing.Size(172, 100);
            // 
            // GuayaboToolStripMenuItem
            // 
            this.GuayaboToolStripMenuItem.Name = "GuayaboToolStripMenuItem";
            this.GuayaboToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.GuayaboToolStripMenuItem.Text = "Guayabo";
            this.GuayaboToolStripMenuItem.Click += new System.EventHandler(this.GuayaboToolStripMenuItem_Click);
            // 
            // CentralToolStripMenuItem
            // 
            this.CentralToolStripMenuItem.Name = "CentralToolStripMenuItem";
            this.CentralToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.CentralToolStripMenuItem.Text = "Central";
            // 
            // LaRomanaToolStripMenuItem
            // 
            this.LaRomanaToolStripMenuItem.Name = "LaRomanaToolStripMenuItem";
            this.LaRomanaToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.LaRomanaToolStripMenuItem.Text = "La Romana";
            // 
            // empleadosBTN
            // 
            this.empleadosBTN.ContextMenuStrip = this.Empleados;
            this.empleadosBTN.Location = new System.Drawing.Point(147, 144);
            this.empleadosBTN.Name = "empleadosBTN";
            this.empleadosBTN.Size = new System.Drawing.Size(195, 79);
            this.empleadosBTN.TabIndex = 9;
            this.empleadosBTN.Text = "Empleados";
            this.empleadosBTN.UseVisualStyleBackColor = true;
            this.empleadosBTN.Click += new System.EventHandler(this.empleadosBTN_Click);
            // 
            // Empleados
            // 
            this.Empleados.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Empleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(160, 100);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Consultas
            // 
            this.Consultas.Location = new System.Drawing.Point(147, 251);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(195, 79);
            this.Consultas.TabIndex = 17;
            this.Consultas.Text = "Consultas";
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.Consultas_Click);
            // 
            // Corporacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagoPlanillasBTN);
            this.Controls.Add(this.verPlanillasBTN);
            this.Controls.Add(this.empleadosBTN);
            this.Name = "Corporacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Corporacion_Load);
            this.verPlanillas.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pagoPlanillasBTN;
        private System.Windows.Forms.Button verPlanillasBTN;
        private System.Windows.Forms.Button empleadosBTN;
        private System.Windows.Forms.ContextMenuStrip Empleados;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip verPlanillas;
        private System.Windows.Forms.ToolStripMenuItem GuayaboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CentralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LaRomanaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip calculoAguinaldo;
        private System.Windows.Forms.Button Consultas;
    }
}