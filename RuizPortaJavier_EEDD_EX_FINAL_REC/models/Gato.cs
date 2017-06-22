using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EEDD_EX_FINAL_REC.models
{
    class Gato : Animal
    {
        //atributos
        private string raza;
        private string microship;

        //Constructor
        public Gato(string nombre, string raza, string fechaNacimiento, double peso, string microship, string comentarios) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            Raza = raza;
            Microship = microship;
        }

        //propiedades
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public string Microship
        {
            get { return microship; }
            set { microship = value; }
        }


        //metodos
        public override string ToString()
        {
            return "Ficha de Gato\n Nombre: " + this.nombre + "\n Raza: " + this.raza + "\n Fecha de Nacimiento: " + this.fechanacimiento + "\n Peso: " + this.peso + "\n Microchip: " + this.microship + "\n Comentario: " + this.comentarios;
        }
    }
}
