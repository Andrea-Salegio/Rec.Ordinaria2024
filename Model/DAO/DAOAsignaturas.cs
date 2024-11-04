using Refuerzo2024.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuerzo2024.Model.DAO
{
    internal class DAOAsignaturas : DTOAsignaturas
    {
        readonly SqlCommand conexion = new SqlCommand();

        public int AgregarAsignaturas()
        { 
            try
            {
                Conexion.Conection = ObtenerConexion();
                string consultaSQL = "INSERT INTO Asignaturas (idAsignatura, nombreAsignatura, codigo, idEspecialidad) (@idAsignatura, @nombreAsignatura, @codigo, @idEspecialidad)";
                SqlCommand objAgregarAsignaturas = new SqlCommand(consultaSQL, Conexion.Conection);
                objAgregarAsignaturas.Parameters.AddWithValue("idAsignatura", idAsignatura);
                objAgregarAsignaturas.Parameters.AddWithValue("nombreAsignatura", nombreAsignatura);
                objAgregarAsignaturas.Parameters.AddWithValue("codigo", codigo);
                objAgregarAsignaturas.Parameters.AddWithValue("idEspecialidad", idAsignatura);

            }
             

        }
    }
}
