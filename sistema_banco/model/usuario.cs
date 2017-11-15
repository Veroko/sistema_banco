using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.model {
    public class Usuario {

        private int id;
        private String rut;
        private String nombre;
        private String correo;
        private String direccion;
        private String fono;
        private String clave;
        private int numCuenta;
        private int tar_coordenadas;
        
        public Usuario() {
           
        }

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Fono { get => fono; set => fono = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Tar_coordenadas { get => tar_coordenadas; set => tar_coordenadas = value; }
        public int NumCuenta { get => numCuenta; set => numCuenta = value; }
    }
}