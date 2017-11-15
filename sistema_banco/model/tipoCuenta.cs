using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.model {
    public class TipoCuenta {

        private int id;
        private String cuenta;

        public TipoCuenta() {

        }

        public int Id { get => id; set => id = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
    }
}