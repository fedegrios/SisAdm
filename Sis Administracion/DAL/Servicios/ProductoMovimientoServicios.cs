using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class ProductoMovimientoServicios
    {
        private static List<ProductoMovimiento> ProductoMovimientos;

        public static void Inicializador()
        {
            ProductoMovimientos = new List<ProductoMovimiento>();

           AgregarProductoMovimientosPorDefecto();
        }

        private static void AgregarProductoMovimientosPorDefecto()
        {
            Agregar(new ProductoMovimiento
            {
                Fecha = DateTime.Now,
                Ops = TipoOps.Compra,
                CodProducto = "P01",
                IdComprobante = 1,
                Cantidad = 10,
                Precio = 10.0
            });

            Agregar(new ProductoMovimiento
            {
                Fecha = DateTime.Now,
                Ops = TipoOps.Venta,
                CodProducto = "P01",
                IdComprobante = 1,
                Cantidad = 3,
                Precio = 12.0
            });
        }


        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static ProductoMovimiento Buscar(int cod)
        {
            try
            {
                return ProductoMovimientos.FirstOrDefault(x => x.Id == cod);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<ProductoMovimiento> ListarPorComprobante(int id)
        {
            try
            {
                return ProductoMovimientos.Where(x => x.IdComprobante == id).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<ProductoMovimiento> Listar( string txtBuscar = "")
        {
            try
            {
                // Si la cadena esta vacia devuelvo toda la lista.
                return txtBuscar == "" 
                    ? ProductoMovimientos.ToList()
                    : ProductoMovimientos.Where(x => x.CodProducto == txtBuscar).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ProductoMovimiento Agregar(ProductoMovimiento proVen)
        {
            try
            {
                proVen.Id = ProductoMovimientos.Count > 0 ? ProductoMovimientos.Count + 1 : 1;

                ProductoMovimientos.Add(proVen);
                return proVen;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool Eliminar(ProductoMovimiento proVen)
        {
            try
            {
                ProductoMovimientos.Remove(proVen);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(ProductoMovimiento proVen)
        {
            var u = Buscar(proVen.Id);

            if (u == null)
                return false;
            try
            {
                u.CodProducto = proVen.CodProducto;
                u.IdComprobante = proVen.IdComprobante;
                u.Cantidad = proVen.Cantidad;
                u.Precio = proVen.Precio;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
