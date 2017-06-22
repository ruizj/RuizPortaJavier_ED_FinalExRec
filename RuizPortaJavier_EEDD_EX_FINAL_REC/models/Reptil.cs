using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EEDD_EX_FINAL_REC.models
{
    class Reptil : Animal
    {
        //atributos
        private string especie;
        private bool venenoso;

        //Constructor
        public Reptil(string nombre, string especie, string fechaNacimiento, double peso, bool venenoso, string comentarios) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            Especie = especie;
            Venenoso = venenoso;
        }

        //propiedades
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public bool Venenoso
        {
            get { return venenoso; }
            set { venenoso = value; }
        }

        //metodos
        public override string ToString()
        {
            return "Ficha del Reptil\n Nombre: " + this.nombre + "\n Especie: " + this.especie + "\n fecha de Nacimiento: " + this.fechanacimiento + "\n Peso: " + this.peso + "\n Venenoso: " + ((this.venenoso) ? "Si" : "No") + "\n Comentario: " + this.comentarios;
        }
    }
}
