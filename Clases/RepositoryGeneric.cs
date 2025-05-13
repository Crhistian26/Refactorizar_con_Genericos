using Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    /// <summary>
    /// Repositorio generico para definir un repositorio generico, cuyo unico requisito es que el elemento a gestionar sea una clase y utilice la interfaz de <see cref="IGeneric"/>
    /// </summary>
    /// <typeparam name="T">Clase con la interfaz de <see cref="IGeneric"/> a gestionar</typeparam>
    public class RepositoryGeneric<T> : IRepository<T> where T : class, IGeneric
    {
        List<T> Elements { get; set; }
        public RepositoryGeneric()
        {
            Elements = new List<T>();
        }
        public void Agregar(T entity)
        {
            Console.WriteLine("Se agrego el elemento.");
            Elements.Add(entity);
        }
        public void Actualizar(T entity)
        {

            int index = Elements.IndexOf(Elements.Where(a=> a.Id == entity.Id).First());
            if (index != -1)
            {
                Elements[index] = entity;
                Console.WriteLine("Se actualizo el elemento.");
            }
        }
        public void Remover(T entity)
        {
            int index = Elements.IndexOf(entity);
            if (index != -1)
            {
                Elements.RemoveAt(index);
                Console.WriteLine("Se elimino el elemento.");
            }

        }
        public List<T> TraerTodos()
        {
            return Elements;
        }
        public T ObtenerPorId(T entity)
        {
            
            return Elements.Where(a => a.Id == entity.Id).FirstOrDefault();
        }
    }
}
