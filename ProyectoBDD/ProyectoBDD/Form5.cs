using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RegisComida;

namespace ProyectoBDD
{
    public partial class Form5 : Form
    {
        Cliente client = new Cliente();
        bool permisos = false;
        BaseDato bd;
        MySqlCommand valor;
        MySqlDataReader reader;
        public Form5(bool permiss, BaseDato db)
        {
            InitializeComponent();
            permisos = permiss;
            bd = db;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                if (txtPNombre.Text != "" &&
                    txtSNombre.Text != "" &&
                    txtApPat.Text != "" &&
                    txtApMa.Text != "" &&
                    txtDomicilio.Text != "")
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPNombre.Text != "" && txtApPat.Text != "")
                {
                    string query = "select c.ID_Cliente,c.ID_NComp, nm.Primer_Nombre, nm.Segundo_Nombre, nm.Apellido_Paterno, nm.Apellido_Materno, c.Membresia,c.domicilio ,c.Telefono,c.Prioridad,c.Fecha_Alta " +
                                    "from cliente c join nombre_completo nm on (nm.ID_NComp = c.ID_NComp)"+ 
                                    $"where nm.Primer_Nombre = '{txtPNombre.Text}' and nm.Apellido_Paterno = '{txtApPat.Text}';";
                    if(ComprobarCant(query) ==0)
                    {
                        MessageBox.Show("No se encontro ningun resultado, comprueba tus datos");
                        lblEstado.Text = "Cliente no encontrado";
                        lblEstado.ForeColor = Color.Red;
                    }else if(ComprobarCant(query) == 1)
                    {
                        bd.Conectar();
                        valor = bd.ConsultarComando(query, "");
                        reader = valor.ExecuteReader();
                        while (reader.Read())
                        {
                            client = new Cliente(int.Parse(reader["ID_Cliente"].ToString()), int.Parse(reader["ID_NComp"].ToString()), reader["Membresia"].ToString(), reader["domicilio"].ToString(), reader["Telefono"].ToString(), reader["Fecha_Alta"].ToString(), reader["Prioridad"].ToString(), reader["Primer_Nombre"].ToString(), reader["Segundo_Nombre"].ToString(), reader["Apellido_Paterno"].ToString(), reader["Apellido_Materno"].ToString());
                        }
                        reader.Close();
                        bd.Desconectar();
                        Busqueda();
                        DialogResult result = MessageBox.Show("-> " + client.ToString() + " Es correcto?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Visible = false;
                            Form4 form = new Form4(bd, client);
                            form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay mas de un resultado se tomara el segundo apellido para reducir la busqueda");
                        if(txtApMa.Text != "")
                        {
                            query = "select c.ID_Cliente,c.ID_NComp, nm.Primer_Nombre, nm.Segundo_Nombre, nm.Apellido_Paterno, nm.Apellido_Materno, c.Membresia,c.domicilio ,c.Telefono,c.Prioridad,c.Fecha_Alta " +
                                    "from cliente c join nombre_completo nm on (nm.ID_NComp = c.ID_NComp)" +
                                    $"where nm.Primer_Nombre = '{txtPNombre.Text}' and nm.Apellido_Paterno = '{txtApPat.Text}' and nm.Apellido_Materno = '{txtApMa.Text}';";
                            if(ComprobarCant(query) == 1)
                            {
                                bd.Conectar();
                                valor = bd.ConsultarComando(query, "");
                                reader = valor.ExecuteReader();
                                while (reader.Read())
                                {
                                    client = new Cliente(int.Parse(reader["ID_Cliente"].ToString()), int.Parse(reader["ID_NComp"].ToString()), reader["Membresia"].ToString(), reader["domicilio"].ToString(), reader["Telefono"].ToString(), reader["Fecha_Alta"].ToString(), reader["Prioridad"].ToString(), reader["Primer_Nombre"].ToString(), reader["Segundo_Nombre"].ToString(), reader["Apellido_Paterno"].ToString(), reader["Apellido_Materno"].ToString());
                                }
                                reader.Close();
                                bd.Desconectar();
                                Busqueda();
                                DialogResult result = MessageBox.Show("-> " + client.ToString() + " Es correcto?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if(result == DialogResult.Yes)
                                {
                                    this.Visible = false;
                                    Form4 form = new Form4(bd, client);
                                    form.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Busqueda fallida");
                                lblEstado.Text = "Cliente no encontrado";
                                lblEstado.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parece que no introduciste ese dato, pon el apellido materno para continuar");
                            lblEstado.Text = "Cliente no encontrado";
                            lblEstado.ForeColor = Color.Red;
                        }
                    }

                }else
                {
                    MessageBox.Show("Debes al menos introducir el nombre y apeliido del cliente que quieres buscar");
                    lblEstado.Text = "Cliente no encontrado";
                    lblEstado.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error comprueba tus campos");
                lblEstado.Text = "Cliente no encontrado";
                lblEstado.ForeColor = Color.Red;
            }
        }
        private int ComprobarCant(string query)
        {
            int cantidad = 0;
            bd.Conectar();
            valor = bd.ConsultarComando(query, "");
            reader = valor.ExecuteReader();
            while (reader.Read())
            {
                cantidad++;
            }
            reader.Close();
            bd.Desconectar();
            return cantidad;
        }
        private void Busqueda()
        {
            lblEstado.ForeColor = Color.Green;
            lblEstado.Text = "Usuario encontrado";
            txtPNombre.Text = client.NombreP;
            txtSNombre.Text = client.NombreS;
            txtApPat.Text = client.ApellidoP;
            txtApMa.Text = client.ApellidoM;
            if (client.Membresia == "Basica")
            {
                cmbMenbresia.SelectedIndex = 0;
            }
            else if (client.Membresia == "Invitado")
            {
                cmbMenbresia.SelectedIndex = 1;
            }else
            if (client.Membresia == "Exclusivo")
            {
                cmbMenbresia.SelectedIndex = 2;
            }
            else if (client.Membresia == "Cliente frecuente")
            {
                cmbMenbresia.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Ocurrio un problema con la membresia");
            }
            txtDomicilio.Text = client.Domicilio;
            txtTelefono.Text = client.Telefono;
            if(client.Prioridad == "Baja")
            {
                cmbPrioridad.SelectedIndex = 0;
            }
            else if (client.Prioridad == "Media")
            {
                cmbPrioridad.SelectedIndex = 1;
            }
            else if (client.Prioridad == "Alta")
            {
                cmbPrioridad.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Ocurrio un error con la prioridad");
            }
        }

        private void btnRapido_Click(object sender, EventArgs e)
        {
            txtPNombre.Text = "Alan";
            txtApPat.Text = "Bartolome";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(permisos)
                {

                }
                else
                {
                    MessageBox.Show("Debes tener permisos de administrador para borrar a un cliente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
