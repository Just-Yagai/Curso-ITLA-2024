namespace EstructuraRepeticiónFor.Class
{
    public class Tarea
    {
        public void valoresMayoresIguales()
        {
            int cantidadNumeros = 0;
            int contador = 0;
            int numeros = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de números: ");
                cantidadNumeros = int.Parse(Console.ReadLine());

                for (int i = 0; i < numeros; i++)
                {
                    Console.WriteLine("Ingrese la cantidad de números: ");
                    numeros = int.Parse(Console.ReadLine());

                    if (numeros >= 1000)
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"La cantidad de valores mayores o iguales a 1000 es: {contador}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            } 

        }
        public void superficeTriangular()
        {
            // Variables
            int cantidad = 0;
            int contador = 0;
            double triangulo = 0;
            double altura = 0;
            double superficie = 0;

            try
            {
                Console.Write("Ingrese la cantidad de triángulos: ");
                cantidad = int.Parse(Console.ReadLine());

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write($"Ingrese la base del triángulo {i + 1}: ");
                    triangulo = double.Parse(Console.ReadLine());

                    Console.Write($"Ingrese la altura del triángulo {i + 1}: ");
                    altura = double.Parse(Console.ReadLine());

                    superficie = (triangulo * altura) / 2;

                    if (superficie > 12)
                    {
                        contador++;
                    }

                    Console.WriteLine($"Triángulo {i + 1}: Base = {triangulo}, Altura = {altura}, Superficie = {superficie}");
                }
            }
            catch (Exception ex ) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }
        public void tablaMultiplicar()
        {
            //Variable
            int numero = 5;
            int limite = 10;
            int resultado = 0;

            try
            {
                for (int i = 1; i <= limite; i++)
                {
                    resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }
    }
}
