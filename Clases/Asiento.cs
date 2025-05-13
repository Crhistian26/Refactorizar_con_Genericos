using System.Diagnostics.Contracts;
using Clases.Interfaces;
namespace Clases
{
    /// <summary>
    /// Clase Asiento que representa un asiento en un bus, que depende de la interfaz de <see cref="IGeneric"/>
    /// </summary>
    public class Asiento : IGeneric
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Constructor por defecto de la clase Asiento
        /// </summary>
        public Asiento()
        {
            Id = 0;
            BusId = 0;
            NumeroPiso = 0;
            NumeroAsiento = 0;
            FechaCreacion = DateTime.Now;
        }

        /// <summary>
        /// Constructor de la clase Asiento que recibe los valores de id, busId, numeroPiso y numeroAsiento
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="busId">El ID del bus</param>
        /// <param name="numeroPiso">El numero del piso</param>
        /// <param name="numeroAsiento">El numero del asiento</param>
        public Asiento(int id, int busId, int numeroPiso, int numeroAsiento)
        {
            Id = id;
            BusId = busId;
            NumeroPiso = numeroPiso;
            NumeroAsiento = numeroAsiento;
            FechaCreacion = DateTime.Now;
        }
    }
}
