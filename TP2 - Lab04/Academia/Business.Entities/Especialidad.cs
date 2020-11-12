using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    class Especialidad: BusinessEntity {

        string _descripcion;
        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
