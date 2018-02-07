using System;

namespace Sis_Administracion.DAL.Identidad
{
    public class Usuario
    {
        // DATOS DEL USUARIO
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public string ApyNom => $"{Apellido} {Nombre}";

        // DATOS DE LOGIN
        public bool PrimerAcceso { get; set; }
        public string Usr { get; set; }
        public string Pss { get; set; }
        public bool Bloqueado { get; set; }
    }
}
