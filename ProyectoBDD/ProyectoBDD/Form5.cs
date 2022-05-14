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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        BaseDeDatos bd new BaseDeDatos();

        private void Form5_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = bd.SelectDataTable("select * from crud");
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into crud values (" + txtNombre.Text + ", '" + txtApPat.Text + ", '" + txtApMa.Text + ", '" + txtMembresia.Text + ", '" + txtDomicilio.Text + ", '" + txtTelefono.Text + ", '" + txtApPat.Text + ", '" + txtPrioridad.Text + ")";

            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Cliente agregado");
                dgvCliente.DataSource = bd.SelectDataTable("select * from crud");
            }
            else
            {
                MessageBox.Show("Error"); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarPorNombre = "select * from crud where Nombre=" + txtNombre.Text;
            dgvCliente.DataSource = bd.SelectDataTable(buscarPorNombre);
        }
    }
}
