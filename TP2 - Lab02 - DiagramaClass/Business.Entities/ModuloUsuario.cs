using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class ModuloUsuario : BusinessEntity {
        private int _idUsuario;
        private int _idModulo;
        private bool _permiteAlta;
        private bool _permiteBaja;
        private bool _permiteModificacion;
        private bool _permiteConsulta;

        public int IdUsuario {
            get => default;
            set {
            }
        }

        public int IdModulo {
            get => default;
            set {
            }
        }

        public bool PermiteModificacion {
            get => default;
            set {
            }
        }

        public bool PermiteAlta {
            get => default;
            set {
            }
        }

        public bool PermiteBaja {
            get => default;
            set {
            }
        }

        public bool PermiteConsulta {
            get => default;
            set {
            }
        }
    }
}