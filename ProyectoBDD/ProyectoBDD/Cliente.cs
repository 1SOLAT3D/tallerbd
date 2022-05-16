using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDD
{
    public class Cliente
    {
        public Cliente()
        {
            if(NombreCompleto == "")
            {
                Estado = false;
            }
        }
        public Cliente(int ID_C, int ID_NC, string Membres, string Dom, string Telef, string fecha_alta, string prior, string PriNom, string segNom, string PApellid, string MApellid)
        {
            try
            {
                ID_Cliente = ID_C;
                ID_NComp = ID_NC;
                Membresia = Membres;
                Domicilio = Dom;
                Telefono = Telef;
                Fecha_Alta = fecha_alta;
                Prioridad = prior;
                NombreP = PriNom;
                NombreS = segNom;
                ApellidoP = PApellid;
                ApellidoM = MApellid;
                Estado = true;
                if (NombreS != "" && ApellidoM != "")
                {
                    NombreCompleto = $"{NombreP} {NombreS} {ApellidoP} {ApellidoM}";
                }
                else if (NombreS != "")
                {
                    NombreCompleto = $"{NombreP} {NombreS} {ApellidoP}";
                }
                else if (ApellidoM != "")
                {
                    NombreCompleto = $"{NombreP} {ApellidoP} {ApellidoM}";
                }
                else
                {
                    Estado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
        }
        public int ID_Cliente;
        public int ID_NComp;
        public string Membresia;
        public string Domicilio;
        public string Telefono;
        public string Fecha_Alta;
        public string Prioridad;
        public string NombreP;
        public string NombreS;
        public string ApellidoP;
        public string ApellidoM;
        public string NombreCompleto = "";
        public bool Estado = false;
        public override string ToString()
        {
            return "Nombre del cliente: " + NombreCompleto;
        }
    }
}
