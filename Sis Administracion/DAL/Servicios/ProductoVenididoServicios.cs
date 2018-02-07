using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class ProductoVenididoServicios
    {
        private static List<ProductoVendido> ProductoVendidos;

        public void Inicializador()
        {
            ProductoVendidos = new List<ProductoVendido>();

            AgregarProductoVendidosPorDefecto();
        }

        private void AgregarProductoVendidosPorDefecto()
        {
            Agregar(new ProductoVendido
            {

            });

            Agregar(new ProductoVendido
            {

            });

            Agregar(new ProductoVendido
            {

            });

        }


        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static ProductoVendido Buscar(int _id)
        {
            try
            {
                return ProductoVendidos.FirstOrDefault(x => x.Id == _id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<ProductoVendido> BuscarPorComprobante(int idComprobante)
        {
            try
            {
                return ProductoVendidos.Where(x => x.IdComprobante == idComprobante).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<ProductoVendido> BuscarPorProducto(string txtBuscar)
        {
            try
            {
                return ProductoVendidos.Where(x => x.CodProducto == txtBuscar).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ProductoVendido Agregar(ProductoVendido pro)
        {
            try
            {
                pro.Id = ProductoVendidos.Count > 0 ? ProductoVendidos.Count + 1 : 0;

                ProductoVendidos.Add(pro);
                return pro;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool Eliminar(ProductoVendido pro)
        {
            try
            {
                ProductoVendidos.Remove(pro);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(ProductoVendido pro)
        {
            var p = Buscar(pro.Id);

            if (p == null)
                return false;
            try
            {
                p.CodProducto = pro.CodProducto;
                p.IdComprobante = pro.IdComprobante;
                p.Cantidad = pro.Cantidad;
                p.Precio = pro.Precio;
                p.Iva = pro.Iva;
            
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
}
