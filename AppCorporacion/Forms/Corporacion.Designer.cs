namespace AppCorporacion
{
    partial class Corporacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.empleadosBTN = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlanillasBTN = new System.Windows.Forms.Button();
            this.verPlanillas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.planta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planta3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoAguinaldoBTN = new System.Windows.Forms.Button();
            this.calculoAguinaldo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagoPlanillasBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Empleados.SuspendLayout();
            this.verPlanillas.SuspendLayout();
            this.SuspendLayout();
            // 
            // empleadosBTN
            // 
            this.empleadosBTN.ContextMenuStrip = this.Empleados;
            this.empleadosBTN.Location = new System.Drawing.Point(138, 141);
            this.empleadosBTN.Name = "empleadosBTN";
            this.empleadosBTN.Size = new System.Drawing.Size(195, 79);
            this.empleadosBTN.TabIndex = 1;
            this.empleadosBTN.Text = "Empleados";
            this.empleadosBTN.UseVisualStyleBackColor = true;
            this.empleadosBTN.Click += new System.EventHandler(this.empleado_Click);
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
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // verPlanillasBTN
            // 
            this.verPlanillasBTN.ContextMenuStrip = this.verPlanillas;
            this.verPlanillasBTN.Location = new System.Drawing.Point(476, 141);
            this.verPlanillasBTN.Name = "verPlanillasBTN";
            this.verPlanillasBTN.Size = new System.Drawing.Size(195, 79);
            this.verPlanillasBTN.TabIndex = 3;
            this.verPlanillasBTN.Text = "Ver planillas";
            this.verPlanillasBTN.UseVisualStyleBackColor = true;
            // 
            // verPlanillas
            // 
            this.verPlanillas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.verPlanillas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planta1ToolStripMenuItem,
            this.planta2ToolStripMenuItem,
            this.planta3ToolStripMenuItem});
            this.verPlanillas.Name = "contextMenuStrip1";
            this.verPlanillas.Size = new System.Drawing.Size(153, 100);
            // 
            // planta1ToolStripMenuItem
            // 
            this.planta1ToolStripMenuItem.Name = "planta1ToolStripMenuItem";
            this.planta1ToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.planta1ToolStripMenuItem.Text = "Planta 1";
            // 
            // planta2ToolStripMenuItem
            // 
            this.planta2ToolStripMenuItem.Name = "planta2ToolStripMenuItem";
            this.planta2ToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.planta2ToolStripMenuItem.Text = "Planta 2 ";
            // 
            // planta3ToolStripMenuItem
            // 
            this.planta3ToolStripMenuItem.Name = "planta3ToolStripMenuItem";
            this.planta3ToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.planta3ToolStripMenuItem.Text = "Planta 3";
            // 
            // calculoAguinaldoBTN
            // 
            this.calculoAguinaldoBTN.Location = new System.Drawing.Point(138, 248);
            this.calculoAguinaldoBTN.Name = "calculoAguinaldoBTN";
            this.calculoAguinaldoBTN.Size = new System.Drawing.Size(195, 79);
            this.calculoAguinaldoBTN.TabIndex = 5;
            this.calculoAguinaldoBTN.Text = "Calculo Aguinaldo";
            this.calculoAguinaldoBTN.UseVisualStyleBackColor = true;
            // 
            // calculoAguinaldo
            // 
            this.calculoAguinaldo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.calculoAguinaldo.Name = "calculoAguinaldo";
            this.calculoAguinaldo.Size = new System.Drawing.Size(61, 4);
            // 
            // pagoPlanillasBTN
            // 
            this.pagoPlanillasBTN.Location = new System.Drawing.Point(476, 248);
            this.pagoPlanillasBTN.Name = "pagoPlanillasBTN";
            this.pagoPlanillasBTN.Size = new System.Drawing.Size(195, 79);
            this.pagoPlanillasBTN.TabIndex = 7;
            this.pagoPlanillasBTN.Text = "Pago de planillas";
            this.pagoPlanillasBTN.UseVisualStyleBackColor = true;
            this.pagoPlanillasBTN.Click += new System.EventHandler(this.pagoPlanillasBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CORPORACION";
            // 
            // Corporacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagoPlanillasBTN);
            this.Controls.Add(this.calculoAguinaldoBTN);
            this.Controls.Add(this.verPlanillasBTN);
            this.Controls.Add(this.empleadosBTN);
            this.Name = "Corporacion";
            this.Text = "Corporacion";
            this.Load += new System.EventHandler(this.corporacion);
            this.Empleados.ResumeLayout(false);
            this.verPlanillas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empleadosBTN;
        private System.Windows.Forms.ContextMenuStrip Empleados;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button verPlanillasBTN;
        private System.Windows.Forms.ContextMenuStrip verPlanillas;
        private System.Windows.Forms.ToolStripMenuItem planta1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planta2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planta3ToolStripMenuItem;
        private System.Windows.Forms.Button calculoAguinaldoBTN;
        private System.Windows.Forms.ContextMenuStrip calculoAguinaldo;
        private System.Windows.Forms.Button pagoPlanillasBTN;
        private System.Windows.Forms.Label label1;
    }
}

