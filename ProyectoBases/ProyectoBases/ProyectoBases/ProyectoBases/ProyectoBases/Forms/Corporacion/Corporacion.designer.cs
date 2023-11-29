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
            this.Guayabo = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Central = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.laRomana = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultas = new System.Windows.Forms.Button();
            this.verPlanillas.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "CORPORACION";
            // 
            // pagoPlanillasBTN
            // 
            this.pagoPlanillasBTN.ContextMenuStrip = this.verPlanillas;
            this.pagoPlanillasBTN.Location = new System.Drawing.Point(416, 115);
            this.pagoPlanillasBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagoPlanillasBTN.Name = "pagoPlanillasBTN";
            this.pagoPlanillasBTN.Size = new System.Drawing.Size(173, 63);
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
            this.verPlanillasBTN.Location = new System.Drawing.Point(416, 201);
            this.verPlanillasBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verPlanillasBTN.Name = "verPlanillasBTN";
            this.verPlanillasBTN.Size = new System.Drawing.Size(173, 63);
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
            this.verPlanillas.Size = new System.Drawing.Size(153, 76);
            // 
            // GuayaboToolStripMenuItem
            // 
            this.GuayaboToolStripMenuItem.Name = "GuayaboToolStripMenuItem";
            this.GuayaboToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.GuayaboToolStripMenuItem.Text = "Guayabo";
            this.GuayaboToolStripMenuItem.Click += new System.EventHandler(this.GuayaboToolStripMenuItem_Click);
            // 
            // CentralToolStripMenuItem
            // 
            this.CentralToolStripMenuItem.Name = "CentralToolStripMenuItem";
            this.CentralToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.CentralToolStripMenuItem.Text = "Central";
            this.CentralToolStripMenuItem.Click += new System.EventHandler(this.CentralToolStripMenuItem_Click);
            // 
            // LaRomanaToolStripMenuItem
            // 
            this.LaRomanaToolStripMenuItem.Name = "LaRomanaToolStripMenuItem";
            this.LaRomanaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.LaRomanaToolStripMenuItem.Text = "La Romana";
            this.LaRomanaToolStripMenuItem.Click += new System.EventHandler(this.LaRomanaToolStripMenuItem_Click);
            // 
            // empleadosBTN
            // 
            this.empleadosBTN.ContextMenuStrip = this.Empleados;
            this.empleadosBTN.Location = new System.Drawing.Point(131, 115);
            this.empleadosBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empleadosBTN.Name = "empleadosBTN";
            this.empleadosBTN.Size = new System.Drawing.Size(173, 63);
            this.empleadosBTN.TabIndex = 9;
            this.empleadosBTN.Text = "Empleados";
            this.empleadosBTN.UseVisualStyleBackColor = true;
            this.empleadosBTN.Click += new System.EventHandler(this.empleadosBTN_Click);
            // 
            // Empleados
            // 
            this.Empleados.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Empleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guayabo,
            this.Central,
            this.laRomana});
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(153, 76);
            // 
            // Guayabo
            // 
            this.Guayabo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.Guayabo.Name = "Guayabo";
            this.Guayabo.Size = new System.Drawing.Size(152, 24);
            this.Guayabo.Text = "Guayabo";
            this.Guayabo.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // Central
            // 
            this.Central.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem2,
            this.modificarToolStripMenuItem2,
            this.eliminarToolStripMenuItem2});
            this.Central.Name = "Central";
            this.Central.Size = new System.Drawing.Size(152, 24);
            this.Central.Text = "Central";
            this.Central.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.registrarToolStripMenuItem2.Text = "Registrar ";
            this.registrarToolStripMenuItem2.Click += new System.EventHandler(this.registrarToolStripMenuItem2_Click);
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            this.modificarToolStripMenuItem2.Click += new System.EventHandler(this.modificarToolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // laRomana
            // 
            this.laRomana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem3,
            this.modificarToolStripMenuItem3,
            this.eliminarToolStripMenuItem3});
            this.laRomana.Name = "laRomana";
            this.laRomana.Size = new System.Drawing.Size(152, 24);
            this.laRomana.Text = "La Romana";
            this.laRomana.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem3
            // 
            this.registrarToolStripMenuItem3.Name = "registrarToolStripMenuItem3";
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(156, 26);
            this.registrarToolStripMenuItem3.Text = "Registrar";
            this.registrarToolStripMenuItem3.Click += new System.EventHandler(this.registrarToolStripMenuItem3_Click);
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            this.modificarToolStripMenuItem3.Click += new System.EventHandler(this.modificarToolStripMenuItem3_Click);
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(156, 26);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            this.eliminarToolStripMenuItem3.Click += new System.EventHandler(this.eliminarToolStripMenuItem3_Click);
            // 
            // Consultas
            // 
            this.Consultas.Location = new System.Drawing.Point(131, 201);
            this.Consultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(173, 63);
            this.Consultas.TabIndex = 17;
            this.Consultas.Text = "Consultas";
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.Consultas_Click);
            // 
            // Corporacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagoPlanillasBTN);
            this.Controls.Add(this.verPlanillasBTN);
            this.Controls.Add(this.empleadosBTN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem Guayabo;
        private System.Windows.Forms.ToolStripMenuItem Central;
        private System.Windows.Forms.ToolStripMenuItem laRomana;
        private System.Windows.Forms.ContextMenuStrip verPlanillas;
        private System.Windows.Forms.ToolStripMenuItem GuayaboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CentralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LaRomanaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip calculoAguinaldo;
        private System.Windows.Forms.Button Consultas;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
    }
}