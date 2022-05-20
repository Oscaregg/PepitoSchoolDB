using SchoolDB.Appcore.Interfaces;
using SchoolDB.Domain.Entities;
using SchoolDB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Appcore.Services
{
    public class EstudiantesServices : IEstudianteService
    {
        private IEstudianteRepository estudianteRepository;

        public EstudiantesServices(IEstudianteRepository estudianteRepository)
        {
            this.estudianteRepository = estudianteRepository;
        }
        public void Create(Estudiante t)
        {
            estudianteRepository.Create(t);
        }

        public void Delete(Estudiante t)
        {
            estudianteRepository.Delete(t);

        }

        public Estudiante FindByCarnet(string carnet)
        {
           return estudianteRepository.FinByCarnet(carnet);
        }

        public Estudiante FindById(int id)
        {
            return estudianteRepository.FindById(id);
        }

        public Estudiante FindByName(string name)
        {
            return estudianteRepository.FindByName(name);
        }

        public List<Estudiante> GetAll()
        {
            return estudianteRepository.GetAll();
        }

        public decimal Promedio(Estudiante t)
        {
            return estudianteRepository.Promedio(t);
        }

        public void Update(Estudiante t)
        {
           estudianteRepository.Update(t);
        }
    }
}
