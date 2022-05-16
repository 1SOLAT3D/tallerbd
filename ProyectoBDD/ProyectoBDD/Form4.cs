using RegisComida;
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
    public partial class Form4 : Form
    {
        BaseDato BD;
        Cliente cliente = new Cliente();
        public Form4(BaseDato db)
        {
            InitializeComponent();
            BD = db;
        }
        public Form4(BaseDato db, Cliente c)
        {
            InitializeComponent();
            BD = db;
            cliente = c;
            lblLetreroCliente.Text = cliente.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Visible = false;
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            if(cliente.Estado == false)
            {
                MessageBox.Show("Iniciando la buscador de clientes");
                Form5 form = new Form5(false, BD);
                form.Show();
                this.Visible = false;
            }else
            {

            }
        }
    }
}
