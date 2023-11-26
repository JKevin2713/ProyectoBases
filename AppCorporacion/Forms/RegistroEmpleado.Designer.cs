namespace AppCorporacion
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plantaCB = new System.Windows.Forms.ComboBox();
            this.hFinal = new System.Windows.Forms.ComboBox();
            this.DepCB = new System.Windows.Forms.ComboBox();
            this.minFinal = new System.Windows.Forms.ComboBox();
            this.minInicio = new System.Windows.Forms.ComboBox();
            this.PlantaLabel = new System.Windows.Forms.Label();
            this.SupervisorLabel = new System.Windows.Forms.Label();
            this.SupervisorCB = new System.Windows.Forms.ComboBox();
            this.cargarRegistro = new System.Windows.Forms.Button();
            this.DepLabel = new System.Windows.Forms.Label();
            this.CargoLabel = new System.Windows.Forms.Label();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hInicio = new System.Windows.Forms.ComboBox();
            this.HfinalLabel = new System.Windows.Forms.Label();
            this.HinicioLabel = new System.Windows.Forms.Label();
            this.salidaLabel = new System.Windows.Forms.Label();
            this.entradaLabel = new System.Windows.Forms.Label();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Operador de Máquina",
            "Especialista en Optimización de Procesos",
            "Ingeniero de Mantenimiento",
            "Electricista Industrial",
            "Coordinador de Distribución",
            "Analista de Recursos Humanos",
            "Contador",
            "Administrador de Sistemas",
            "Desarrollador de Software",
            "Representante de Ventas"});
            this.comboBox1.Location = new System.Drawing.Point(367, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 28);
            this.comboBox1.TabIndex = 63;
            // 
            // plantaCB
            // 
            this.plantaCB.FormattingEnabled = true;
            this.plantaCB.Items.AddRange(new object[] {
            "Planta1",
            "Planta2",
            "Planta3"});
            this.plantaCB.Location = new System.Drawing.Point(635, 159);
            this.plantaCB.Name = "plantaCB";
            this.plantaCB.Size = new System.Drawing.Size(136, 28);
            this.plantaCB.TabIndex = 62;
            // 
            // hFinal
            // 
            this.hFinal.FormattingEnabled = true;
            this.hFinal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.hFinal.Location = new System.Drawing.Point(572, 302);
            this.hFinal.Name = "hFinal";
            this.hFinal.Size = new System.Drawing.Size(53, 28);
            this.hFinal.TabIndex = 61;
            // 
            // DepCB
            // 
            this.DepCB.FormattingEnabled = true;
            this.DepCB.Items.AddRange(new object[] {
            "Producción/Manufactura",
            "Ingeniería de Procesos",
            "Mantenimiento",
            "Recursos Humanos",
            "Finanzas",
            "Tecnologías de la Información (TI)",
            "Ventas y Marketing"});
            this.DepCB.Location = new System.Drawing.Point(367, 159);
            this.DepCB.Name = "DepCB";
            this.DepCB.Size = new System.Drawing.Size(159, 28);
            this.DepCB.TabIndex = 60;
            // 
            // minFinal
            // 
            this.minFinal.FormattingEnabled = true;
            this.minFinal.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minFinal.Location = new System.Drawing.Point(650, 302);
            this.minFinal.Name = "minFinal";
            this.minFinal.Size = new System.Drawing.Size(53, 28);
            this.minFinal.TabIndex = 59;
            // 
            // minInicio
            // 
            this.minInicio.FormattingEnabled = true;
            this.minInicio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minInicio.Location = new System.Drawing.Point(650, 243);
            this.minInicio.Name = "minInicio";
            this.minInicio.Size = new System.Drawing.Size(53, 28);
            this.minInicio.TabIndex = 58;
            // 
            // PlantaLabel
            // 
            this.PlantaLabel.AutoSize = true;
            this.PlantaLabel.Location = new System.Drawing.Point(532, 167);
            this.PlantaLabel.Name = "PlantaLabel";
            this.PlantaLabel.Size = new System.Drawing.Size(54, 20);
            this.PlantaLabel.TabIndex = 57;
            this.PlantaLabel.Text = "Planta";
            // 
            // SupervisorLabel
            // 
            this.SupervisorLabel.AutoSize = true;
            this.SupervisorLabel.Location = new System.Drawing.Point(532, 104);
            this.SupervisorLabel.Name = "SupervisorLabel";
            this.SupervisorLabel.Size = new System.Drawing.Size(84, 20);
            this.SupervisorLabel.TabIndex = 56;
            this.SupervisorLabel.Text = "Supervisor";
            // 
            // SupervisorCB
            // 
            this.SupervisorCB.FormattingEnabled = true;
            this.SupervisorCB.Items.AddRange(new object[] {
            "Supervisor de Producción",
            "Ingeniero de Procesos\t",
            "Técnico de Mantenimiento",
            "Gerente de Logística",
            "Director de Recursos Humanos",
            "Director Financiero",
            "Director de TI",
            "Director de Ventas"});
            this.SupervisorCB.Location = new System.Drawing.Point(635, 96);
            this.SupervisorCB.Name = "SupervisorCB";
            this.SupervisorCB.Size = new System.Drawing.Size(136, 28);
            this.SupervisorCB.TabIndex = 55;
            // 
            // cargarRegistro
            // 
            this.cargarRegistro.Location = new System.Drawing.Point(622, 377);
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
            this.DepLabel.Location = new System.Drawing.Point(249, 167);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(112, 20);
            this.DepLabel.TabIndex = 53;
            this.DepLabel.Text = "Departamento";
            // 
            // CargoLabel
            // 
            this.CargoLabel.AutoSize = true;
            this.CargoLabel.Location = new System.Drawing.Point(259, 104);
            this.CargoLabel.Name = "CargoLabel";
            this.CargoLabel.Size = new System.Drawing.Size(52, 20);
            this.CargoLabel.TabIndex = 52;
            this.CargoLabel.Text = "Cargo";
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(123, 153);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(115, 26);
            this.ApellidoText.TabIndex = 51;
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Location = new System.Drawing.Point(30, 162);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(73, 20);
            this.ApellidosLabel.TabIndex = 50;
            this.ApellidosLabel.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = ":";
            // 
            // hInicio
            // 
            this.hInicio.FormattingEnabled = true;
            this.hInicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.hInicio.Location = new System.Drawing.Point(572, 243);
            this.hInicio.Name = "hInicio";
            this.hInicio.Size = new System.Drawing.Size(53, 28);
            this.hInicio.TabIndex = 47;
            // 
            // HfinalLabel
            // 
            this.HfinalLabel.AutoSize = true;
            this.HfinalLabel.Location = new System.Drawing.Point(457, 310);
            this.HfinalLabel.Name = "HfinalLabel";
            this.HfinalLabel.Size = new System.Drawing.Size(77, 20);
            this.HfinalLabel.TabIndex = 46;
            this.HfinalLabel.Text = "Hora final";
            // 
            // HinicioLabel
            // 
            this.HinicioLabel.AutoSize = true;
            this.HinicioLabel.Location = new System.Drawing.Point(457, 244);
            this.HinicioLabel.Name = "HinicioLabel";
            this.HinicioLabel.Size = new System.Drawing.Size(83, 20);
            this.HinicioLabel.TabIndex = 45;
            this.HinicioLabel.Text = "Hora inicio";
            // 
            // salidaLabel
            // 
            this.salidaLabel.AutoSize = true;
            this.salidaLabel.Location = new System.Drawing.Point(88, 313);
            this.salidaLabel.Name = "salidaLabel";
            this.salidaLabel.Size = new System.Drawing.Size(53, 20);
            this.salidaLabel.TabIndex = 44;
            this.salidaLabel.Text = "Salida";
            // 
            // entradaLabel
            // 
            this.entradaLabel.AutoSize = true;
            this.entradaLabel.Location = new System.Drawing.Point(88, 247);
            this.entradaLabel.Name = "entradaLabel";
            this.entradaLabel.Size = new System.Drawing.Size(66, 20);
            this.entradaLabel.TabIndex = 43;
            this.entradaLabel.Text = "Entrada";
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Location = new System.Drawing.Point(196, 307);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(200, 26);
            this.dateTimeSalida.TabIndex = 42;
            // 
            // dateTimeEntrada
            // 
            this.dateTimeEntrada.Location = new System.Drawing.Point(196, 241);
            this.dateTimeEntrada.Name = "dateTimeEntrada";
            this.dateTimeEntrada.Size = new System.Drawing.Size(200, 26);
            this.dateTimeEntrada.TabIndex = 41;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(123, 98);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(115, 26);
            this.NombreText.TabIndex = 40;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(30, 107);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(65, 20);
            this.NombreLabel.TabIndex = 39;
            this.NombreLabel.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "REGISTRO EMPLEADO";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(461, 377);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(149, 43);
            this.volver.TabIndex = 64;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.plantaCB);
            this.Controls.Add(this.hFinal);
            this.Controls.Add(this.DepCB);
            this.Controls.Add(this.minFinal);
            this.Controls.Add(this.minInicio);
            this.Controls.Add(this.PlantaLabel);
            this.Controls.Add(this.SupervisorLabel);
            this.Controls.Add(this.SupervisorCB);
            this.Controls.Add(this.cargarRegistro);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.CargoLabel);
            this.Controls.Add(this.ApellidoText);
            this.Controls.Add(this.ApellidosLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hInicio);
            this.Controls.Add(this.HfinalLabel);
            this.Controls.Add(this.HinicioLabel);
            this.Controls.Add(this.salidaLabel);
            this.Controls.Add(this.entradaLabel);
            this.Controls.Add(this.dateTimeSalida);
            this.Controls.Add(this.dateTimeEntrada);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEmpleado";
            this.Text = "RegistroEmpleado";
            this.Load += new System.EventHandler(this.RegistroEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox plantaCB;
        private System.Windows.Forms.ComboBox hFinal;
        private System.Windows.Forms.ComboBox DepCB;
        private System.Windows.Forms.ComboBox minFinal;
        private System.Windows.Forms.ComboBox minInicio;
        private System.Windows.Forms.Label PlantaLabel;
        private System.Windows.Forms.Label SupervisorLabel;
        private System.Windows.Forms.ComboBox SupervisorCB;
        private System.Windows.Forms.Button cargarRegistro;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.Label CargoLabel;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox hInicio;
        private System.Windows.Forms.Label HfinalLabel;
        private System.Windows.Forms.Label HinicioLabel;
        private System.Windows.Forms.Label salidaLabel;
        private System.Windows.Forms.Label entradaLabel;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.DateTimePicker dateTimeEntrada;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volver;
    }
}