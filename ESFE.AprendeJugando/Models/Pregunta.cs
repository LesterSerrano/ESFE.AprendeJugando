using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.AprendeJugando.Models
{
    public class Pregunta
    {
        public string PreguntaText { get; set; }
        public List<string> OpcionesRespuesta { get; set; }
        public int RespuestaCorrecta { get; set; }
    }
}
