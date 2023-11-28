namespace ProyectoBases
{
    partial class RegistroEmpleado
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
            this.cargoCB = new System.Windows.Forms.ComboBox();
            this.plantaCB = new System.Windows.Forms.ComboBox();
            this.DepCB = new System.Windows.Forms.ComboBox();
            this.PlantaLabel = new System.Windows.Forms.Label();
            this.SupervisorLabel = new System.Windows.Forms.Label();
            this.SupervisorCB = new System.Windows.Forms.ComboBox();
            this.cargarRegistro = new System.Windows.Forms.Button();
            this.DepLabel = new System.Windows.Forms.Label();
            this.CargoLabel = new System.Windows.Forms.Label();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.HfinalLabel = new System.Windows.Forms.Label();
            this.HinicioLabel = new System.Windows.Forms.Label();
            this.salidaLabel = new System.Windows.Forms.Label();
            this.entradaLabel = new System.Windows.Forms.Label();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.horainicial = new System.Windows.Forms.DateTimePicker();
            this.horafinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cargoCB
            // 
            this.cargoCB.FormattingEnabled = true;
            this.cargoCB.Location = new System.Drawing.Point(446, 110);
            this.cargoCB.Name = "cargoCB";
            this.cargoCB.Size = new System.Drawing.Size(159, 28);
            this.cargoCB.TabIndex = 63;
            this.cargoCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // plantaCB
            // 
            this.plantaCB.FormattingEnabled = true;
            this.plantaCB.Items.AddRange(new object[] {
            "Guayabo",
            "Central",
            "La Romana"});
            this.plantaCB.Location = new System.Drawing.Point(714, 162);
            this.plantaCB.Name = "plantaCB";
            this.plantaCB.Size = new System.Drawing.Size(136, 28);
            this.plantaCB.TabIndex = 62;
            this.plantaCB.SelectedIndexChanged += new System.EventHandler(this.plantaCB_SelectedIndexChanged);
            // 
            // DepCB
            // 
            this.DepCB.FormattingEnabled = true;
            this.DepCB.Location = new System.Drawing.Point(446, 162);
            this.DepCB.Name = "DepCB";
            this.DepCB.Size = new System.Drawing.Size(159, 28);
            this.DepCB.TabIndex = 60;
            this.DepCB.SelectedIndexChanged += new System.EventHandler(this.DepCB_SelectedIndexChanged);
            // 
            // PlantaLabel
            // 
            this.PlantaLabel.AutoSize = true;
            this.PlantaLabel.Location = new System.Drawing.Point(611, 170);
            this.PlantaLabel.Name = "PlantaLabel";
            this.PlantaLabel.Size = new System.Drawing.Size(54, 20);
            this.PlantaLabel.TabIndex = 57;
            this.PlantaLabel.Text = "Planta";
            // 
            // SupervisorLabel
            // 
            this.SupervisorLabel.AutoSize = true;
            this.SupervisorLabel.Location = new System.Drawing.Point(611, 107);
            this.SupervisorLabel.Name = "SupervisorLabel";
            this.SupervisorLabel.Size = new System.Drawing.Size(84, 20);
            this.SupervisorLabel.TabIndex = 56;
            this.SupervisorLabel.Text = "Supervisor";
            // 
            // SupervisorCB
            // 
            this.SupervisorCB.FormattingEnabled = true;
            this.SupervisorCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.SupervisorCB.Location = new System.Drawing.Point(714, 99);
            this.SupervisorCB.Name = "SupervisorCB";
            this.SupervisorCB.Size = new System.Drawing.Size(136, 28);
            this.SupervisorCB.TabIndex = 55;
            this.SupervisorCB.SelectedIndexChanged += new System.EventHandler(this.SupervisorCB_SelectedIndexChanged);
            // 
            // cargarRegistro
            // 
            this.cargarRegistro.Location = new System.Drawing.Point(790, 377);
            this.cargarRegistro.Name = "cargarRegistro";
            this.cargarRegistro.Size = new System.Drawing.Size(149, 43);
            this.cargarRegistro.TabIndex = 54;
            this.cargarRegistro.Text = "Cargar registro";
            this.cargarRegistro.UseVisualStyleBackColor = true;
            this.cargarRegistro.Click += new System.EventHandler(this.cargarRegistro_Click);
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.Location = new System.Drawing.Point(328, 170);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(112, 20);
            this.DepLabel.TabIndex = 53;
            this.DepLabel.Text = "Departamento";
            // 
            // CargoLabel
            // 
            this.CargoLabel.AutoSize = true;
            this.CargoLabel.Location = new System.Drawing.Point(338, 107);
            this.CargoLabel.Name = "CargoLabel";
            this.CargoLabel.Size = new System.Drawing.Size(52, 20);
            this.CargoLabel.TabIndex = 52;
            this.CargoLabel.Text = "Cargo";
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(139, 162);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(115, 26);
            this.ApellidoText.TabIndex = 51;
            this.ApellidoText.TextChanged += new System.EventHandler(this.ApellidoText_TextChanged);
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Location = new System.Drawing.Point(46, 171);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(73, 20);
            this.ApellidosLabel.TabIndex = 50;
            this.ApellidosLabel.Text = "Apellidos";
            // 
            // HfinalLabel
            // 
            this.HfinalLabel.AutoSize = true;
            this.HfinalLabel.Location = new System.Drawing.Point(625, 310);
            this.HfinalLabel.Name = "HfinalLabel";
            this.HfinalLabel.Size = new System.Drawing.Size(77, 20);
            this.HfinalLabel.TabIndex = 46;
            this.HfinalLabel.Text = "Hora final";
            // 
            // HinicioLabel
            // 
            this.HinicioLabel.AutoSize = true;
            this.HinicioLabel.Location = new System.Drawing.Point(625, 244);
            this.HinicioLabel.Name = "HinicioLabel";
            this.HinicioLabel.Size = new System.Drawing.Size(83, 20);
            this.HinicioLabel.TabIndex = 45;
            this.HinicioLabel.Text = "Hora inicio";
            // 
            // salidaLabel
            // 
            this.salidaLabel.AutoSize = true;
            this.salidaLabel.Location = new System.Drawing.Point(256, 313);
            this.salidaLabel.Name = "salidaLabel";
            this.salidaLabel.Size = new System.Drawing.Size(53, 20);
            this.salidaLabel.TabIndex = 44;
            this.salidaLabel.Text = "Salida";
            // 
            // entradaLabel
            // 
            this.entradaLabel.AutoSize = true;
            this.entradaLabel.Location = new System.Drawing.Point(256, 247);
            this.entradaLabel.Name = "entradaLabel";
            this.entradaLabel.Size = new System.Drawing.Size(66, 20);
            this.entradaLabel.TabIndex = 43;
            this.entradaLabel.Text = "Entrada";
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Location = new System.Drawing.Point(364, 307);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(200, 26);
            this.dateTimeSalida.TabIndex = 42;
            // 
            // dateTimeEntrada
            // 
            this.dateTimeEntrada.Location = new System.Drawing.Point(364, 241);
            this.dateTimeEntrada.Name = "dateTimeEntrada";
            this.dateTimeEntrada.Size = new System.Drawing.Size(200, 26);
            this.dateTimeEntrada.TabIndex = 41;
            this.dateTimeEntrada.ValueChanged += new System.EventHandler(this.dateTimeEntrada_ValueChanged);
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(139, 107);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(115, 26);
            this.NombreText.TabIndex = 40;
            this.NombreText.TextChanged += new System.EventHandler(this.NombreText_TextChanged);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(46, 116);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(65, 20);
            this.NombreLabel.TabIndex = 39;
            this.NombreLabel.Text = "Nombre";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(360, 30);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(187, 20);
            this.texto.TabIndex = 38;
            this.texto.Text = "REGISTRO EMPLEADO";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(629, 377);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(149, 43);
            this.volver.TabIndex = 64;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // horainicial
            // 
            this.horainicial.Location = new System.Drawing.Point(714, 242);
            this.horainicial.Name = "horainicial";
            this.horainicial.Size = new System.Drawing.Size(200, 26);
            this.horainicial.TabIndex = 65;
            this.horainicial.ValueChanged += new System.EventHandler(this.horainicial_ValueChanged);
            // 
            // horafinal
            // 
            this.horafinal.Location = new System.Drawing.Point(714, 305);
            this.horafinal.Name = "horafinal";
            this.horafinal.Size = new System.Drawing.Size(200, 26);
            this.horafinal.TabIndex = 66;
            this.horafinal.ValueChanged += new System.EventHandler(this.horafinal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Calendario";
            // 
            // calendario
            // 
            this.calendario.FormattingEnabled = true;
            this.calendario.Location = new System.Drawing.Point(133, 244);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(117, 28);
            this.calendario.TabIndex = 68;
            this.calendario.SelectedIndexChanged += new System.EventHandler(this.calendario_SelectedIndexChanged);
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horafinal);
            this.Controls.Add(this.horainicial);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.cargoCB);
            this.Controls.Add(this.plantaCB);
            this.Controls.Add(this.DepCB);
            this.Controls.Add(this.PlantaLabel);
            this.Controls.Add(this.SupervisorLabel);
            this.Controls.Add(this.SupervisorCB);
            this.Controls.Add(this.cargarRegistro);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.CargoLabel);
            this.Controls.Add(this.ApellidoText);
            this.Controls.Add(this.ApellidosLabel);
            this.Controls.Add(this.HfinalLabel);
            this.Controls.Add(this.HinicioLabel);
            this.Controls.Add(this.salidaLabel);
            this.Controls.Add(this.entradaLabel);
            this.Controls.Add(this.dateTimeSalida);
            this.Controls.Add(this.dateTimeEntrada);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.texto);
            this.Name = "RegistroEmpleado";
            this.Text = "RegistroEmpleado";
            this.Load += new System.EventHandler(this.RegistroEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cargoCB;
        private System.Windows.Forms.ComboBox plantaCB;
        private System.Windows.Forms.ComboBox DepCB;
        private System.Windows.Forms.Label PlantaLabel;
        private System.Windows.Forms.Label SupervisorLabel;
        private System.Windows.Forms.ComboBox SupervisorCB;
        private System.Windows.Forms.Button cargarRegistro;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.Label CargoLabel;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.Label HfinalLabel;
        private System.Windows.Forms.Label HinicioLabel;
        private System.Windows.Forms.Label salidaLabel;
        private System.Windows.Forms.Label entradaLabel;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.DateTimePicker dateTimeEntrada;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.DateTimePicker horainicial;
        private System.Windows.Forms.DateTimePicker horafinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox calendario;
    }
}