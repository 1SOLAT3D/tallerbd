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
        DateTime UltimaHora;
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
                    int Año = UltimaHora.Year;
                    int Mes = UltimaHora.Month;
                    int Day = UltimaHora.Day;
                    int Hora = UltimaHora.Hour;
                    int Min = UltimaHora.Minute;
                    int Seg = UltimaHora.Second;
                    string formato = $"{Año}-{Mes}-{Day} {Hora}:{Min}:{Seg}";
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
                    UltimaHora = UltimaHora.AddMinutes(MinExtra);
                    Año = UltimaHora.Year;
                    Mes = UltimaHora.Month;
                    Day = UltimaHora.Day;
                    Hora = UltimaHora.Hour;
                    Min = UltimaHora.Minute;
                    Seg = UltimaHora.Second;
                    string formato2 = $"{Año}-{Mes}-{Day} {Hora}:{Min}:{Seg}";
                    string query = "insert into orden " +
                        $"values ({cliente.ID_Cliente},0,{cmbComida.Text},'{formato}','{formato2}',{IDE});";
                    BD.Insertar(query);
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
                    int Año = UltimaHora.Year;
                    int Mes = UltimaHora.Month;
                    int Day = UltimaHora.Day;
                    int Hora = UltimaHora.Hour;
                    int Min = UltimaHora.Minute;
                    int Seg = UltimaHora.Second;
                    string formato = $"{Año}-{Mes}-{Day} {Hora}:{Min}:{Seg}";
                    int MinExtra;
                    if(cliente.Prioridad == "Baja")
                    {
                        MinExtra = 20;
                    }else if (cliente.Prioridad == "Media")
                    {
                        MinExtra = 15;
                    }
                    else
                    {
                        MinExtra = 12;
                    }
                    UltimaHora = UltimaHora.AddMinutes(MinExtra);
                     Año = UltimaHora.Year;
                   Mes = UltimaHora.Month;
                    Day = UltimaHora.Day;
                    Hora = UltimaHora.Hour;
                     Min = UltimaHora.Minute;
                    Seg = UltimaHora.Second;
                    string formato2 = $"{Año}-{Mes}-{Day} {Hora}:{Min}:{Seg}";
                    string query = "insert into orden " +
                        $"values ({cliente.ID_Cliente},{cmbCombos.Text},0,'{formato}','{formato2}',{IDE});";
                    BD.Insertar(query);
                    //MessageBox.Show("");
                }else
                {
                    MessageBox.Show("Elige un comba antes de introducirlo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado en el boton comida");
            }
        }
    }
}
