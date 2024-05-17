namespace EstructurasCondicionales.Class
{
    public class Programa1
    {
        public void CalcularPerimetro()
        {
            int lado = 0;
            int perimetro = 0;

            try
            {
                Console.WriteLine("Digite la longitud del lado del cuadrado: ");
                lado = int.Parse(Console.ReadLine());

                perimetro = lado * 4;

                Console.WriteLine($"El perimetro del cuadrado es: { perimetro }");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguente error: {ex.Message}");
            }
        }

        public void CalcularSumaProducto()
        {
            //variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;
            int producto = 0;

            try
            {
                Console.WriteLine("Ingrese el primer número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número: ");
                num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el cuarto número: ");
                num4 = int.Parse(Console.ReadLine());

                //Calcular
                suma = (num1 + num2);
                producto = (num3 * num4);

                Console.WriteLine($"La suma de los dos primeros numeros es: {suma}");
                Console.WriteLine($"El producto del tercer y cuarto numero es: {producto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }

        public void CalcularSumaPromedio()
        {
            //variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;
            int promedio = 0;

            try
            {
                Console.WriteLine("Ingrese el primer número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número: ");
                num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el cuarto número: ");
                num4 = int.Parse(Console.ReadLine());

                //Calcular
                suma = (num1 + num2 + num3 + num4);
                promedio = suma / 4;

                Console.WriteLine($"La suma de los cuatro números es: {suma}");
                Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }

    }
}
