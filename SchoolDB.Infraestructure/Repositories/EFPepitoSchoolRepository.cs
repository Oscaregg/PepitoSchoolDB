using SchoolDB.Domain.Entities;
using SchoolDB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Infraestructure.Repositories
{
    public class EFPepitoSchoolRepository : IEstudianteRepository
    {
        private IPepitoSchoolContext pepitoSchoolContext;

       

        public EFPepitoSchoolRepository(IPepitoSchoolContext pepitoSchoolContext)
        {
            this.pepitoSchoolContext = pepitoSchoolContext;
        }
        public void Create(Estudiante t)
        {

            try
            {
                pepitoSchoolContext.Estudiantes.Add(t);
                pepitoSchoolContext.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Delete(Estudiante t)
        {
            try
            {
                pepitoSchoolContext.Estudiantes.Remove(t);
                pepitoSchoolContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Estudiante FinByCarnet(string carnet)
        {
            try
            {
                return pepitoSchoolContext.Estudiantes.FirstOrDefault(x => x.Carnet.Equals(carnet));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                return pepitoSchoolContext.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindByName(string name)
        {
            try
            {
                return pepitoSchoolContext.Estudiantes.FirstOrDefault(x => x.Nombres.Equals(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            try
            {
                return pepitoSchoolContext.Estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public decimal Promedio(Estudiante estudiante)
        {
            try
            {
                if (estudiante is null)
                {
                    throw new ArgumentNullException(nameof(estudiante));
                }

                decimal nota = 0;

                nota = estudiante.Estadistica + estudiante.Matematicas + estudiante.Contabilidad + estudiante.Programacion;
                return nota / 4;
            }
            catch (Exception)
            {
                throw;
            }  
        }

        public void Update(Estudiante t)
        {
            try
            {
                if (t is null)
                {
                    throw new ArgumentNullException(nameof(t));
                }

                Estudiante estudiante = FindById(t.Id);

                if (estudiante is null)
                {
                    throw new ArgumentNullException("El objeto no puede ser null o estar vacio");
                }

                estudiante.Nombres = t.Nombres;
                estudiante.Apellidos = t.Apellidos;
                estudiante.Phone = t.Phone;
                estudiante.Correo = t.Correo;
                estudiante.Direccion = t.Direccion;
                estudiante.Estadistica = t.Estadistica;
                estudiante.Programacion = t.Programacion;
                estudiante.Matematicas = t.Matematicas;
                estudiante.Contabilidad = t.Contabilidad;

                pepitoSchoolContext.Estudiantes.Update(estudiante);
                pepitoSchoolContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
