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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        BaseDeDatos bd new BaseDeDatos();

        private void Form7_Load(object sender, EventArgs e)
        {
            dgvOrden.DataSource = bd.SelectDataTable("select * from crud");
        }

        private void btnCapturarOrden_Click(object sender, EventArgs e)
        {
            string agregar = "insert into crud values (" + txtidCliente.Text + ", '" + txtidcombo.Text + ", '" + txtIdComida.Text + ", '" + txtFechaPedido.Text + ", '" + txtHoraEsperada.Text + ", '" + txtIdempleado.Text + ")";

            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Cliente agregado");
                dgvOrden.DataSource = bd.SelectDataTable("select * from crud");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarPorIdCliente = "select * from crud where IdCliente=" + txtidCliente.Text;
            dgvOrden.DataSource = bd.SelectDataTable(buscarPorIdCliente);
        }
    }
}
