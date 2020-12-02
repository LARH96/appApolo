using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities
{
    public class Paciente
    {
        public byte[] Fotografia { get; set; }
        public string IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EjercicioFisico { get; set; }
        public string AlcoholTabaco { get; set; }
        public string Medicamentos { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
