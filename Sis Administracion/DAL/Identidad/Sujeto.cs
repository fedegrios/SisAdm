using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.DAL.Identidad
{
    public class Proveedor
    {
        public int Codigo { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Bloqueado { get; set; }

        public string CuityNombre => Cuit + " - " + RazonSocial;
    }

    public class Cliente
    {
        public int Codigo { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Bloqueado { get; set; }
        public double MontoMaxCtaCte { get; set; }
    }
}
