using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class BusinessEntity {
        private int _id;
        private States _state;

        public int Id {
            get => default;
            set {
            }
        }

        public States State {
            get => default;
            set {
            }
        }
    }

    public enum States {
        Deleted,
        New,
        Modified,
        Unmodified
    }
}