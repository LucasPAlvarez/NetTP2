using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class ComisionLogic: BusinessLogic {

        ComisionAdapter comisionData;

        public ComisionLogic() {
            comisionData = new ComisionAdapter();
        }

        public List<Comision> GetAll() {
            return comisionData.GetAll();
        }

        public Comision GetOne(int id) {
            return comisionData.GetOne(id);
        }

        public void Save(Comision comision) {
            comisionData.Save(comision);
        }
    }
}
