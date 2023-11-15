using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ESFE.AprendeJugando.Models;

namespace ESFE.AprendeJugando.Services
{
    public class PreguntasServices:IPreguntaService
    {
        public async Task<List<Pregunta>>ObtenerPreguntas()
        {
            try
            {
                var preguntasJson = File.ReadAllText("wwwroot/Preguntas/preguntas.json");
                return JsonSerializer.Deserialize<List<Pregunta>>(preguntasJson);
            }
            catch (Exception)
            {
                // Manejar errores, como registrarlos o lanzar una excepción personalizada.
                return new List<Pregunta>(); // En caso de error, retorna una lista vacía o nula.
            }
        }
    }
}
