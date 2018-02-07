using System;
using System.Runtime.Remoting.Messaging;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.DAL.Identidad
{
    public class ProductoMovimiento
    {
        /******************************/
        /****     PROPIEDADES     *****/
        /******************************/
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TipoOps Ops { get; set; }
        public string CodProducto { get; set; }
        public int IdComprobante { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }


        /*************************/
        /****     METODOS     ****/
        /*************************/
        public string ComprobanteDescripcion
        {
            get
            {
                if (ComprobanteServicios.Buscar(IdComprobante) == null)
                    return "";

                return ComprobanteServicios.Buscar(IdComprobante).Tipo
                       + ComprobanteServicios.Buscar(IdComprobante).Numero;
            }
        }

        public string DescripcionProducto => ProductoServicios.Buscar(CodProducto).Descripcion;

        public double Subtotal => Precio * Cantidad;

    }
}
