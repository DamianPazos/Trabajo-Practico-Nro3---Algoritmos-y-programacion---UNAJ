using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_2
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Desarrolle un programa de aplicación que simule la inscripción de participantes de distintas escuelas a una 
             * competencia de matemática. De cada alumno se conoce su Dni y el nombre de la escuela a la que representa. 
             * Pueden inscribirse (en forma desordenada) varios alumnos de la misma escuela. Arme un menú que permita:
             * a. Inscribir un alumno (armar una lista de alumnos inscriptos)
             * b. Borrar un alumno (eliminarlo de la lista de alumnos inscriptos)
             * c. Indicar total de alumnos inscriptos
             * d. Indicar total de escuelas que al menos tienen un alumno inscripto (armar una lista de escuelas)
             * e. Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones.
             */

            // Variables

            bool boolBanderaMenu = true; // Bandera para el while del menu
            string strOpcionMenu; // Opcion de menu que se ingresa
            ArrayList arrayListAlumnos = new ArrayList(); // Lista de alumnos
            ArrayList arrayListEscuelas = new ArrayList(); // Lista de escuela
            string strNombreAlumno; // Nombre del alumno
            string strNombreEscuela; // Nombre de la escuela
            bool boolAgregarEscuela = true; // Indicador para no agregar escuelas repetidas

            // Resolucion

            while (boolBanderaMenu) // Se genera el bucle del menu
            {
                Console.WriteLine("1.Inscribir alumno\n2.Borrar alumno\n3.Total de alumnos\n4.Total de escuelas\n5.Listado de escuelas\n6.Salir");
                Console.Write("Ingrese el numero de opcion que desee: ");
                strOpcionMenu = Console.ReadLine(); // Ingreso del valor del menu

                switch (strOpcionMenu)
                {
                    case "1": // Opcion de ingreso de alumno
                        
                        Console.Write("Ingrese el nombre del alumno: ");
                        strNombreAlumno = Console.ReadLine(); // Ingreso del nombre del alumno
                        arrayListAlumnos.Add(strNombreAlumno); // Se ingresa el nombre del alumno a la lista
                        
                        Console.Write("Ingrese el nombre de la escuela del alumno: ");
                        strNombreEscuela = Console.ReadLine(); // Ingreso de la escuela del alumno
                        
                        foreach (string escuela in arrayListEscuelas) // Se recorre la lista de escuelas
                        {
                            if (escuela == strNombreEscuela) // Si la escuela se encuentra en la lista
                            {
                                boolAgregarEscuela = false; // Se cambia el indicador
                            }
                        }
                        if (boolAgregarEscuela) // Si no esta repetida se ingresa en la lista
                        {
                            arrayListEscuelas.Add(strNombreEscuela); // Se ingresa el nombre de la escuela a la lista
                        }
                        boolAgregarEscuela = true; // Se devuelve a la posicion inicial

                        pausaLimpiar(); 
                        break;

                    case "2": // Opcion de eliminar un alumno

                        int intContador = 0; // Contador del array, sirve para validar si ya se revisaron todas las opciones
                        
                        Console.Write("Ingrese el nombre del alumno que desea eliminar: ");
                        strNombreAlumno = Console.ReadLine(); // Ingreso del nombre del alumno

                        // Se recorre el ArrayList de los alumnos
                        for (int intForListaAlumno = 0; intForListaAlumno < arrayListAlumnos.Count; intForListaAlumno++)
                        {
                            
                            // Si se verifica que el nombre coincide con uno de los ya ingresados en la lista
                            if (strNombreAlumno == (string)arrayListAlumnos[intForListaAlumno])
                            {
                                arrayListAlumnos.Remove(strNombreAlumno); // Se elimina el alumno del ArrayList
                                Console.WriteLine("Se elimino correctamente");
                                
                                pausaLimpiar();
                                break;

                            }
                            else // Si no coinciden
                            {
                                intContador++; // Se suma al contador

                                if (intContador == arrayListAlumnos.Count) // Si el contador obtiene el valor de la cantidad de elementos del ArrayList
                                {
                                    Console.WriteLine("No se encontro el alumno ingresado"); // Se devuelve el mensaje
                                    pausaLimpiar();
                                    break;
                                }
                            }

                        }

                        break;
                    
                    case "3": // Opcion de total de alumnos

                        Console.WriteLine($"Cantidad de alumnos: {arrayListAlumnos.Count}");
                        pausaLimpiar();
                        break;

                    case "4": // Opcion de total de escuelas

                        Console.WriteLine($"Cantidad de escuelas: {arrayListEscuelas.Count}");
                        pausaLimpiar();
                        break;

                    case "5": // Opcion de mostrar todas las escuelas en orden alfabetico

                        arrayListEscuelas.Sort(); // Se ordenan los elementos del ArrayList
                        
                        // Se recorre el ArrayList y se imprime en consola su nombre
                        foreach (string escuela in arrayListEscuelas)
                        {
                            Console.WriteLine($"Escuela: {escuela}");
                        }

                        pausaLimpiar();
                        break;

                    case "6": // Salir del programa

                        boolBanderaMenu = false; // Se cambia la bandera del while
                        Console.WriteLine("Saliendo del programa ...");
                        pausaLimpiar();
                        break;

                    default: // Si se ingresa un valor erroneo

                        Console.WriteLine("Ingreso un valor invalido");
                        pausaLimpiar();
                        break;
                }

            }

        }

        // Funcion para la pausa y limpieza de la consola
        public static void pausaLimpiar()
        {
            Console.ReadKey(); // Pausa
            Console.Clear(); // Limpeza de consola
        }
    }
}