using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    class Comision: BusinessEntity {

        int _anioEspecialidad;
        public int anioEspecialidad {
            get { return _anioEspecialidad;}
            set { _anioEspecialidad = value; }
        }

        int _idPlan;
        public int idPlan {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        string _descripcion;
        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
