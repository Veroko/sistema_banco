using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.model {
    public class cuenta {

        private int id;
        private int usuario;
        private int tipoCuenta;
        private int saldo;

        public int Id { get => id; set => id = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public int TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public int Saldo { get => saldo; set => saldo = value; }
    }
}