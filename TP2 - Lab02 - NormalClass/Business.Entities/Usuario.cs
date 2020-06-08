using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class Usuario : BusinessEntity {

        private string _nombreUsuario;
        public string nombreUsuario {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private string _clave;
        public string clave {
            get { return _clave; }
            set { _clave = value; }
        }

        private string _nombre;
        public string nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;
        public string apellido {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _email;
        public string email {
            get { return _email; }
            set { _email = value; }
        }

        private bool _habilitado;
        public bool habilitado {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
    }
}
