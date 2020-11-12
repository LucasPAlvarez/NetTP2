using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    public class AlumnoInscripcion : BusinessEntity {
        int _idAlumno;
        public int idAlumno {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        int _idCurso;
        public int idCurso {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        int _nota;
        public int nota {
            get { return _nota; }
            set { _nota = value; }
        }

        string _condicion;
        public string condicion {
            get { return _condicion; }
            set { _condicion = value; }
        }
    }
}
