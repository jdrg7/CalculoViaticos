using System.Linq;

namespace CalculoViaticos.Clases
{
    internal class Validaciones
    {
        public static bool ValidarSoloLetras(string texto)
        {
            return !string.IsNullOrEmpty(texto) && texto.All(char.IsLetter);
        }
    }
}
