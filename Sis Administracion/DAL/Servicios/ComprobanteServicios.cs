using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class ComprobanteServicios
    {
        private static List<Comprobante> Comprobantes;

        public static void Inicializador()
        {
            Comprobantes = new List<Comprobante>();

            AgregarComprobantesPorDefecto();
        }

        private static void AgregarComprobantesPorDefecto()
        {

        }

        public static int NumeroProximoComprobante()
        {
            return Comprobantes.Count > 0 ? Comprobantes.Count + 1 : 1;
        }

        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static Comprobante Buscar(int id = 0)
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

        public static List<Comprobante> Listar(TipoOps ops , int idEmisor = 0)
        {
            try
            {
                if(idEmisor != 0)
                    return Comprobantes.Where(x => x.IdSujeto == idEmisor && x.Ops == ops).ToList();

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Comprobante> Listar(TipoOps ops, string txtBuscar = "")
        {
            try
            {
                if (txtBuscar == "") return Comprobantes.Where(x => x.Ops == ops).ToList();

                return Comprobantes.Where( x => x.Ops == ops && x.Numero.Contains(txtBuscar) )
                                   .OrderByDescending(x => x.Fecha)
                                   .ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Comprobante> ListarPorUsuario(int id)
        {
            try
            {
                return Comprobantes.Where(x => x.Usuario == id)
                    .OrderByDescending(x => x.Fecha)
                    .ToList();
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
                // ACCIONES DE ACTUALIZACION DE STOCK


                // GUARDO LOS DATOS DEL COMPROBANTE
                pro.Id = Comprobantes.Count > 0 ? Comprobantes.Count + 1 : 1;

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
                p.IdSujeto = pro.IdSujeto;
                p.Fecha = pro.Fecha;
                p.Usuario = pro.Usuario;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        }
    }