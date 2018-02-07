using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class ProductoServicios
    {
        private static List<Producto> Productos;

        public static void Inicializador()
        {
            Productos = new List<Producto>();

            AgregarProductosPorDefecto();
        }

        private static void AgregarProductosPorDefecto()
        {
            Agregar(new Producto
            {
                Codigo = "P01",
                CodBarra = "1111111111111",
                Descripcion = "Bolsa Plastico 20x45",
                Marca = "Plasticor",
                Costo = 13.21,
                Precio = 15.18,
                Stock = 23
            });

            Agregar(new Producto
            {
                Codigo = "P08",
                CodBarra = "222222222222222",
                Descripcion = "Bolsa Consorcio 50x150",
                Marca = "Plasticor",
                Costo = 26.98,
                Precio = 43.21,
                Stock = 40
            });

            Agregar(new Producto
            {
                Codigo = "P08",
                CodBarra = "2222221111222222",
                Descripcion = "Bolsa Consorcio 80x170",
                Marca = "Plasticor",
                Costo = 34.98,
                Precio = 51.21,
                Stock = 35
            });

            Agregar(new Producto
            {
                Codigo = "C03",
                CodBarra = "33333333333333333",
                Descripcion = "Bandeja Carton 15x15",
                Marca = "Corrugados",
                Costo = 5.34,
                Precio = 8.90,
                Stock = 100
            });

            Agregar(new Producto
            {
                Codigo = "C03",
                CodBarra = "3333331111333333",
                Descripcion = "Bandeja Carton 20x35",
                Marca = "Corrugados",
                Costo = 12.34,
                Precio = 18.90,
                Stock = 80
            });

        }


        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static Producto Buscar(string txtBuscar)
        {
            try
            {
                return Productos.FirstOrDefault(x => x.CodBarra == txtBuscar)??
                           Productos.FirstOrDefault(x => x.Codigo == txtBuscar);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Producto> Listar(string txtBuscar = "", bool eliminados = false)
        {
            try
            {
                if (txtBuscar == "") return Productos.Where(x => x.Eliminado == eliminados).ToList();

                return Productos.Where(x => x.Codigo.Contains(txtBuscar)
                                            || x.CodBarra.Contains(txtBuscar)
                                            || x.Descripcion.Contains(txtBuscar)
                                            || x.Marca.Contains(txtBuscar)
                                            && x.Eliminado == eliminados
                                        ).ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Producto Agregar(Producto pro)
        {
            if (Buscar(pro.Codigo) != null)
                return null;

            try
            {
                pro.Eliminado = false;
                Productos.Add(pro);
                return pro;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool Eliminar(Producto pro)
        {
            try
            {
                Buscar(pro.Codigo).Eliminado = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Recuperar(Producto pro)
        {
            try
            {
                Buscar(pro.Codigo).Eliminado = false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(Producto pro)
        {
            var p = Buscar(pro.Codigo);

            if (p == null)
                return false;
            try
            {
                p.Codigo = pro.Codigo;
                p.CodBarra = pro.CodBarra;
                p.Descripcion = pro.Descripcion;
                p.Marca = pro.Marca;
                p.Costo = pro.Costo;
                p.Precio = pro.Precio;
                p.Stock = pro.Stock;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
