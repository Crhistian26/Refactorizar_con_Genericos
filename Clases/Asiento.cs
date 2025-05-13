using System.Diagnostics.Contracts;
using Clases.Interfaces;
namespace Clases
{
    public class Asiento : IGeneric
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Asiento()
        {
            Id = 0;
            BusId = 0;
            NumeroPiso = 0;
            NumeroAsiento = 0;
            FechaCreacion = DateTime.Now;
        }
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
