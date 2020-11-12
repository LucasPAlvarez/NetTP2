using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    public class Curso :BusinessEntity {
        int _anioCalendario;
        public int AnioCalendario {
            get { return _anioCalendario; }
            set { _anioCalendario = value; }
        }

        int _cupo;
        public int Cupo {
            get { return _cupo; }
            set { _cupo = value; }
        }

        int _idComision;
        public int IdComision {
            get { return _idComision; }
            set { _idComision = value; }
        }

        int _idMateria;
        public int IdMateria {
            get { return _idMateria; }
            set { _idMateria = value; }
        }
    }
    
}
