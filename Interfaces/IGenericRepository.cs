using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using PracticaLinQ.Models;

namespace PracticaLinQ.Interfaces
{
    public interface IGenericRepository<Entidad> where Entidad : BaseModel
    {
        public List<Entidad> ObtenerTodos();

        public Entidad ObtenerPorId(int id);

        public void AgregarT(Entidad Entidad);

        public void ActualizarT(Entidad entidad);

        public void EliminarT(int id);
    }
}