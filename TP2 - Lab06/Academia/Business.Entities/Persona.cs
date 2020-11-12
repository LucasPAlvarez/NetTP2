using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class Persona: BusinessEntity {

        string _nombre;
        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        string _apellido;
        public string Apellido {
            get { return _apellido; }
            set { _apellido = value; }
        }

        string _direccion;
        public string Direccion {
            get { return _direccion; }
            set { _direccion = value; }
        }

        string _email;
        public string Email {
            get { return _email; }
            set { _email = value; }
        }

        string _telefono;
        public string Telefono {
            get { return _telefono; }
            set { _telefono = value; }
        }

        DateTime _fechaNacimiento;
        public DateTime FechaNacimiento {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        int _legajo;
        public int Legajo {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public override string ToString() {
            return "" + Legajo + " - " + Apellido + " " + Nombre;
        }
    }
}
