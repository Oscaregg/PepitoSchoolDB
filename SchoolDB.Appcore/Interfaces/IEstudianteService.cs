using SchoolDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Appcore.Interfaces
{
    public interface IEstudianteService : IService<Estudiante>
    {
        Estudiante FindById(int id);
        Estudiante FindByName(string name);
        Estudiante FindByCarnet(string carnet);
        decimal Promedio(Estudiante t);
    }
}
