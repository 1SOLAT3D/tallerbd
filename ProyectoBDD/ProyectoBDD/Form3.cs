using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        BaseDato bd;
        string query;
        //Form2 Menu;
        public Form3(BaseDato dd)
        {
            bd = dd;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Visible = false;
        }

        private void CmbTabla_SelectedIndexChange(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string item = cb.Text;
            if (item != null)
            {
                ActualizarTabla(item);
            }
        }
        private void ActualizarTabla(string tabla)
        {
            dtgDatos.Rows.Clear();
            dtgDatos.Columns.Clear();
            bd.Conectar();
            MySqlCommand valor;
            MySqlDataReader reader;
            try
            {
                switch (tabla)
                {
                    case "Datos de empleados":
                        dtgDatos.Columns.Add("DGV_NombreCompleto","Nombre Completo");
                        dtgDatos.Columns[0].Width = 200;
                        dtgDatos.Columns.Add("DGV_Tipo", "Tipo");
                        dtgDatos.Columns.Add("DGV_FechaIngreso", "Fecha de ingreso");
                        dtgDatos.Columns[2].Width = 150;
                        query = "select * from Empleadonombre;";
                        valor = bd.ConsultarComando(query, "");
                        reader = valor.ExecuteReader();
                        while (reader.Read())
                        {
                            dtgDatos.Rows.Add($"{reader["Nombre_Completo"].ToString()}", $"{reader["Tipo"].ToString()}", $"{reader["Fecha_Ingreso"].ToString()}");
                        }
                        reader.Close();
                        bd.Desconectar();
                        break;
                    case "Comidas":
                        dtgDatos.Columns.Add("DGV_NombreComida", "Nombre");
                        dtgDatos.Columns[0].Width = 200;
                        dtgDatos.Columns.Add("DGV_PrecioComida", "Precio");
                        dtgDatos.Columns.Add("DGV_TamañoComida", "Tamaño");
                        query = "select * from comida;";
                        valor = bd.ConsultarComando(query, "");
                        reader = valor.ExecuteReader();
                        while (reader.Read())
                        {
                            dtgDatos.Rows.Add($"{reader["Nombre"].ToString()}", $"{reader["Precio"].ToString()}", $"{reader["Tamaño"].ToString()}");
                        }
                        reader.Close();
                        bd.Desconectar();
                        break;
                    case "Clientes":
                        dtgDatos.Columns.Add("DGV_NombreCliente", "Nombre");
                        dtgDatos.Columns[0].Width = 200;
                        dtgDatos.Columns.Add("DGV_Membresia", "Membresia");
                        dtgDatos.Columns.Add("DGV_Domicilio", "Domicilio");
                        dtgDatos.Columns[2].Width = 150;
                        dtgDatos.Columns.Add("DGV_Telefono", "Telefono");
                        dtgDatos.Columns.Add("DGV_FechaAlta", "Fecha Alta");
                        dtgDatos.Columns[4].Width = 150;
                        dtgDatos.Columns.Add("DGV_Prioridad", "Prioridad");
                        dtgDatos.Columns[5].Width = 60;
                        query = "select * from ClienteNombre;";
                        valor = bd.ConsultarComando(query, "");
                        reader = valor.ExecuteReader();
                        while (reader.Read())
                        {
                            dtgDatos.Rows.Add($"{reader["Nombre_Completo"].ToString()}", $"{reader["Membresia"].ToString()}", $"{reader["Domicilio"].ToString()}", $"{reader["Telefono"].ToString()}", $"{reader["Fecha_Alta"].ToString()}", $"{reader["prioridad"].ToString()}");
                        }
                        reader.Close();
                        bd.Desconectar();
                        break;
                    case "Ordenes":
                        dtgDatos.Columns.Add("DGV_Nombre_Cliente", "Nombre del cliente");
                        dtgDatos.Columns.Add("DGV_Nombre_Empleado", "Nombre del empleado en turno");
                        dtgDatos.Columns.Add("DGV_Pedido", "Pedido");
                        dtgDatos.Columns.Add("DGV_Fecha_Pedido", "Fecha del pedido");
                        dtgDatos.Columns.Add("DGV_Hora_Estimada_entrega", "NombHora Estimada de entrega");
                        dtgDatos.Columns.Add("DGV_Prioridad", "Prioridad");
                        query = "select * from OrdenBasico;";
                        valor = bd.ConsultarComando(query, "");
                        reader = valor.ExecuteReader();
                        while (reader.Read())
                        {
                            dtgDatos.Rows.Add($"{reader["Nombre_Cliente"].ToString()}", $"{reader["Nombre_Empleado"].ToString()}", $"{reader["Pedido"].ToString()}", $"{reader["Fecha_pedido"].ToString()}", $"{reader["hora_estimada_entrega"].ToString()}", $"{reader["prioridad"].ToString()}");
                        }
                        reader.Close();
                        bd.Desconectar();
                        break;
                    default:

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }        
        }
        
    }
}
