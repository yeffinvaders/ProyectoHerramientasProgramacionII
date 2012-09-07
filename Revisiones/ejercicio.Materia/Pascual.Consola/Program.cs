using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pascual.Consola
{
    class Program
    {

       
        static List<Materia> listaMaterias = new List<Materia>();
       

        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 4)
            {
                MostrarMenu();



                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        RegistrarMateria();
                        break;
                    case 2:
                        ConsultarMateria();
                        break;
                    case 3:
                        ConsultarTodos();
                        break;
                    case 4:
                        
                        Console.WriteLine("\nHasta Luego!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta, intente de nuevo..\n");
                        break;            
                

                }

            }
            Console.WriteLine("pulse cualquier tecla para salir......");
            Console.ReadKey();

        }

        private static void ConsultarTodos()
        {
            Console.Clear();              
            foreach (Materia materia in listaMaterias)
            {
                
                Console.WriteLine("***********************************");
                Console.WriteLine("Nombre Materia: " + materia.nombre);
                Console.WriteLine("profesor: " + materia.profesor);
                Console.WriteLine("Nota: " + materia.nota);
                Console.WriteLine("***********************************");
                
            }
          
        }

        private static void ConsultarMateria()
        {
            string nomb = string.Empty;
            Materia materiaConsultada = new Materia();

            Console.Write("\nIngrese nombre de la materia a consultar: ");
            nomb = Console.ReadLine();

            materiaConsultada = listaMaterias.Find(p => p.nombre == nomb);


            if(materiaConsultada == null)
            {
                Console.Clear();
                
                Console.WriteLine("Materia no existe\n");
                
            }
            else 
            {
            Console.Clear();

            Console.WriteLine("\n***********************************");
            Console.WriteLine("Nombre: " + materiaConsultada.nombre);
            Console.WriteLine("Profesor: " + materiaConsultada.profesor);
            Console.WriteLine("Nota: " + materiaConsultada.nota);
            Console.WriteLine("***********************************");
            
            }
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*       MENU       *");
            Console.WriteLine("********************");

            Console.WriteLine("\n1.Registrar Materia");
            Console.WriteLine("2.Consultar Materia");
            Console.WriteLine("3.Consultar Todos");
            Console.WriteLine("4.Salir");


            Console.Write("\nDigite su opcion: ");
            
            
        }

        private static void RegistrarMateria()

        {
            Materia nuevaMateria = new Materia();

            Console.WriteLine("\nIngrese los siguientes datos: ");

            Console.Write("\nNombre de la Materia: ");
            nuevaMateria.nombre= Console.ReadLine();
            Console.Write("Profesor: ");
            nuevaMateria.profesor = Console.ReadLine();
            Console.Write("Nota: ");
            nuevaMateria.nota = Convert.ToDouble(Console.ReadLine());
                      
            listaMaterias.Add(nuevaMateria);
            Console.Clear();

            Console.WriteLine("Materia Registrada con exito!\n");
        }


    }
}
