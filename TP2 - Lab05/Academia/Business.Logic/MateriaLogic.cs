using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
namespace Business.Logic {
    public class MateriaLogic: BusinessLogic {

        MateriaAdapter materiaData;

        public MateriaLogic() {
            materiaData = new MateriaAdapter();
        }

        public List<Materia> GetAll() {
            return materiaData.GetAll();
        }

        public Materia GetOne(int id) {
            return materiaData.GetOne(id);
        }

        public List<Materia> GetByPlanId (int planId) {
            return materiaData.GetByPlanId(planId);
        }
    }
}
