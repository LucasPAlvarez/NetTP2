using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities {
    public class BusinessEntity {

        public BusinessEntity() {
            state = States.New;
        }


        private int _ID;
        public int ID {
            get { return _ID; }
            set { _ID = value; }
        }


        private States _state;
        public States state {
            get { return _state; }
            set { _state = value; }
        }



        public enum States {
            Delete,
            New,
            Modified,
            Unmodified
        }
    }
}
