namespace ProyectoBases
{
    partial class EmpleadosTabla
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
            this.eliminarBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.idEmpleadoText = new System.Windows.Forms.TextBox();
            this.IdEmpleado = new System.Windows.Forms.Label();
            this.empleados = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarBTN
            // 
            this.eliminarBTN.Location = new System.Drawing.Point(619, 302);
            this.eliminarBTN.Name = "eliminarBTN";
            this.eliminarBTN.Size = new System.Drawing.Size(103, 47);
            this.eliminarBTN.TabIndex = 1;
            this.eliminarBTN.Text = "Eliminar";
            this.eliminarBTN.UseVisualStyleBackColor = true;
            this.eliminarBTN.Click += new System.EventHandler(this.eliminarBTN_Click);
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(619, 249);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(103, 47);
            this.ModificarBTN.TabIndex = 2;
            this.ModificarBTN.Text = "Modificar";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            this.ModificarBTN.Click += new System.EventHandler(this.ModificarBTN_Click);
            // 
            // idEmpleadoText
            // 
            this.idEmpleadoText.Location = new System.Drawing.Point(586, 177);
            this.idEmpleadoText.Name = "idEmpleadoText";
            this.idEmpleadoText.Size = new System.Drawing.Size(168, 26);
            this.idEmpleadoText.TabIndex = 70;
            this.idEmpleadoText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.AutoSize = true;
            this.IdEmpleado.Location = new System.Drawing.Point(615, 131);
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Size = new System.Drawing.Size(102, 20);
            this.IdEmpleado.TabIndex = 69;
            this.IdEmpleado.Text = "ID Empleado";
            // 
            // empleados
            // 
            this.empleados.AutoSize = true;
            this.empleados.Location = new System.Drawing.Point(357, 32);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(109, 20);
            this.empleados.TabIndex = 71;
            this.empleados.Text = "EMPLEADOS";
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(12, 81);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 51;
            this.tabla.RowTemplate.Height = 24;
            this.tabla.Size = new System.Drawing.Size(533, 365);
            this.tabla.TabIndex = 72;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // EmpleadosTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.empleados);
            this.Controls.Add(this.idEmpleadoText);
            this.Controls.Add(this.IdEmpleado);
            this.Controls.Add(this.ModificarBTN);
            this.Controls.Add(this.eliminarBTN);
            this.Name = "EmpleadosTabla";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmpleadosTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eliminarBTN;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.TextBox idEmpleadoText;
        private System.Windows.Forms.Label IdEmpleado;
        private System.Windows.Forms.Label empleados;
        private System.Windows.Forms.DataGridView tabla;
    }
}