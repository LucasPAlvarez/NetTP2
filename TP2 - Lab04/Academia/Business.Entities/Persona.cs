using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities {
    class Persona: BusinessEntity {

        string _nombre;
        public string nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        string _apellido;
        public string apellido {
            get { return _apellido; }
            set { _apellido = value; }
        }

        string _direccion;
        public string direccion {
            get { return _direccion; }
            set { _direccion = value; }
        }

        string _email;
        public string email {
            get { return _email; }
            set { _email = value; }
        }

        string _telefono;
        public string telefono {
            get { return _telefono; }
            set { _telefono = value; }
        }

        DateTime _fechaNacimiento;
        public DateTime fechaNacimiento {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        int _idPlan;
        public int idPlan {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        int _legajo;
        public int legajo {
            get { return _legajo; }
            set { _legajo = value; }
        }

        //TiposPersonas _tipoPersona;
    }
}
