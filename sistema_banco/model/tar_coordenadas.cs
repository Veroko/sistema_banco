using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.model {
    public class Tar_coordenadas {

        private int id;
        private String seria_a;
        private String seria_b;
        private String seria_c;
        private String seria_d;
        private String seria_e;
        private String seria_f;
        private String seria_g;
        private String seria_h;
        private String seria_i;
        private String seria_j;
        private int usuario;

        public Tar_coordenadas() {

        }

        

        public int Id { get => id; set => id = value; }
        public string Seria_a { get => seria_a; set => seria_a = value; }
        public string Seria_b { get => seria_b; set => seria_b = value; }
        public string Seria_c { get => seria_c; set => seria_c = value; }
        public string Seria_d { get => seria_d; set => seria_d = value; }
        public string Seria_e { get => seria_e; set => seria_e = value; }
        public string Seria_f { get => seria_f; set => seria_f = value; }
        public string Seria_g { get => seria_g; set => seria_g = value; }
        public string Seria_h { get => seria_h; set => seria_h = value; }
        public string Seria_i { get => seria_i; set => seria_i = value; }
        public string Seria_j { get => seria_j; set => seria_j = value; }
        public int Usuario { get => usuario; set => usuario = value; }
    }
}