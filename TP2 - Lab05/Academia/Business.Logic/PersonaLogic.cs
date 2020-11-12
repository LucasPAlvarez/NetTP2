using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class PersonaLogic: BusinessLogic {

        PersonaAdapter personaData;

        public PersonaLogic() {
            personaData = new PersonaAdapter();
        }

        public List<Persona> GetAll() {
            return personaData.GetAll();
        }

        public Persona GetOne( int ID) {
            return personaData.GetOne(ID);
        }

        public List<Persona> GetAllAlumnos() {
            return personaData.GetAllAlumnos();
        }

        public List<Persona> GetAllProfesores() {
            return personaData.GetAllProfesores();
        }

        public void Save(Persona persona) {
            personaData.Save(persona);
        }

        public void Delete(Persona persona) {
            personaData.Delete(persona.ID);
        }
    }
}
