using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    public class Materia : BusinessEntity {
        string _descripcion;
        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        int _idPlan;
        public int idPlan {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        int _hsSemanales;
        public int hsSemanales {
            get { return _hsSemanales; }
            set { _hsSemanales = value; }
        }

        int _hsTotales;
        public int hsTotales {
            get { return _hsTotales; }
            set { _hsTotales = value; }
        }
    }
}
