using System;
using System.Collections.Generic;
using System.Linq;
using Sis_Administracion.DAL.Identidad;

namespace Sis_Administracion.DAL.Servicios
{
    public class ProveedorServicios
    {
        private static List<Proveedor> Proveedores;

        public static void Inicializador()
        {
            Proveedores = new List<Proveedor>();

            AgregarProveedorsPorDefecto();
        }

        private static void AgregarProveedorsPorDefecto()
        {
            Agregar(new Proveedor
            {
                Cuit = "34067884",
                RazonSocial = "Rios Agustin Javier",
                Direccion = "Ayacucho 281",
                Telefono = "123321123",
            });

            Agregar(new Proveedor
            {
                Cuit = "20313369189",
                RazonSocial = "Plasti Coso SRL",
                Direccion = "Ruta 0 Km 1",
                Telefono = "08109991111",
            });

            Agregar(new Proveedor
            {
                Cuit = "21417043862",
                RazonSocial = "Embol Zame SA",
                Direccion = "Siemre Viva 312, Lules",
                Telefono = "3815454545",
            });
        }

        public static void BloquearDesbloquear(Proveedor pro)
        {
            if (pro == null) return;

            var u = Buscar(pro.Cuit);

            if (u == null) return;

            try
            {
                u.Bloqueado = !u.Bloqueado;

            }
            catch (Exception)
            {
                // ignored
            }
        }

        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static Proveedor Buscar(int id)
        {
            try
            {
                return Proveedores.FirstOrDefault(x => x.Codigo == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Proveedor Buscar(string txtBuscar, bool bloqueados = false)
        {
            try
            {
                return Proveedores.FirstOrDefault(x => x.Cuit == txtBuscar && x.Bloqueado == bloqueados)
                    ?? Proveedores.FirstOrDefault(x => x.RazonSocial == txtBuscar && x.Bloqueado == bloqueados);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Proveedor> Listar(string txtBuscar = "" , bool bloqueados = false)
        {
            try
            {
                if(txtBuscar == string.Empty)
                    return Proveedores.Where(x => x.Bloqueado == bloqueados).ToList();

                return Proveedores.Where(x => x.Bloqueado == bloqueados
                                        && (x.Cuit.Contains(txtBuscar) 
                                            || x.RazonSocial.Contains(txtBuscar))
                                        ).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Proveedor Agregar(Proveedor pro)
        {
            // Compruebo que no exista el Cuit   
            if (Proveedores.FirstOrDefault(x => x.Cuit == pro.Cuit) != null)
                return null;

            try
            {
                // Generar Codigo
                pro.Codigo = Proveedores.Count > 0 ? Proveedores.Count + 1 : 1;

                // Por defecto no esta bloqueado
                pro.Bloqueado = false;

                // Grabo los datos
                Proveedores.Add(pro);
                return pro;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool Eliminar(Proveedor pro)
        {
            try
            {
                Proveedores.Remove(pro);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(Proveedor pro)
        {
            var u = Buscar(pro.Cuit);

            if (u == null)
                return false;
            try
            {
                u.RazonSocial = pro.RazonSocial;
                u.Direccion = pro.Direccion;
                u.Telefono = pro.Telefono;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

    public class ClienteServicios
    {
        private static List<Cliente> Clientes;

        public static void Inicializador()
        {
            Clientes = new List<Cliente>();

            AgregarClientesPorDefecto();
        }

        private static void AgregarClientesPorDefecto()
        {
            Agregar(new Cliente
            {
                Cuit = "99999999999",
                RazonSocial = "Consumidor Final",
                Direccion = "",
                Telefono = ""
            });

            Agregar(new Cliente
            {
                Cuit = "20430768483",
                RazonSocial = "Elbar Sito SRL",
                Direccion = "Republica de Monteros 543",
                Telefono = "3815454545",
                MontoMaxCtaCte = 1000.0
            });

            Agregar(new Cliente
            {
                Cuit = "21304876384",
                RazonSocial = "Luis y Miguel SH",
                Direccion = "Pje Concion 1077",
                Telefono = "3815454545"
            });
        }

        public static void BloquearDesbloquear(Cliente pro)
        {
            if (pro == null) return;

            var u = Buscar(pro.Cuit);

            if (u == null) return;

            try
            {
                u.Bloqueado = !u.Bloqueado;

            }
            catch (Exception)
            {
                // ignored
            }
        }

        /****************************/
        /***         ABMC         ***/
        /****************************/
        public static Cliente Buscar(int id)
        {
            try
            {
                return Clientes.FirstOrDefault(x => x.Codigo == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Cliente Buscar(string txtBuscar, bool bloqueados = false)
        {
            try
            {
                return Clientes.FirstOrDefault(x => x.Cuit == txtBuscar && x.Bloqueado == bloqueados)
                    ?? Clientes.FirstOrDefault(x => x.RazonSocial == txtBuscar && x.Bloqueado == bloqueados);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Cliente> Listar(string txtBuscar = "", bool bloqueados = false)
        {
            try
            {
                if (txtBuscar == string.Empty)
                    return Clientes.Where(x => x.Bloqueado == bloqueados).ToList();

                return Clientes.Where(x => x.Bloqueado == bloqueados
                                        && (x.Cuit.Contains(txtBuscar)
                                            || x.RazonSocial.Contains(txtBuscar))
                                        ).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Cliente Agregar(Cliente cli)
        {
            // Compruebo que no exista el Cuit   
            if (Clientes.FirstOrDefault(x => x.Cuit == cli.Cuit) != null)
                return null;

            try
            {
                // Generar Codigo
                cli.Codigo = Clientes.Count > 0 ? Clientes.Count + 1 : 1;

                // Por defecto no esta bloqueado
                cli.Bloqueado = false;

                // Por Defecto Monto Max Cta Cte
                if ( double.IsNaN(cli.MontoMaxCtaCte) ) cli.MontoMaxCtaCte = 0;

                // Grabo los datos
                Clientes.Add(cli);
                return cli;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Eliminar(Cliente pro)
        {
            try
            {
                Clientes.Remove(pro);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Modificar(Cliente pro)
        {
            var u = Buscar(pro.Cuit);

            if (u == null)
                return false;
            try
            {
                u.RazonSocial = pro.RazonSocial;
                u.Direccion = pro.Direccion;
                u.Telefono = pro.Telefono;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}