using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class ComprobanteServicios
    {
        private static List<Comprobante> Comprobantes;

        public void Inicializador()
        {
            Comprobantes = new List<Comprobante>();

            AgregarComprobantesPorDefecto();
        }

        private void AgregarComprobantesPorDefecto()
        {
            Agregar(new Comprobante
            {

            });

            Agregar(new Comprobante
            {

            });

            Agregar(new Comprobante
            {

            });

        }


        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static Comprobante Buscar(int id)
        {
            try
            {
                return Comprobantes.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Comprobante> BuscarPorEmpleado(int codEmp)
        {
            try
            {
                return Comprobantes.Where(x => x.CodigoEmpleado == codEmp).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Comprobante> BuscarPorSujeto(int codSujeto)
        {
            try
            {
                return Comprobantes.Where(x => x.CodEmisor == codSujeto || x.CodReceptor == codSujeto).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Comprobante Agregar(Comprobante pro)
        {
            try
            {
                pro.Id = Comprobantes.Count > 0 ? Comprobantes.Count + 1 : 0;

                Comprobantes.Add(pro);
                return pro;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool Eliminar(Comprobante pro)
        {
            try
            {
                Comprobantes.Remove(pro);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(Comprobante pro)
        {
            var p = Buscar(pro.Id);

            if (p == null)
                return false;
            try
            {
                p.Numero = pro.Numero;
                p.Tipo = pro.Tipo;
                p.CodEmisor = pro.CodEmisor;
                p.CodReceptor = pro.CodReceptor;
                p.Fecha = pro.Fecha;
                p.Descuento = pro.Descuento;
                p.CodigoEmpleado = pro.CodigoEmpleado;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
