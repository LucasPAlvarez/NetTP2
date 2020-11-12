using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class Usuario : BusinessEntity {

        private string _nombreUsuario;
        public string NombreUsuario {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private string _clave;
        public string Clave {
            get { return _clave; }
            set { _clave = value; }
        }


        private bool _habilitado;
        public bool Habilitado {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        int _idPlan;
        public int IdPlan {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        int _idPersona;
        public int IdPersona {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        TiposUsuarios _tipoUsuario;
        public TiposUsuarios TipoUsuario {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }
    }

    public enum TiposUsuarios {
        superUser,
        alumno,
        docente
    }
}
