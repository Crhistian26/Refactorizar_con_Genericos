using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Interfaces
{
    /// <summary>
    /// Interfaz generica para definir un repositorio generico
    /// </summary>
    /// <typeparam name="T">La clase que se usara en las gestiones</typeparam>
    internal interface IRepository<T>
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(T entity);
    }
}
