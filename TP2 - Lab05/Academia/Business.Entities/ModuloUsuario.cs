using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    public class ModuloUsuario : BusinessEntity {

        int _idModulo;
        public int idModulo {
            get { return _idModulo; }
            set { _idModulo = value; }
        }

        int _idUsuario;
        public int idUsuario {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        bool _permiteAlta;
        public bool permiteAlta {
            get { return _permiteAlta; }
            set { _permiteAlta = value; }
        }

        bool _permiteBaja;
        public bool permiteBaja {
            get { return _permiteBaja; }
            set { _permiteBaja = value; }
        }

        bool _permiteConsulta;
        public bool permiteConsulta {
            get { return _permiteConsulta; }
            set { _permiteConsulta = value; }
        }

        bool _permiteModificacion;
        public bool permiteModificacion {
            get { return _permiteModificacion; }
            set { _permiteModificacion = value; }
        }
    }
}
