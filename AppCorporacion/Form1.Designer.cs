namespace AppCorporacion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.dateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.entradaLabel = new System.Windows.Forms.Label();
            this.salidaLabel = new System.Windows.Forms.Label();
            this.HinicioLabel = new System.Windows.Forms.Label();
            this.HfinalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.CargoLabel = new System.Windows.Forms.Label();
            this.DepLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PlantaLabel = new System.Windows.Forms.Label();
            this.SupervisorLabel = new System.Windows.Forms.Label();
            this.SupervisorCB = new System.Windows.Forms.ComboBox();
            this.hInicio = new System.Windows.Forms.ComboBox();
            this.minInicio = new System.Windows.Forms.ComboBox();
            this.minFinal = new System.Windows.Forms.ComboBox();
            this.DepCB = new System.Windows.Forms.ComboBox();
            this.hFinal = new System.Windows.Forms.ComboBox();
            this.plantaCB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(29, 108);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(65, 20);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(122, 99);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(115, 26);
            this.NombreText.TabIndex = 2;
            // 
            // dateTimeEntrada
            // 
            this.dateTimeEntrada.Location = new System.Drawing.Point(195, 242);
            this.dateTimeEntrada.Name = "dateTimeEntrada";
            this.dateTimeEntrada.Size = new System.Drawing.Size(200, 26);
            this.dateTimeEntrada.TabIndex = 5;
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Location = new System.Drawing.Point(195, 308);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(200, 26);
            this.dateTimeSalida.TabIndex = 6;
            // 
            // entradaLabel
            // 
            this.entradaLabel.AutoSize = true;
            this.entradaLabel.Location = new System.Drawing.Point(87, 248);
            this.entradaLabel.Name = "entradaLabel";
            this.entradaLabel.Size = new System.Drawing.Size(66, 20);
            this.entradaLabel.TabIndex = 7;
            this.entradaLabel.Text = "Entrada";
            // 
            // salidaLabel
            // 
            this.salidaLabel.AutoSize = true;
            this.salidaLabel.Location = new System.Drawing.Point(87, 314);
            this.salidaLabel.Name = "salidaLabel";
            this.salidaLabel.Size = new System.Drawing.Size(53, 20);
            this.salidaLabel.TabIndex = 8;
            this.salidaLabel.Text = "Salida";
            this.salidaLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // HinicioLabel
            // 
            this.HinicioLabel.AutoSize = true;
            this.HinicioLabel.Location = new System.Drawing.Point(456, 245);
            this.HinicioLabel.Name = "HinicioLabel";
            this.HinicioLabel.Size = new System.Drawing.Size(83, 20);
            this.HinicioLabel.TabIndex = 9;
            this.HinicioLabel.Text = "Hora inicio";
            this.HinicioLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // HfinalLabel
            // 
            this.HfinalLabel.AutoSize = true;
            this.HfinalLabel.Location = new System.Drawing.Point(456, 311);
            this.HfinalLabel.Name = "HfinalLabel";
            this.HfinalLabel.Size = new System.Drawing.Size(77, 20);
            this.HfinalLabel.TabIndex = 10;
            this.HfinalLabel.Text = "Hora final";
            this.HfinalLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = ":";
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(122, 154);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(115, 26);
            this.ApellidoText.TabIndex = 19;
            this.ApellidoText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Location = new System.Drawing.Point(32, 160);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(73, 20);
            this.ApellidosLabel.TabIndex = 18;
            this.ApellidosLabel.Text = "Apellidos";
            this.ApellidosLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // CargoLabel
            // 
            this.CargoLabel.AutoSize = true;
            this.CargoLabel.Location = new System.Drawing.Point(258, 105);
            this.CargoLabel.Name = "CargoLabel";
            this.CargoLabel.Size = new System.Drawing.Size(52, 20);
            this.CargoLabel.TabIndex = 21;
            this.CargoLabel.Text = "Cargo";
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.Location = new System.Drawing.Point(248, 168);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(112, 20);
            this.DepLabel.TabIndex = 23;
            this.DepLabel.Text = "Departamento";
            this.DepLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cargar registro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PlantaLabel
            // 
            this.PlantaLabel.AutoSize = true;
            this.PlantaLabel.Location = new System.Drawing.Point(531, 168);
            this.PlantaLabel.Name = "PlantaLabel";
            this.PlantaLabel.Size = new System.Drawing.Size(54, 20);
            this.PlantaLabel.TabIndex = 28;
            this.PlantaLabel.Text = "Planta";
            this.PlantaLabel.Click += new System.EventHandler(this.PlantaLabel_Click);
            // 
            // SupervisorLabel
            // 
            this.SupervisorLabel.AutoSize = true;
            this.SupervisorLabel.Location = new System.Drawing.Point(531, 105);
            this.SupervisorLabel.Name = "SupervisorLabel";
            this.SupervisorLabel.Size = new System.Drawing.Size(84, 20);
            this.SupervisorLabel.TabIndex = 26;
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
            this.SupervisorCB.Location = new System.Drawing.Point(634, 97);
            this.SupervisorCB.Name = "SupervisorCB";
            this.SupervisorCB.Size = new System.Drawing.Size(136, 28);
            this.SupervisorCB.TabIndex = 25;
            this.SupervisorCB.SelectedIndexChanged += new System.EventHandler(this.SupervisorCB_SelectedIndexChanged);
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
            this.hInicio.Location = new System.Drawing.Point(571, 244);
            this.hInicio.Name = "hInicio";
            this.hInicio.Size = new System.Drawing.Size(53, 28);
            this.hInicio.TabIndex = 11;
            this.hInicio.SelectedIndexChanged += new System.EventHandler(this.minInicio_SelectedIndexChanged);
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
            this.minInicio.Location = new System.Drawing.Point(649, 244);
            this.minInicio.Name = "minInicio";
            this.minInicio.Size = new System.Drawing.Size(53, 28);
            this.minInicio.TabIndex = 31;
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
            this.minFinal.Location = new System.Drawing.Point(649, 303);
            this.minFinal.Name = "minFinal";
            this.minFinal.Size = new System.Drawing.Size(53, 28);
            this.minFinal.TabIndex = 32;
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
            this.DepCB.Location = new System.Drawing.Point(366, 160);
            this.DepCB.Name = "DepCB";
            this.DepCB.Size = new System.Drawing.Size(159, 28);
            this.DepCB.TabIndex = 33;
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
            this.hFinal.Location = new System.Drawing.Point(571, 303);
            this.hFinal.Name = "hFinal";
            this.hFinal.Size = new System.Drawing.Size(53, 28);
            this.hFinal.TabIndex = 35;
            // 
            // plantaCB
            // 
            this.plantaCB.FormattingEnabled = true;
            this.plantaCB.Items.AddRange(new object[] {
            "Planta1",
            "Planta2",
            "Planta3"});
            this.plantaCB.Location = new System.Drawing.Point(634, 160);
            this.plantaCB.Name = "plantaCB";
            this.plantaCB.Size = new System.Drawing.Size(136, 28);
            this.plantaCB.TabIndex = 36;
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
            this.comboBox1.Location = new System.Drawing.Point(366, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 28);
            this.comboBox1.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.plantaCB);
            this.Controls.Add(this.hFinal);
            this.Controls.Add(this.DepCB);
            this.Controls.Add(this.minFinal);
            this.Controls.Add(this.minInicio);
            this.Controls.Add(this.PlantaLabel);
            this.Controls.Add(this.SupervisorLabel);
            this.Controls.Add(this.SupervisorCB);
            this.Controls.Add(this.button1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.DateTimePicker dateTimeEntrada;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.Label entradaLabel;
        private System.Windows.Forms.Label salidaLabel;
        private System.Windows.Forms.Label HinicioLabel;
        private System.Windows.Forms.Label HfinalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.Label CargoLabel;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PlantaLabel;
        private System.Windows.Forms.Label SupervisorLabel;
        private System.Windows.Forms.ComboBox SupervisorCB;
        private System.Windows.Forms.ComboBox hInicio;
        private System.Windows.Forms.ComboBox minInicio;
        private System.Windows.Forms.ComboBox minFinal;
        private System.Windows.Forms.ComboBox DepCB;
        private System.Windows.Forms.ComboBox hFinal;
        private System.Windows.Forms.ComboBox plantaCB;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

