using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Escriba un programa de aplicación que reciba una lista de palabras e informe cuáles son palíndromos usando una 
             * función. En el programa principal, al ingresar las palabras resuelva el ejercicio:
             * i. A) utilizando la sentencia while
             * ii. B) utilizando la sentencia for
             * iii. C) utilizando la sentencia foreach 
             */

            string[] arrayStrListaPalabras = new string[5] {"murcielago", "neuquen", "argentina", "radar", "avion"};
            
            // i.

            int intContador = 0; // Declaro y genero un contador para el while
            
            while (intContador != arrayStrListaPalabras.Length) // Genero el while mientras que el contador sea distinto a la cantidad de elementos del arreglo
            {

                if (esPalindromo(arrayStrListaPalabras[intContador])) // Si es palindromo devuelve su correspondiente mensaje
                {
                    Console.WriteLine($"La palabra {arrayStrListaPalabras[intContador++]} es palindromo");
                }
                else // Si no es palindromo devuelve su correspondiente mensaje
                {
                    Console.WriteLine($"La palabra {arrayStrListaPalabras[intContador++]} no es palindromo");
                }

            }

            Console.ReadKey(); // Pausa

            // ii.

            for (int i = 0; i < arrayStrListaPalabras.Length; i++) // Genero el for correspondiente
            {
                
                if (esPalindromo(arrayStrListaPalabras[i])) // Si es palindromo devuelve su correspondiente mensaje
                {
                    Console.WriteLine($"La palabra {arrayStrListaPalabras[i]} es palindromo");
                }
                else // Si no es palindromo devuelve su correspondiente mensaje
                {
                    Console.WriteLine($"La palabra {arrayStrListaPalabras[i]} no es palindromo");
                }
            }

            Console.ReadKey(); // Pausa

            // iii.
            
            foreach (string strPalabra in arrayStrListaPalabras) // Genero el Foreach correspondiente
            {

                if (esPalindromo(strPalabra)) // Si es palindromo devuelve su correspondiente mensaje
                {
                    Console.WriteLine($"La palabra {strPalabra} es palindromo");
                }
                else // Si no es palindromo devuelve su correspondiente mensaje
                {
                    Console.WriteLine($"La palabra {strPalabra} no es palindromo");
                }

            }

            Console.ReadKey(); // Pausa

        }

        public static bool esPalindromo(string strPalabra) // funcion para verificar si es o no palindromo
        {

            int intCantidadLetras = strPalabra.Length; // Se guarda la cantidad de letras
            
           
            for (int intFor = 1; intFor -1 < intCantidadLetras; intFor++) // Recorro el string ingresado
            {
                    
                if (strPalabra[intFor -1] != strPalabra[intCantidadLetras - intFor]) // Verifico si hay algun valor que sea distinto
                {

                    return false; // Si encuentra un valor distinto retorna que no es un palindromo

                }
                    
            }

            return true; // Si no se encuentra un valor distinto retorna que es un palindromo
           
        }
    }
}
