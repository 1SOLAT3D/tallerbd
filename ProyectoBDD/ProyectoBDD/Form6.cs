using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDD
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        BaseDeDatos bd new BaseDeDatos();

        private void Form6_Load(object sender, EventArgs e)
        {
            dgvComida.DataSource = bd.SelectDataTable("select * from crud");
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into crud values (" + txtNombre.Text + ", '" + txtPrecio.Text + ", '" + txtTamano.Text + ")";

            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Comida agregado");
                dgvComida.DataSource = bd.SelectDataTable("select * from crud");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarPorNombre = "select * from crud where Nombre=" + txtNombre.Text;
            dgvComida.DataSource = bd.SelectDataTable(buscarPorNombre);
        }
    }
}
