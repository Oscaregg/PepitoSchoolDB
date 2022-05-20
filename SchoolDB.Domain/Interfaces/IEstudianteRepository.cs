using SchoolDB.Domain.Entities;
using SchoolDB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Domain.Interfaces
{
    public interface IEstudianteRepository : IRepository<Estudiante>
    {
        Estudiante FindById(int id);
        Estudiante FindByName(string name);
        Estudiante FinByCarnet(string carnet);

        decimal Promedio(Estudiante estudiante);

    }
}
