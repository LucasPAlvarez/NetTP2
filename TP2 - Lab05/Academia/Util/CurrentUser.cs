using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
namespace Util {
    public static class CurrentUser {

        static Usuario usuario;

        static ModuloUsuario _permiso;

        public static void SetUsuario(Usuario user) {
            usuario = user;
            ModuloUsuarioLogic muLogic = new ModuloUsuarioLogic();

            _permiso = muLogic.GetByUserID(usuario.ID);
        }

        public static string GetUsrName() {
            return usuario.NombreUsuario;
        }

        public static ModuloUsuario Permiso {
            get {
                return _permiso;
            }
        }
    }
}
