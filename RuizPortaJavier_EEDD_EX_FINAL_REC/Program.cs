using RuizPortaJavier_EEDD_EX_FINAL_REC.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EEDD_EX_FINAL_REC
{
    class Program
    {
        static ClinicaVeterinaria yasev = new ClinicaVeterinaria();

        static void Main(string[] args)
        {
            bool continuar = true;
            string eleccion = "";

            do
            {
                //Eslogan de la CLinica YASEV :)

                Console.WriteLine("---------------Clinica Veterinaria---------------");
                Console.WriteLine("--------------------YASEV--------------------");

                /*
                 Implementamos el primer menu donde el cliente podra seleccionar lo que desea hacer.
                */

                Console.WriteLine();
                Console.WriteLine("1-Añadir animal");
                Console.WriteLine("2-Modificar comentarios");
                Console.WriteLine("3-Pesar animal");
                Console.WriteLine("4-Mostrar por pantalla animal");
                Console.WriteLine("5-Salir");
                Console.WriteLine();
                Console.Write("Elige una opcion mediante teclado numérico(1-5): ");
                eleccion = Console.ReadLine();
                switch (eleccion)
                {
                    case "1":
                        Console.Clear();
                        MenuAnimal();
                        break;
                    case "2":
                        Console.Clear();
                        ModificarComentario();
                        break;
                    case "3":
                        Console.Clear();
                        ModificarPeso();
                        break;
                    case "4":
                        Console.Clear();
                        MostrarAnimal();
                        break;
                    case "5":
                        continuar = false;
                        break;

                }
            } while (continuar);
        }



        /*
            Creamos el metodo para cambiar al menu de animal en este caso es al seleccionar 1. en el primer menu.
        */

        static void MenuAnimal()
        {
            string tipo = "";
            string nombre = "";
            string fechanacimiento = "";
            double peso = 0;
            string raza = "";
            string microship = "";
            bool venenosoCantador = true;
            string comentario = "";

            bool control = true;
            string aux = "";
            bool continuar = true;
            

            do
            {
                Console.Clear();
                Console.WriteLine("---------------Tipos---------------");
                Console.WriteLine("1-Perro");
                Console.WriteLine("2-Gato");
                Console.WriteLine("3-Pajaro");
                Console.WriteLine("4-Reptil");
                Console.WriteLine("5-Salir");
                Console.WriteLine("-----------------------------------");
                Console.Write("Elige el tipo de animal (1-5): ");
                tipo = Console.ReadLine();

                if (!tipo.Equals("5") && !tipo.Equals("") && tipo.Equals("1") && tipo.Equals("2") && tipo.Equals("3") && tipo.Equals("4"))
                {
                    Console.Clear();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();

                    Console.Write("Fecha de nacimiento: ");
                    fechanacimiento = Console.ReadLine();

                    do
                    {
                        control = true;
                        Console.Write("Peso: ");
                        if (double.TryParse(Console.ReadLine(), out peso))
                        {
                            if (peso > 0)
                                control = false;
                            else
                                Console.WriteLine("ERROR: El peso tiene que ser mayor a 0");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: El peso no es valido,no insertaste un valor númerico");
                        }

                    } while (control);
                }
                switch (tipo)
                {
                    case "1":
                        Console.Write("Raza: ");
                        raza = Console.ReadLine();
                        Console.Write("Microship: ");
                        microship = Console.ReadLine();
                        Console.Write("Comentario: ");
                        comentario = Console.ReadLine();


                        yasev.InsertarAnimal(new Perro(nombre, raza, fechanacimiento, peso, microship, comentario));
                        break;
                    case "2":
                        Console.Write("Raza: ");
                        raza = Console.ReadLine();
                        Console.Write("Microship: ");
                        microship = Console.ReadLine();
                        Console.Write("Comentario: ");
                        comentario = Console.ReadLine();

                        yasev.InsertarAnimal(new Gato(nombre, raza, fechanacimiento, peso, microship, comentario));
                        break;
                    case "3":
                        

                        Console.Write("Especie: ");
                        raza = Console.ReadLine();
                        
                        do
                        {
                            Console.Write("¿Cantor?: ");
                            Console.Write("Porfavor contestes con SI o NO: ");
                            aux = Console.ReadLine();

                            if (aux.Equals("Si") || aux.Equals("SI") || aux.Equals("si"))
                            {
                                venenosoCantador = true;
                                control = true;


                            }
                            else if (aux.Equals("No") || aux.Equals("NO") || aux.Equals("no"))
                            {
                                control = true;
                                venenosoCantador = false;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: No has dicho Si o No");
                                control = false;
                            }
                        } while (!control);
                        
                        Console.Write("Comentario: ");
                        comentario = Console.ReadLine();
                        

                        yasev.InsertarAnimal(new Pajaro(nombre, raza, fechanacimiento, peso, venenosoCantador, comentario));
                        break;
                    case "4":
                        

                        Console.Write("Especie: ");
                        raza = Console.ReadLine();
                        do
                        {
                            Console.Write("¿Venenoso?: ");
                            Console.Write("Porfavor contestes con SI o NO: ");
                            aux = Console.ReadLine();

                            if (aux.Equals("Si") || aux.Equals("SI") || aux.Equals("si"))
                            {
                                venenosoCantador = true;
                                control = true;


                            }
                            else if (aux.Equals("No") || aux.Equals("NO") || aux.Equals("no"))
                            {
                                control = true;
                                venenosoCantador = false;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: No has dicho Si o No");
                                control = false;
                            }
                        } while (!control);

                        Console.Write("Comentario: ");
                        comentario = Console.ReadLine();

                        yasev.InsertarAnimal(new Reptil(nombre, raza, fechanacimiento, peso, venenosoCantador, comentario));
                        break;
                    case "5":
                        Console.WriteLine("Has elegido SALIR");
                        Console.Clear();
                        continuar = false;
                        break;
                }
            } while (continuar);
        }

        /*
            Creamos el metodo para cambiar el comentario en este caso es al seleccionar 2. en el primer menu.
        */

        static void ModificarComentario()
        {
            string nombre = "", comentario = "";
            Console.Clear();
            Console.Write("Nombre del animal: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Nuevo comentario:");
            comentario = Console.ReadLine();


            try
            {
                yasev.ModificaComentarioAnimal(nombre, comentario);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Clear();
        }


        /*
            Creamos el metodo para cambiar el peso en este caso es al seleccionar 3. en el primer menu.
        */

        static void ModificarPeso()
        {
            string nombre = "";
            double nPeso = 0;
            bool esCorrecto = true;
            Console.Clear();
            Console.Write("Nombre del animal: ");
            nombre = Console.ReadLine();
            do
            {
                Console.Write("Nuevo Peso: ");
                if (double.TryParse(Console.ReadLine(), out nPeso))
                {
                    if (nPeso > 0)
                    {
                        esCorrecto = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El peso tiene que ser mayor a 0");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: El peso tiene que ser un valor númerico");
                }
            } while (esCorrecto);

            try
            {
                yasev.PesarAnimal(nombre, nPeso);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Clear();
        }

        /*
            Creamos el metodo para mostrar la ficha del animal en este caso es al seleccionar 4. en el primer menu.
        */

        static void MostrarAnimal()
        {
            string nombre = "";
            Animal aux;
            Console.Clear();
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            aux = yasev.BuscaAnimal(nombre);
            if (aux != null)
            {
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("Ficha Animal");
                Console.WriteLine("-------------");
                Console.WriteLine(aux);
            }
            else
            {
                Console.WriteLine("ERROR: No se encontro un animal con ese nombre");
            }
        }
    }
}
