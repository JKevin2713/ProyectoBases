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
            string[] plantaNombres = { "Guayabo", "Central", "La Romana"};
            comboBox1.Items.AddRange(plantaNombres);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string plantaNombre = comboBox1.SelectedItem.ToString();
                Plantas PlantasInicio = new Plantas(plantaNombre);
      
                PlantasInicio.Show();
            }
            catch (NullReferenceException)
            {
                // Maneja el caso en que no haya un elemento seleccionado
                MessageBox.Show("Por favor, selecciona una planta.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Inico_Load(object sender, EventArgs e)
        {

        }
    }
}
