using System.Text.Json;
using Clases;

namespace Refactorizar_con_Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asiento A1 = new Asiento(1, 1, 1, 1);
            Asiento A2 = new Asiento(2, 2, 2, 2);
            Asiento A3 = new Asiento(3, 3, 3, 3);
            Asiento A4 = new Asiento(4, 4, 4, 4);
            Asiento A5 = new Asiento(5, 5, 5, 5);

            RepositoryGeneric<Asiento> repo = new RepositoryGeneric<Asiento>();

            repo.Agregar(A1);
            repo.Agregar(A2);
            repo.Agregar(A3);
            repo.Agregar(A4);
            repo.Agregar(A5);

            string elementos = JsonSerializer.Serialize(repo.TraerTodos());

            Console.WriteLine("\nTodos los elementos del repo:\n\n" + elementos + "\n\n");

            repo.Remover(A5);

            repo.Actualizar(A4);

            string elemento = JsonSerializer.Serialize(repo.ObtenerPorId(A3));
            Console.WriteLine("\nElemento con id 3:\n\n" + elemento + "\n\n");

            elementos = JsonSerializer.Serialize(repo.TraerTodos());
            Console.WriteLine("\nTodos los elementos del repo luego de los cambios:\n\n" + elementos + "\n\n");
        }
    }
}
