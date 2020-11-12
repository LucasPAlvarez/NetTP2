using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    public class Plan : BusinessEntity {
        int _idEspecialidad;
        public int IdEspecialidad {
            get { return _idEspecialidad; }
            set { _idEspecialidad = value; }
        }

        string _descripcion;
        public string Desripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }

}
