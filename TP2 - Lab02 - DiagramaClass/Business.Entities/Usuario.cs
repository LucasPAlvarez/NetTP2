using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class Usuario : BusinessEntity {
        private string _nombreUsuario;
        private string _nombre;
        private string _apellido;
        private string _clave;
        private string _email;
        private int _habilitado;

        public string NombreUsuario {
            get => default;
            set {
            }
        }

        public string Nombre {
            get => default;
            set {
            }
        }

        public string Apellido {
            get => default;
            set {
            }
        }

        public string Clave {
            get => default;
            set {
            }
        }

        public string Email {
            get => default;
            set {
            }
        }

        public bool Habilitado {
            get => default;
            set {
            }
        }
    }
}