using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Interfaces
{
    /// <summary>
    /// La interfaz para definir un repositorio de Asientos
    /// </summary>
    internal interface IAsientoRepository
    {
        void Agregar(Asiento asiento);
        void Actualizar(Asiento asiento);
        void Remover(Asiento asiento);
        List<Asiento> TraerTodos();
        Asiento ObtenerPorId(Asiento id);
    }
}
