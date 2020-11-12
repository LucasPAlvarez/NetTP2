using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class EspecialidadLogic: BusinessLogic {

        EspecialidadAdapter especialidadData;

        public EspecialidadLogic() {
            especialidadData = new EspecialidadAdapter();
        }

        public List<Especialidad> GetAll() {
            return especialidadData.GetAll();
        }

        public Especialidad GetOne(int id) {
            return especialidadData.GetOne(id);
        }

        public void Save(Especialidad especialidad) {
            especialidadData.Save(especialidad);
        }
    }
}
