using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    class DocenteCurso: BusinessEntity {
        /*TiposCargo _hsSemanales;
        public int hsSemanales {
            get { return _hsSemanales; }
            set { _hsSemanales = value; }
        }*/

        int _idCurso;
        public int idCurso {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        int _idDocente;
        public int idDocente {
            get { return _idDocente; }
            set { _idDocente = value; }
        }
    }
}
