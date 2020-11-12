using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetAlldt() {
            return personaData.GetAlldt();
        }

        public Persona GetOne( int ID) {
            return personaData.GetOne(ID);
        }

        public void Save(Persona persona) {
            personaData.Save(persona);
        }

        public void Delete(Persona persona) {
            personaData.Delete(persona.ID);
        }
    }
}
