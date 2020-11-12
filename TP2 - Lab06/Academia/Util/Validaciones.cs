using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Util {
    public class Validaciones {

        public static bool EsMailValido(string email) {
            string patron = "[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z0-9]{2,3}(?(.)[a-zA-Z0-9]{2,3})";
            if(Regex.IsMatch(email, patron)) {
                return true;
            }
            return false;
        }

    }
}
