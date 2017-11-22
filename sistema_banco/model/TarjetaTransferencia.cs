using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.model {
    public class TarjetaTransferencia {
        private int id;
        private string codigos;
        private int user;

        public TarjetaTransferencia() {
           
        }

        public int Id { get => id; set => id = value; }
        public string Codigos { get => codigos; set => codigos = value; }
        public int User { get => user; set => user = value; }
    }
}