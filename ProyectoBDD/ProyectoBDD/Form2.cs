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
    public partial class Form2 : Form
    {
        BaseDato BD = new BaseDato();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string bases = "informe";
            string usuario = "root";
            string xontra = "";
            try
            {
                if(txtNombre.Text != "" 
                    && txtContrasena.Text != ""
                    && txtNombre.Text != ""
                    && txtServer.Text != "")
                {
                    usuario = txtNombre.Text;
                    xontra = txtContrasena.Text;
                    bases = txtBD.Text;
                    server = txtServer.Text;
                }else
                {
                    MessageBox.Show("Los campos estan vacios por lo que se usara la ruta default");
                }
                BD.CambiarDatabase(server, bases, usuario, xontra);
                BD.Conectar();
                Form3 form = new Form3(BD);
                form.Show();
                this.Visible = false;
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("A ocurrido un error con la auntenticacion o no encontro la base de datos, verifica bien los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error con la auntenticacion o no encontro la base de datos, verifica bien los datos");
            }
            
        }

        private void BtnExtra_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "root";
            txtContrasena.Text = "";
            txtBD.Text= "informe";
            txtServer.Text = "localhost";
        }
    }
}
