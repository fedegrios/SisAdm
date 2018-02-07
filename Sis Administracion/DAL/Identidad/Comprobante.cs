using System;
using System.Linq;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.DAL.Identidad
{
    public class Comprobante
    {
        /******************************/
        /****     PROPIEDADES     *****/
        /******************************/
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoComprobante Tipo { get; set; }
        public TipoOps Ops { get; set; }
        public int IdSujeto { get; set; }
        public DateTime Fecha { get; set; }
        public int Usuario { get; set; }


        /*************************/
        /****     METODOS     ****/
        /*************************/
        public double Neto => 
            ProductoMovimientoServicios.ListarPorComprobante(Id)
                .Sum(p => p.Subtotal);

        public string NombreSujeto =>
            ProveedorServicios.Buscar(IdSujeto) != null 
            ? ProveedorServicios.Buscar(IdSujeto).RazonSocial
            : ClienteServicios.Buscar(IdSujeto).RazonSocial;
    }
}
