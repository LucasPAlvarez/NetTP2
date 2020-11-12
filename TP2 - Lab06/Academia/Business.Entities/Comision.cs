using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    public class Comision : BusinessEntity {

        int _anioEspecialidad;
        public int AnioEspecialidad {
            get { return _anioEspecialidad;}
            set { _anioEspecialidad = value; }
        }

        int _idPlan;
        public int IdPlan {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        string _descripcion;
        public string Descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
