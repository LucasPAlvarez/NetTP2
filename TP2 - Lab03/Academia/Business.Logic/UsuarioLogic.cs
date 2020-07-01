using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class UsuarioLogic : BusinessLogic {

        UsuarioAdapter UsuarioData;


        public UsuarioLogic() {
            UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int ID) {
            return UsuarioData.GetOne(ID);
        }

        public List<Usuario> GetAll() {
            return UsuarioData.GetAll();
        }

        public void Save(Usuario user) {
            UsuarioData.Save(user);
        }

        public void Delete(int ID) {
            UsuarioData.Delete(ID);
        }
    }
}
