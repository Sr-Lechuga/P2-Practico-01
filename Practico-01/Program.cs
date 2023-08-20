using Microsoft.VisualBasic;

namespace Practico_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opciones = { "Ejercicio 1", "Ejercicio 2", "Ejercicio 3", "Ejercicio 4", "Ejercicio 5", "Ejercicio 6", "Ejercicio 7", "Ejercicio 8" };
            while (true)
            {
                Console.WriteLine("*** Sleccione una opcion ***");
                Console.WriteLine("Presione 0 para salir del menú");
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i}. {opciones[i]}.");
                }
                string respuesta = Console.ReadLine() ?? "0";

                switch (respuesta)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Hasta luego!");
                        return;
                    case "1":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 1 ----------");
                        Ejercicio01();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 2 ----------");
                        Ejercicio02();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 3 ----------");
                        Ejercicio03();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 4 ----------");
                        Ejercicio04();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 5 ----------");
                        Ejercicio05();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 6 ----------");
                        Ejercicio06();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 7 ----------");
                        Ejercicio07();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("---------- Ejercicio 8 ----------");
                        Ejercicio08();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        break;
                }
            }
        }

        private static void Ejercicio01()
        {
            while (true)
            {
                int numero;
                //Generates a number between 0 and 2147183647
                int numeroRandom = new Random().Next(0, int.MaxValue);
               
                Console.WriteLine("Ingrese un numero: ");
                bool exito = int.TryParse(Console.ReadLine(), out numero);

                //Ask until a number is given
                while (!exito)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero: ");
                    exito = int.TryParse(Console.ReadLine(), out numero);
                }

                if (numero == 0)
                {
                    Console.Clear();
                    break;
                }

                Console.WriteLine($"La diferencia entre el numero ingresado {numero} y el aleatorio {numeroRandom} es: {Math.Abs(numero - numeroRandom)}");
            }
        }
        private static void Ejercicio02()
        {
            while (true)
            {
                int numero;
                Console.WriteLine("Ingrese un numero: ");
                bool exito = int.TryParse(Console.ReadLine(), out numero);

                //Ask until a number is given
                while (!exito)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    exito = int.TryParse(Console.ReadLine(), out numero);
                }

                if (numero == 0)
                {
                    Console.Clear();
                    break;
                }

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
        }
        private static void Ejercicio03()
        {
            //First number
            Console.WriteLine("Ingrese un numero: ");
            int numero01;
            bool exito = int.TryParse(Console.ReadLine(), out numero01);
            while (!exito)
            {
                Console.WriteLine("Ingrese un numero: ");
                exito = int.TryParse(Console.ReadLine(), out numero01);
            }

            //Second number
            Console.WriteLine("Ingrese otro numero: ");
            int numero02;
            exito = int.TryParse(Console.ReadLine(), out numero02);
            while (!exito)
            {
                Console.WriteLine("Ingrese otro numero: ");
                exito = int.TryParse(Console.ReadLine(), out numero02);
            }

            int min = Math.Min(numero01, numero02);
            int max = Math.Max(numero01, numero02);

            Console.WriteLine($"Los numeros pares entre {min} y {max} son:");
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        private static void Ejercicio04()
        {
            //First number
            Console.WriteLine("Ingrese un numero: ");
            int numero01;
            bool exito = int.TryParse(Console.ReadLine(), out numero01);
            while (!exito)
            {
                Console.WriteLine("Ingrese un numero: ");
                exito = int.TryParse(Console.ReadLine(), out numero01);
            }

            //Second number
            Console.WriteLine("Ingrese otro numero: ");
            int numero02;
            exito = int.TryParse(Console.ReadLine(), out numero02);
            while (!exito)
            {
                Console.WriteLine("Ingrese otro numero: ");
                exito = int.TryParse(Console.ReadLine(), out numero02);
            }

            int min = Math.Min(numero01, numero02);
            int max = Math.Max(numero01, numero02);

            //Second number
            Console.WriteLine("Ingrese el numero a buscar: ");
            int valor;
            exito = int.TryParse(Console.ReadLine(), out valor);
            while (!exito)
            {
                Console.WriteLine("Ingrese el numero a buscar: ");
                exito = int.TryParse(Console.ReadLine(), out valor);
            }

            if (min < valor && valor < max)
                Console.WriteLine($"El numero {valor} se encuentra entre {min} y {max}");
            else
                Console.WriteLine($"El numero {valor} NO se encuentra entre {min} y {max}");

            Console.ReadKey();
            Console.Clear();
        }
        private static void Ejercicio05()
        {
            int suma = 0;
            Console.WriteLine("Sume todos los nuemeros");
            Console.WriteLine("Para salir ingrese 0");
            while (true)
            {
                int numero;
                Console.WriteLine("Ingrese un numero: ");
                bool exito = int.TryParse(Console.ReadLine(), out numero);

                //Ask until a number is given
                while (!exito)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    exito = int.TryParse(Console.ReadLine(), out numero);
                }

                if (numero == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"La suma de todos los numeros ingresados es: {suma}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                    suma += numero;
            }
        }
        private static void Ejercicio06()
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int cantidadVocales = 0;

            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine() ?? "";
            //To make sure Upper case letter won't be a problem
            string palabraMinusculas = palabra.ToLower();

            foreach (char caracter in palabraMinusculas)
            {
                if (vocales.Contains(caracter))
                {
                    cantidadVocales++;
                }
            }

            Console.WriteLine($"La palabra {palabra} tiene un total de {cantidadVocales} vocal(es)");
            Console.ReadKey();
            Console.Clear();
        }
        private static void Ejercicio07()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine() ?? "";

            for (int i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[(palabra.Length - 1) - i]);
            }
            Console.ReadKey();
            Console.Clear();
        }
        private static void Ejercicio08()
        {
            int i = 0;
            bool esPalindromo = true;

            Console.WriteLine("Ingrese una palabra: ");
            string palabraIngresada = Console.ReadLine() ?? "";
            string palabra = palabraIngresada.ToLower();

            while (i <= (palabra.Length - i) && esPalindromo)
            {
                if (palabra[i] != palabra[(palabra.Length - 1) - i])
                    esPalindromo = false;
                i++;
            }

            if (esPalindromo)
                Console.WriteLine($"La palabra {palabraIngresada}, es palindroma");
            else
                Console.WriteLine($"La palabra {palabraIngresada}, NO es palindroma");

            Console.ReadKey();
            Console.Clear();
        }
    }

}