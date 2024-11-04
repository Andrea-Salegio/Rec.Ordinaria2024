using Refuerzo2024.Model.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuerzo2024.Model.DTO
{
    internal class DTOAsignaturas : dbContext
    {
        private int idAsignatura;
        private string nombreAsignatura;
        private int codigo;
        private int idEspecialidad;

        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
        public int Codigo { get => codigo; set =>codigo = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
    }
}
