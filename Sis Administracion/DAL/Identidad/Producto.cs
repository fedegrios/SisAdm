namespace Sis_Administracion.DAL.Identidad
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string CodBarra { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public int    Stock { get; set; }
        public bool Eliminado { get; set; }
    }
}
