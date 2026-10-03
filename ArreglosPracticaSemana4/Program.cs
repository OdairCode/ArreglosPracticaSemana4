using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosPracticaSemana4
{
    internal class Program
    {
        static float num1 = 0, num2 = 0, resultado = 0; //variables globales para almacenar los
                                                        //números y el resultado

        static void solicitardatos()
        {
            Console.WriteLine("Digite el primer número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo número: ");
            num2 = float.Parse(Console.ReadLine());
        }


        static void suma() //método para realizar la suma de los dos números
        {
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }

        static void resta(float n1, float n2) //método para realizar la resta de los dos números
        {
            resultado = n1 - n2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
        }

        static float multiplicacion()
        {
            return num1 * num2; //método para realizar la multiplicación
                                //de los dos números
        }

        static float dividir(float n1, float n2) //método para realizar la división de los dos números
        {
           if (n2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0; // Retorna 0 o algún valor que indique error
            }
            else
            {
                return n1 / n2;
            }
        }
        static void menu()
        {
            int opcion; //variable local para almacenar la opción seleccionada
                        //por el usuario
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Digite una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    solicitardatos();
                    suma();
                    
                    break;
                case 2:
                    solicitardatos();
                    resta(num1, num2);
                    break;
                case 3:
                    solicitardatos();
                    Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion());
                    break;
                case 4:
                    solicitardatos();
                    Console.WriteLine("El resultado de la división es: " + dividir(num1, num2));
                    break;
                case 5:
                    Console.WriteLine("Salir");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }




        }

        static void Main(string[] args)
        {
            menu();
        }

        //Que hace el código:
        //Este código es un programa de consola en C# que permite al
        //usuario realizar operaciones matemáticas básicas (suma, resta, multiplicación y división)
        //entre dos números. El programa solicita al usuario que ingrese
        //dos números y luego le presenta un menú con opciones para elegir la operación que desea realizar.
        //Dependiendo de la opción seleccionada, el programa ejecuta la
        //operación correspondiente y muestra el resultado en la consola.
        //Además, incluye manejo de errores
        //para evitar la división por cero.

        //Que se hizo en el código:
        //Se implementó un menú interactivo que permite al usuario seleccionar la operación matemática que desea realizar.
        //Se crearon métodos para cada operación matemática (suma, resta, multiplicación y división).
        //Se incluyó manejo de errores para evitar la división por cero.


        //Temas q se abordó:
        //- Variables globales y locales
        //- Métodos y funciones
        //- Estructuras de control (switch-case)

        //Que significa cada tema:
        //- Variables globales y locales: Las variables globales son aquellas que se declaran fuera
        //de cualquier método y pueden ser accedidas desde cualquier parte del programa.
        //Las variables locales son aquellas que se declaran dentro de un método y solo pueden
        //ser accedidas dentro de ese método.


        //- Métodos y funciones: Los métodos son bloques de código que realizan una tarea específica
        //y pueden ser llamados desde otras partes del programa.

        //- Estructuras de control (switch-case): Las estructuras de control permiten tomar decisiones
        //o ejecutar diferentes bloques de código según ciertas condiciones. El switch-case es una estructura
        //de control que permite evaluar una variable y ejecutar diferentes bloques de código según su valor.
        
    }
}
