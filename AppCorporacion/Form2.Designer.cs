namespace AppCorporacion
{
    partial class Empleado
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
            this.regEmpleado = new System.Windows.Forms.Button();
            this.ModEmpleado = new System.Windows.Forms.Button();
            this.elimEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regEmpleado
            // 
            this.regEmpleado.Location = new System.Drawing.Point(301, 107);
            this.regEmpleado.Name = "regEmpleado";
            this.regEmpleado.Size = new System.Drawing.Size(195, 79);
            this.regEmpleado.TabIndex = 0;
            this.regEmpleado.Text = "Registrar Empleado";
            this.regEmpleado.UseVisualStyleBackColor = true;
            // 
            // ModEmpleado
            // 
            this.ModEmpleado.Location = new System.Drawing.Point(301, 192);
            this.ModEmpleado.Name = "ModEmpleado";
            this.ModEmpleado.Size = new System.Drawing.Size(195, 79);
            this.ModEmpleado.TabIndex = 1;
            this.ModEmpleado.Text = "Modificar Empleado";
            this.ModEmpleado.UseVisualStyleBackColor = true;
            // 
            // elimEmpleado
            // 
            this.elimEmpleado.Location = new System.Drawing.Point(301, 277);
            this.elimEmpleado.Name = "elimEmpleado";
            this.elimEmpleado.Size = new System.Drawing.Size(195, 79);
            this.elimEmpleado.TabIndex = 2;
            this.elimEmpleado.Text = "Eliminar Empleado";
            this.elimEmpleado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empleado";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elimEmpleado);
            this.Controls.Add(this.ModEmpleado);
            this.Controls.Add(this.regEmpleado);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regEmpleado;
        private System.Windows.Forms.Button ModEmpleado;
        private System.Windows.Forms.Button elimEmpleado;
        private System.Windows.Forms.Label label1;
    }
}