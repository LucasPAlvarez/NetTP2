using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic {
    public class ModuloLogic: BusinessLogic {

        ModuloAdapter moduloData;

        public ModuloLogic() {
            moduloData = new ModuloAdapter();
        }

        public List<Modulo> GetAll() {
            return moduloData.GetAll();
        }
    }
}
