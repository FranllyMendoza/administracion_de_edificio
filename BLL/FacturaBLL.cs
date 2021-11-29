using administracion_de_edificio.DAL;
using administracion_de_edificio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace administracion_de_edificio.BLL
{
    class FacturaBLL
    {
        public static bool Guardar(Facturar facturar)
        {
            if (!Existe(facturar.IdFactura))
            {
                return Insertar(facturar);
            }
            else
                return Modificar(facturar);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.factura.Any(e => e.IdFactura == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }


        private static bool Insertar(Facturar facturar)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.factura.Add(facturar);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Facturar facturar)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(facturar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var factura = contexto.factura.Find(id);
                if (factura != null)
                {
                    contexto.factura.Remove(factura);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Facturar Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Facturar facturar;
            try
            {
                facturar = contexto.factura.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return facturar;
        }

        public static List<Facturar> GetList(Expression<Func<Facturar, bool>> criterio)
        {
            List<Facturar> lista = new List<Facturar>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.factura.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Facturar> Getfacturas()
        {
            Contexto contexto = new Contexto();
            List<Facturar> lista = new List<Facturar>();

            try
            {
                lista = contexto.factura.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
