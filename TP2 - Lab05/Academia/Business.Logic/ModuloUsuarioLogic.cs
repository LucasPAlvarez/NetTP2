using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class ModuloUsuarioLogic: BusinessLogic {

        ModuloUsuarioAdapter moduloUsuarioData = new ModuloUsuarioAdapter();

        public ModuloUsuarioLogic() {
            moduloUsuarioData = new ModuloUsuarioAdapter();
        }

        public ModuloUsuario GetByUserID(int id) {
            return moduloUsuarioData.GetUsuarioModulos(id);
        }
    }
}
