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
        static Persona datosPersonales;

        static ModuloUsuario _permiso;

        public static void SetUsuario(Usuario user) {
            usuario = user;
            datosPersonales = new PersonaLogic().GetOne(user.IdPersona);
            ModuloUsuarioLogic muLogic = new ModuloUsuarioLogic();

            _permiso = muLogic.GetByUserID(usuario.ID);
        }

        public static string GetUsrName() {
            return usuario.NombreUsuario;
        }

        public static int GetUsrId() {
            return usuario.ID; //ver si es el id del alumno o de la persona y cambiar si necesario
        }

        public static string GetPersonaName() {
            return datosPersonales.Apellido + " " + datosPersonales.Nombre;
        }

        public static string GetPlanName() {
            Plan userPlan = new PlanLogic().GetOne(usuario.IdPlan);
            return userPlan.Desripcion;
        }

        public static ModuloUsuario Permiso {
            get {
                return _permiso;
            }
        }
    }
}
