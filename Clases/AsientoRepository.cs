using Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// La clase AsientoRepository original, la cual depende la clase de <see cref="Asiento"/> en cada uno de sus metodos
    /// </summary>
    public class AsientoRepository : IAsientoRepository
    {
        public void Agregar(Asiento asiento)
        {
            // Implementación para agregar un asiento
        }

        public void Actualizar(Asiento asiento)
        {
            // Implementación para actualizar un asiento
        }

        public void Remover(Asiento asiento)
        {
            // Implementación para remover un asiento
        }

        public List<Asiento> TraerTodos()
        {
            // Implementación para traer todos los asientos
            return new List<Asiento>();
        }

        public Asiento ObtenerPorId(Asiento id)
        {
            // Implementación para obtener un asiento por ID
            return new Asiento();
        }
    }
}
