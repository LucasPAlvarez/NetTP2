using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class Modulo: BusinessEntity {

        string _descripcion;
        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
