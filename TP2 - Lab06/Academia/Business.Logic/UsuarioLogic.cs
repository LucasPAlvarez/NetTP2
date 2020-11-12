using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class UsuarioLogic: BusinessLogic {

        UsuarioAdapter UsuarioData;


        public UsuarioLogic() {
            UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int ID) {
            return UsuarioData.GetOne(ID);
        }

        public Usuario GetByUserName(string username) {
            return UsuarioData.GetByUserName(username);
        }

        public DataTable GetAll() {
            return UsuarioData.GetAll2();
        }

        public DataTable getAllChecked(bool alumnos, bool profesores, bool admin) {
            return UsuarioData.GetAllChecked(alumnos, profesores,admin);
        }

        public void Save(Usuario user) {
            UsuarioData.Save(user);
        }

        public void Delete(int ID) {
            UsuarioData.Delete(ID);
        }
    }
}
