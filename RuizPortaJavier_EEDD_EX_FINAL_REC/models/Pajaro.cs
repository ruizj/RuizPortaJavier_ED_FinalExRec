using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EEDD_EX_FINAL_REC.models
{
    class Pajaro : Animal
    {
        //atributos
        private string especie;
        private bool cantor;

        //Constructor
        public Pajaro(string nombre, string especie, string fechaNacimiento, double peso, bool cantor, string comentarios) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            Especie = especie;
            Cantor = cantor;
        }

        //propiedades
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public bool Cantor
        {
            get { return cantor; }
            set { cantor = value; }
        }

        //metodos
        public override string ToString()
        {
            return "Ficha de Pajaro \n Nombre: " + this.nombre + "\n Especie: " + this.especie + "\n Fecha de Nacimiento: " + this.fechanacimiento + "\n Peso: " + this.peso + "\n Cantor: " + ((this.cantor) ? "Si" : "No") + "\n Comentario: " + this.comentarios;
        }
    }
}
