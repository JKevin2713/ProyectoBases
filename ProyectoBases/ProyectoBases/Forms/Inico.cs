using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Model;
//using Planta;

namespace ProyectoBases
{
    public partial class Inico : Form
    {
        public Inico()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] plantaNombres = { "Parrita", "San Jose", "Cañas", "Zarapiqui" };
            comboBox1.Items.AddRange(plantaNombres);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Ingresar a la aplicacion de plantas
            String plantaNombre = comboBox1.SelectedItem.ToString();
            Plantas PlantasInicio = new Plantas(plantaNombre); // Crea una nueva instancia de la segunda ventana
            PlantasInicio.ShowDialog(); // Muestra la segunda ventana
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Planta NewPlanta = new Planta();
            NewPlanta.Nombre = "Santa Cruz";
            NewPlanta.Conexion = true;

            
            DB.PlantaDB planta = new DB.PlantaDB();
            planta.InsertarPlanta(NewPlanta);
            
        }
    }
}
