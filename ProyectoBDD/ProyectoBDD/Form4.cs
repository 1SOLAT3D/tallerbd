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
    public partial class Form4 : Form
    {
        BaseDato BD;
        Cliente cliente = new Cliente();
        string NombreEmpleado = "Angie Tatiana Fernandez Martinez";
        int IDE = 1;
        MySqlCommand valor;
        MySqlDataReader reader;
        DateTime UltimaHora;
        double total = 0;
        public Form4(BaseDato db)
        {
            InitializeComponent();
            BD = db;
            lblEmpleado.Text = "Empleado/a: " + NombreEmpleado;
            gbCOrden.Enabled = false;
            UltimaHora = DateTime.Now;
            lblClock.Text = UltimaHora.ToString();
        }
        public Form4(BaseDato db, Cliente c)
        {
            InitializeComponent();
            BD = db;
            cliente = c;
            lblLetreroCliente.Text = cliente.ToString();
            lblEmpleado.Text = "Empleado/a: " + NombreEmpleado;
            gbCOrden.Enabled = false;
            UltimaHora = DateTime.Now;
            lblClock.Text = UltimaHora.ToString();
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
                MessageBox.Show("Inciando orden");
                gbCOrden.Enabled = true;
            }
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbComida.Text != "")
                {
                    BD.Conectar();
                    string tamañ;
                    if(rdbPequeño.Checked)
                    {
                        tamañ = "Pequeño";
                    }else if(rdbMediano.Checked)
                    {
                        tamañ = "Mediano";
                    }else if(rdbGrande.Checked)
                    {
                        tamañ = "Grande";
                    }else
                    {
                        tamañ = "Extra Grande";
                    }
                    string query = $"select * from comida where nombre = '{cmbComida.Text}' and Tamaño = '{tamañ}';";
                    BD.Conectar();
                    valor = BD.ConsultarComando(query, "");
                    reader = valor.ExecuteReader();
                    string ID= "";
                    while (reader.Read())
                    {
                        ID = reader["ID_Comida"].ToString();
                    }
                    reader.Close();
                    BD.Desconectar();
                    if(ID != null && ID != "")
                    {
                        int Año = UltimaHora.Year;
                        int Mes = UltimaHora.Month;
                        int Day = UltimaHora.Day;
                        int Hora = UltimaHora.Hour;
                        int Min = UltimaHora.Minute;
                        int Seg = UltimaHora.Second;
                        string formato = UltimaHora.ToString("yyyy-MM-dd hh:mm:ss");
                        int MinExtra;
                        if (cliente.Prioridad == "Baja")
                        {
                            MinExtra = 20;
                        }
                        else if (cliente.Prioridad == "Media")
                        {
                            MinExtra = 15;
                        }
                        else
                        {
                            MinExtra = 12;
                        }
                        DateTime UltimaHora2 = UltimaHora.AddMinutes(MinExtra);
                        Año = UltimaHora2.Year;
                        Mes = UltimaHora2.Month;
                        Day = UltimaHora2.Day;
                        Hora = UltimaHora2.Hour;
                        Min = UltimaHora2.Minute;
                        Seg = UltimaHora2.Second;
                        string formato2 = UltimaHora2.ToString("yyyy-MM-dd hh:mm:ss");
                        query = "insert into orden " +
                            $"values ({cliente.ID_Cliente},0,{ID},'{formato}','{formato2}',{IDE});";
                        BD.Insertar(query);
                    }else
                    {
                        MessageBox.Show("No se encontro");
                    }
                }
                else
                {
                    MessageBox.Show("Elige una comida antes de introducirla");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado en el boton comida");
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbCombos.Text != "")
                {
                    BD.Conectar();
                    string query = "select * from combo " +
                        $"where Nombre_Combo = '{cmbCombos.Text}';";
                    BD.Conectar();
                    valor = BD.ConsultarComando(query, "");
                    reader = valor.ExecuteReader();
                    string ID = "";
                    while (reader.Read())
                    {
                        ID = reader["ID_Combo"].ToString();
                    }
                    reader.Close();
                    BD.Desconectar();
                    if (ID != null && ID != "")
                    {
                        int Año = UltimaHora.Year;
                        int Mes = UltimaHora.Month;
                        int Day = UltimaHora.Day;
                        int Hora = UltimaHora.Hour;
                        int Min = UltimaHora.Minute;
                        int Seg = UltimaHora.Second;
                        string formato = UltimaHora.ToString("yyyy-MM-dd hh:mm:ss");
                        int MinExtra;
                        if (cliente.Prioridad == "Baja")
                        {
                            MinExtra = 20;
                        }
                        else if (cliente.Prioridad == "Media")
                        {
                            MinExtra = 15;
                        }
                        else
                        {
                            MinExtra = 12;
                        }
                        DateTime UltimaHora2 = UltimaHora.AddMinutes(MinExtra);
                        Año = UltimaHora2.Year;
                        Mes = UltimaHora2.Month;
                        Day = UltimaHora2.Day;
                        Hora = UltimaHora2.Hour;
                        Min = UltimaHora2.Minute;
                        Seg = UltimaHora2.Second;
                        string formato2 = UltimaHora2.ToString("yyyy-MM-dd hh:mm:ss");
                        query = "insert into orden " +
                            $"values ({cliente.ID_Cliente},{ID},0,'{formato}','{formato2}',{IDE});";
                        BD.Insertar(query);
                        ActualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro");
                    }
                }
                else
                {
                    MessageBox.Show("Elige un comba antes de introducirlo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado en el boton comida");
            }
        }

        private void cmbComida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarTabla()
        {
            try
            {
                dtgCajero.Rows.Clear();
                BD.Conectar();
                int Año = UltimaHora.Year;
                int Mes = UltimaHora.Month;
                int Day = UltimaHora.Day;
                int Hora = UltimaHora.Hour;
                int Min = UltimaHora.Minute;
                int Seg = UltimaHora.Second;
                string formato = UltimaHora.ToString("yyyy-MM-dd hh:mm:ss");
                string query = "select * from OrdenDetalle " +
                    $"where Fecha_Pedido = '{formato}' and ID_Cliente = {cliente.ID_Cliente};";
                valor = BD.ConsultarComando(query, "");
                reader = valor.ExecuteReader();
                double x;
                while (reader.Read())
                {
                    dtgCajero.Rows.Add(reader["Nombre"].ToString(), reader["Cantidad"].ToString(), reader["Fecha_Pedido"].ToString(), reader["Hora_Estimada_Entrega"].ToString(), reader["Precio"].ToString());
                    x = int.Parse(reader["Precio"].ToString());
                    total += x;
                }
                reader.Close();
                BD.Desconectar();
                lblTotal.Text = "$" + total;
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado con la tabla");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(gbCOrden.Enabled)
                {
                    if (txtPago.Text != "")
                    {
                        int x = int.Parse(txtPago.Text);
                        if(total == 0)
                        {
                            MessageBox.Show("Introduce un pedido primero");
                        }
                        else if (x > total)
                        {
                            MessageBox.Show("Cambio a dar: $" + (x - total));
                            cliente.Estado = false;
                            gbCOrden.Enabled = false;
                            dtgCajero.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("El pago es mas pequeño que el total");
                        }

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Deseas cancelar todo el pedido?", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string query = "delete from orden " +
                                $"where Fecha_Pedido >= '{UltimaHora.ToString("yyyy-MM-dd hh:mm:ss")}' and ID_Cliente = {cliente.ID_Cliente};";
                            BD.Insertar(query);
                            MessageBox.Show("Se elimino con exito");
                        }
                        else
                        {
                            MessageBox.Show("Debes introducir una cantidad con la que se pago.");
                        }
                    }
                }else
                {
                    MessageBox.Show("Debes elegir un cliente primero");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }
    }
}
