using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.AprendeJugando.Models;

namespace ESFE.AprendeJugando.Services
{
    public interface IPreguntaService
    {
        Task<List<Pregunta>> ObtenerPreguntas();
    }
}
