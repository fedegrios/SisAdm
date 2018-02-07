using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class UsuarioServicios
    {
        private static List<Usuario> Usuarios;

        public static void Inicializador()
        {
            Usuarios = new List<Usuario>();

            AgregarUsuariosPorDefecto();
        }

        private static void AgregarUsuariosPorDefecto()
        {
            Agregar(new Usuario
            {
                Dni = "33139168",
                Nombre = "Federico",
                Apellido = "Rios",
                Direccion = "Lacalle 345",
                Telefono = "4291684",
                FechaNacimiento = DateTime.Parse("03/07/1989 12:00"),
            });

            Agregar(new Usuario
            {
                Dni = "14073468",
                Nombre = "Susana",
                Apellido = "Camus",
                Direccion = "Pje Cortito 443",
                Telefono = "3814549560",
                FechaNacimiento = DateTime.Parse("05/01/1980 12:00"),
            });

        }

        public static void BloquearDesbloquear(Usuario usr)
        {
            if (usr == null) return;

            var p = Buscar(usr.Dni);

            if (p == null) return;

            try
            {
                p.Bloqueado = !p.Bloqueado;
            }
            catch (Exception)
            {
                // ignored
            }
        }


        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static Usuario Buscar(string txtBuscar, bool bloqueados = false)
        {
            try
            {
                return Usuarios.FirstOrDefault(x => x.Dni == txtBuscar && x.Bloqueado == bloqueados)
                       ?? Usuarios.FirstOrDefault(x => x.Usr == txtBuscar && x.Bloqueado == bloqueados)
                       ?? Usuarios.FirstOrDefault(x => x.Apellido == txtBuscar && x.Bloqueado == bloqueados)
                       ?? Usuarios.FirstOrDefault(x => x.Nombre == txtBuscar && x.Bloqueado == bloqueados);

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Usuario> Buscar(bool bloqueados = false)
        {
            try
            {
                return Usuarios.Where(x => x.Bloqueado == bloqueados).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Usuario Agregar(Usuario usr)
        {
            if (Usuarios.FirstOrDefault(x => x.Dni == usr.Dni) != null)
                return null;

            try
            {
                // Formar el usuario
                string usrName;
                int i = 1;
                do
                {
                    // Si no quedan mas caracteres que agregar
                    if (usr.Nombre.Trim().Length == i) return null;

                    // Extrae la primera letra del nombre y adjunta el apellido.
                    // Si existe el usuario, agrega una letra mas al nombre.
                    usrName = usr.Nombre.Substring(0, i).Trim() + usr.Apellido;

                // Hasta que el Usuario con ese usuario no exista
                } while (Buscar( usrName, true) == null );

                // Buscar Codigo max, si no hay pongo 1
                usr.Usr = usrName;
                usr.Pss = usr.Dni;
                usr.PrimerAcceso = true;

                Usuarios.Add(usr);
                return usr;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool Eliminar(Usuario usr)
        {
            try
            {
                Usuarios.Remove(usr);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(Usuario usr)
        {
            var u = Buscar(usr.Dni);

            if (u == null)
                return false;
            try
            {
                u.FechaNacimiento = usr.FechaNacimiento;
                u.Nombre = usr.Nombre;
                u.Apellido = usr.Apellido;
                u.Direccion = usr.Direccion;
                u.Telefono = usr.Telefono;
                u.FechaNacimiento = usr.FechaNacimiento;
                u.Pss = usr.Pss;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}