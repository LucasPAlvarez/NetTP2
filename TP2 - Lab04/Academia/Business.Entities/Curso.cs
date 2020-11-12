using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    class Curso:BusinessEntity {
        int _anioCalendario;
        public int anioCalendario {
            get { return _anioCalendario; }
            set { _anioCalendario = value; }
        }

        int _cupo;
        public int cupo {
            get { return _cupo; }
            set { _cupo = value; }
        }

        string _descripcion;
        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        int _idComision;
        public int idComision {
            get { return _idComision; }
            set { _idComision = value; }
        }

        int _idMateria;
        public int idMateria {
            get { return _idMateria; }
            set { _idMateria = value; }
        }
    }
    
}
